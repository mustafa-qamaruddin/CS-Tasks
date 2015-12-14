using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Patterns_Recognition___Task_1
{
    class GenericDataSet
    {
        public int number_of_features,
            number_of_states_of_nature,
            number_of_samples_per_state_of_nature,
            number_of_training_samples_per_state_of_nature,
            number_of_test_samples_per_state_of_nature;

        public Generic_State_Of_Nature[] array_of_states_natures;

        public GenericDataSet(
            Stream _data_set_file_stream,
            char _file_delimeter,
            int _number_of_features,
            int _number_of_states_of_nature,
            int _number_of_samples_per_state_of_nature,
            int _number_of_training_samples_per_state_of_nature,
            int _number_of_test_samples_per_state_of_nature)
        {
            number_of_features = _number_of_features;
            number_of_states_of_nature = _number_of_states_of_nature;
            number_of_samples_per_state_of_nature = _number_of_samples_per_state_of_nature;
            number_of_training_samples_per_state_of_nature = _number_of_training_samples_per_state_of_nature;
            number_of_test_samples_per_state_of_nature = _number_of_test_samples_per_state_of_nature;

            double priori = 1 / number_of_states_of_nature; // @note: equal priori results in uniform decision boundary mainly determined by the posteriori

            array_of_states_natures = new Generic_State_Of_Nature[number_of_states_of_nature];
            for (int i = 0; i < number_of_states_of_nature; i++)
            {
                array_of_states_natures[i] = new Generic_State_Of_Nature(
                    number_of_features,
                    number_of_training_samples_per_state_of_nature,
                    number_of_test_samples_per_state_of_nature,
                    priori
                    );
            }

            read_data_set_from_file_stream(_data_set_file_stream, _file_delimeter);

            for (int i = 0; i < number_of_states_of_nature; i++)
            {
                array_of_states_natures[i].calculate_meus_vector_from_samples();
                array_of_states_natures[i].calculate_covariance_matrix_from_samples();
            }
        }

        public void read_data_set_from_file_stream(Stream _data_set_file_stream, char _file_delimeter)
        {
            _data_set_file_stream.Seek(0, SeekOrigin.Begin);
            StreamReader obj_sr = new StreamReader(_data_set_file_stream);
            
            string line = obj_sr.ReadLine();
            int current_index = 0;
            int category_index = 0;
            while (!string.IsNullOrEmpty(line))
            {
                string[] array_tokens = line.Split(_file_delimeter);
                if (string.IsNullOrEmpty(array_of_states_natures[category_index].label))
                    array_of_states_natures[category_index].label = array_tokens[number_of_features];
                double[,] features_values = new double[number_of_features,1];
                for (int i = 0; i < number_of_features; i++)
                {
                    features_values[i,0] = double.Parse(array_tokens[i]);
                }

                if (current_index < number_of_training_samples_per_state_of_nature)
                {
                    array_of_states_natures[category_index].training_samples[current_index] = new Sample(number_of_features, features_values);
                    current_index++;
                }
                else if (current_index < number_of_samples_per_state_of_nature)
                {
                    array_of_states_natures[category_index].test_samples[current_index - number_of_training_samples_per_state_of_nature] = new Sample(number_of_features, features_values);
                    current_index++;
                }

                if( current_index == number_of_samples_per_state_of_nature)
                {
                    current_index = 0;
                    category_index++;
                }

                line = obj_sr.ReadLine();
            }
        }
    }
}
