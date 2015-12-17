using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * Math DOT NET Numerics
 * PM> Install-Package MathNet.Numerics
 **/
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Patterns_Recognition___Task_1
{
    class Generic_State_Of_Nature
    {
        int num_of_features,
            num_of_training_samples,
            num_of_test_samples;

        public Sample[] training_samples,
            test_samples;

        public string label;

        public double[,] meus_vector;
        public double[] sigma_vector;
        public double[,] covariance_matrix;

        public double[] transpose_meus_vector;
        public double[,] inverse_covariance_matrix;
        public double[,] transpose_covariance_matrix;

        public double priori;

        public Matrix<double> Vector_Meu, Vector_Meu_Transpose;
        public Matrix<double> Matrix_Sigma, Matrix_Sigma_Transpose, Matrix_Sigma_Inverse;

        public Generic_State_Of_Nature(int _num_of_features, int _num_training_samples, int _num_of_test_samples, double _priori)
        {
            num_of_features = _num_of_features;

            num_of_training_samples = _num_training_samples;
            num_of_test_samples = _num_of_test_samples;

            priori = _priori;

            training_samples = new Sample[num_of_training_samples];
            test_samples = new Sample[_num_of_test_samples];
        }

        public double[,] calculate_meus_vector_from_samples()
        {
            meus_vector = new double[num_of_features,1];
            double[] sums = new double[num_of_features];
            for (int j = 0; j < num_of_features; j++)
            {
                sums[j] = 0;
            }
            for (int i = 0; i < training_samples.Length; i++)
            {
                for (int j = 0; j < num_of_features; j++)
                {
                    sums[j] += training_samples[i].features_values[j,0];
                }
            }
            for (int j = 0; j < num_of_features; j++)
            {
                meus_vector[j,0] = sums[j] / num_of_training_samples;
            }
            /**
             * Use MathDotNET Numerics
             **/
            this.Vector_Meu = Matrix<double>.Build.DenseOfArray(meus_vector);
            this.Vector_Meu_Transpose = this.Vector_Meu.Transpose();
            return meus_vector;
        }

        public double[] calculate_sigmas_vector_from_samples()
        {
            double[] ret = new double[num_of_features];
            return ret;
        }

        public double[,] calculate_covariance_matrix_from_samples()
        {
            covariance_matrix = new double[num_of_features, num_of_features];
            for (int i = 0; i < num_of_features; i++)
            {
                for (int j = 0; j < num_of_features; j++)
                {
                    /**
                     * sigma[i, j]2 = summation[(x[i]-meu[i])*(x[j]-meu[j])] / n
                     **/
                    covariance_matrix[j, i] = 0; // note j, i  because the matrix is in column-major-order
                    for (int k = 0; k < num_of_training_samples; k++)
                    {
                        covariance_matrix[j, i] += (training_samples[k].features_values[i,0] - meus_vector[i,0]) * (training_samples[k].features_values[j,0] - meus_vector[j,0]);
                    }
                    covariance_matrix[j, i] = covariance_matrix[j, i] / num_of_training_samples;
                }
            }
            /**
             * Use MathDotNET Numerics
             **/
            Matrix_Sigma = Matrix<double>.Build.DenseOfArray(covariance_matrix);
            double x = Matrix_Sigma[0, 1];
            Matrix_Sigma_Transpose = Matrix_Sigma.Transpose();
            Matrix_Sigma_Inverse = Matrix_Sigma.Inverse();

            return covariance_matrix;
        }
    }
}
