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
    class BayesianInferenceEngine
    {
        public NormalDistribution composition_object_normal_distribution;

        public BayesianInferenceEngine()
        {
            composition_object_normal_distribution = new NormalDistribution();
        }

        // single feature
        public int classify(StateOfNature[] classes, double x){
            if (classes == null)
                return -1;
            double meu, sigma;
            composition_object_normal_distribution = new NormalDistribution();
            double maximum_likelihood = double.NegativeInfinity;
            int class_index = -1;
            for (int i = 0; i < classes.Length; i++)
            {
                if (classes[i] == null)
                    continue;
                meu = classes[i].get_averaged_meu();
                sigma = classes[i].get_averaged_sigma();
                double likelihood = composition_object_normal_distribution.my_normal_function(x , meu, sigma);
                double prior = classes[i].prior;
                if (likelihood * prior > maximum_likelihood)
                {
                    class_index = i;
                    maximum_likelihood = likelihood * prior;
                }
            }
            return class_index;
        }

        // multi feature
        public int classify(List<StateOfNature> classes, int[] x, double[,] loss_function_lambda)
        {
            if (classes == null || loss_function_lambda == null || x == null)
                return -1;
            double minimum_conditional_risk = double.PositiveInfinity;
            double conditional_risk, posteriori;
            int class_index = -1;
            for (int i = 0; i < classes.Count+1; i++) // loop all actions = # of classes + 1 @todo remove hard coded actions
            {
                conditional_risk = 0;
                for (int j = 0; j < classes.Count; j++)
                {
                    posteriori = calculate_posteriori(classes[j], x);
                    conditional_risk += loss_function_lambda[i, j] * posteriori;
                }
                if (conditional_risk < minimum_conditional_risk)
                {
                    class_index = i;
                    minimum_conditional_risk = conditional_risk;
                }
            }
            return class_index;
        }

        public bool is_classification_correct(StateOfNature[] states_of_natures, int i, int j)
        {
            return false;
        }

        public double calculate_posteriori(StateOfNature state_of_nature, int[] observed_features_x_vector)
        {
            double posteriori = 1;
            double[] meu_vector = state_of_nature.get_meus_vector();
            double[] sigma_vector = state_of_nature.get_sigmas_vector();
            for (int i = 0; i < observed_features_x_vector.Length; i++)
            {
                double likelihood = composition_object_normal_distribution.my_normal_function(observed_features_x_vector[i], meu_vector[i], sigma_vector[i]);
                double prior = state_of_nature.prior;
                posteriori *= likelihood * prior; // disjoint probability of independent features (random variables)
            }
            return posteriori;
        }

        public double calculate_discrimenet_function(Generic_State_Of_Nature object_state_of_nature, double[,] vector_observed_features_values)
        {
            double gi_x = 0;
            Matrix<double> X = Matrix.Build.DenseOfArray(vector_observed_features_values);
            /**
             * todo move this code to training step
             **/
            Matrix<double> Wi = (-1 / 2) * object_state_of_nature.Matrix_Sigma_Inverse;
            Matrix<double> wi = object_state_of_nature.Matrix_Sigma_Inverse * object_state_of_nature.Vector_Meu;
            Matrix<double> omegai_0 = (-1 / 2) * object_state_of_nature.Vector_Meu_Transpose * object_state_of_nature.Matrix_Sigma_Inverse * object_state_of_nature.Vector_Meu - (1 / 2) * Math.Log(object_state_of_nature.Matrix_Sigma.Determinant(),Math.E) + Math.Log(object_state_of_nature.priori, Math.E);
            Matrix<double> ret = X.Transpose() * Wi * X + wi.Transpose() * X + omegai_0;
            gi_x = ret.Determinant();
            return gi_x;
        }

        public int classify_using_discriminent_function(Generic_State_Of_Nature[] array_generic_state_nature, double[,] vector_observed_features_values)
        {
            double maximum_discriminent_value = double.PositiveInfinity;
            int class_index = -1;
            for (int i = 0; i < array_generic_state_nature.Length; i++)
            {
                double discriminent_value = calculate_discrimenet_function(array_generic_state_nature[i], vector_observed_features_values);
                if (discriminent_value > maximum_discriminent_value)
                {
                    maximum_discriminent_value = discriminent_value;
                    class_index = i;
                }
            }
            return class_index;
        }
    }
}
