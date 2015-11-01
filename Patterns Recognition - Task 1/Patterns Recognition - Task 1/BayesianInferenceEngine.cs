using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
