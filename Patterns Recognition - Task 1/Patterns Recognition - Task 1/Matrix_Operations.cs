using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Recognition___Task_1
{
    class Matrix_Operations
    {
        public double[,] transpose_of_matrix(double[,] input_matrix, int rows, int cols)
        {
            double[,] ret = new double[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    ret[j, i] = input_matrix[i, j];
                }
            }
            return ret;
        }

        public double[,] inverse_of_matrix(double[,] input_matrix, int rows, int cols)
        {
            double[,] ret = new double[rows, cols];
            return ret;
        }

        public double dot_product(double[,] a, double[,] b, int rows_a, int cols_a, int rows_b, int cols_b)
        {
            double ret = 0;
            return ret;
        }
    }
}
