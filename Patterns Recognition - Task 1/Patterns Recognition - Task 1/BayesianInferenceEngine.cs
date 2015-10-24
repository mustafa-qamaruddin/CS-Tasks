using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Recognition___Task_1
{
    class BayesianInferenceEngine
    {
        public NormalDistribution composition_object_normal_distribution;

        double likelihood, prior, scale_factor, posterior;

        public BayesianInferenceEngine()
        {
        }

        public BayesianInferenceEngine(double meu, double sigma)
        {
            composition_object_normal_distribution = new NormalDistribution(meu, sigma);
        }

        public double calculate_likelihood(double x)
        {
            likelihood = composition_object_normal_distribution.pdf(x);
            return likelihood;
        }

        public double calculate_prior()
        {
            return prior;
        }

        public double calculate_posterior()
        {
            return posterior;
        }

        public int classify(ClassRegion[] classes, double x){
            double maximum_likelihood = double.NegativeInfinity;
            int class_index = -1;
            for (int i = 0; i < classes.Length; i++)
            {
                if (classes[i] == null)
                    continue;
                composition_object_normal_distribution = new NormalDistribution(classes[i].get_averaged_meu(), classes[i].get_averaged_sigma());
                double likelihood = composition_object_normal_distribution.pdf(x);
                double prior = 1 / classes.Length;
                if (likelihood * prior > maximum_likelihood)
                    class_index = i;
            }
            return class_index;
        }
        
    }
}
