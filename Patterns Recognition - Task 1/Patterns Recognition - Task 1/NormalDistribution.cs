using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace Patterns_Recognition___Task_1
{
    class NormalDistribution
    {
        double meu;
        double sigma;
        double sigma_squared;

        double factor; // 1 / (sigma * sqrt(2 * PI))
        double exponents_denominator; // 2 * sigma ^ 2

        const int span = 4;

        public NormalDistribution(double _meu, double _sigma)
        {
            meu = _meu;
            sigma = _sigma;
            sigma_squared = Math.Pow(sigma, 2);
            factor = 1 / (sigma * Math.Sqrt(2 * Math.PI));
            exponents_denominator = 2 * sigma_squared;
        }

        public double pdf(double x){
            double nominator = Math.Pow(x-meu,2);
            double exponent = -1 * nominator / exponents_denominator;
            double ret = Math.Round(factor * Math.Pow(Math.E, exponent), 4);
            ret = factor * Math.Pow(Math.E, exponent);
            Debug.Assert(ret >= 0);
            Debug.Assert(ret <= 1);
            return ret;
        }

        public int uniform_random_generator(int from, int to)
        {
            int int_seed = new System.DateTime().Millisecond;
            Random r = new Random(int_seed);
            return r.Next(from, to);
        }

        public List<KeyValuePair<double, double>> fill_data()
        {
            List<KeyValuePair<double,double>> data = new List<KeyValuePair<double,double>>();
            for (double i = meu - span; i <= meu + span; i += 0.1)
            {
                double pdf_i = pdf(i);
                data.Add(new KeyValuePair<double, double>(i, pdf_i));
            }
            return data;
        }

        public void fill_plot(Chart obj_chart)
        {
            List<KeyValuePair<double, double>> data = fill_data();
            for (int i = 0; i < data.Count; i++)
            {
                obj_chart.Series[0].Points.AddXY(data[i].Key, data[i].Value);
            }
            return;
        }
    }
}
