using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Recognition___Task_1
{
    class IrisDataset
    {
        public const int number_of_features = 4,
            number_of_categories = 3,
            number_of_samples_per_category = 50,
            number_of_training_samples_per_category = 20,
            number_of_test_samples_per_category = 30;
        public double[] training_set_setosa,
            training_set_versicolor,
            training_set_virginica,
            test_set_setosa,
            test_set_versicolor,
            test_set_virginica;

    }
}
