using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public double[] meus_vector;
        public double[] sigma_vector;
        public double[,] covariance_matrix;

        public double[] transpose_meus_vector;
        public double[,] inverse_covariance_matrix;
        public double[,] transpose_covariance_matrix;

        double priori;

        public Generic_State_Of_Nature(int _num_of_features, int _num_training_samples, int _num_of_test_samples, double _priori)
        {
            num_of_features = _num_of_features;

            num_of_training_samples = _num_training_samples;
            num_of_test_samples = _num_of_test_samples;

            priori = _priori;

            training_samples = new Sample[num_of_training_samples];
            test_samples = new Sample[_num_of_test_samples];
        }

        public double[] calculate_meus_vector_from_samples()
        {
            meus_vector = new double[num_of_features];
            double[] sums = new double[num_of_features];
            for (int j = 0; j < num_of_features; j++)
            {
                sums[j] = 0;
            }
            for (int i = 0; i < training_samples.Length; i++)
            {
                for (int j = 0; j < num_of_features; j++)
                {
                    sums[j] += training_samples[i].features_values[j];
                }
            }
            for (int j = 0; j < num_of_features; j++)
            {
                meus_vector[j] = sums[j] / num_of_training_samples;
            }
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
                    covariance_matrix[i, j] = 0;
                    for (int k = 0; k < num_of_training_samples; k++)
                    {
                        covariance_matrix[i, j] += (training_samples[k].features_values[i] - meus_vector[i]) * (training_samples[k].features_values[j] - meus_vector[j]);
                    }
                    covariance_matrix[i, j] = covariance_matrix[i, j] / num_of_training_samples;
                }
            }
            return covariance_matrix;
        }
    }
}
