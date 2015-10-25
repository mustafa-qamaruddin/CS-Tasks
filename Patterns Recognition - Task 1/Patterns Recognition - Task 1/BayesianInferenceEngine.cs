using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Recognition___Task_1
{
    class BayesianInferenceEngine
    {
        public NormalDistribution composition_object_normal_distribution;

        public int classify(ClassRegion[] classes, double x){
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
                double likelihood = composition_object_normal_distribution.my_normal_function(x - meu / sigma, meu, sigma);
                double prior = classes[i].prior;
                if (likelihood * prior > maximum_likelihood)
                    class_index = i;
            }
            return class_index;
        }
        
    }
}
