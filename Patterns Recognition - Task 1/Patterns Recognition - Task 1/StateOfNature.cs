using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Patterns_Recognition___Task_1
{
    class StateOfNature
    {
        public int x1, y1, x2, y2, width, height;
        public double meu, sigma;
        public double meu_red, meu_green, meu_blue;
        public double sigma_red, sigma_green, sigma_blue;
        public double prior;
        public Color color;
        public double sum_reds = 0, sum_greens = 0, sum_blues = 0;
        public List<Color> samples;

        public StateOfNature()
        {
            reset();
        }

        public void reset()
        {
            sum_reds = 0;
            sum_greens = 0;
            sum_blues = 0;
            meu_red = 0;
            meu_green = 0;
            meu_blue = 0;
            sigma_red = 0;
            sigma_green = 0;
            sigma_blue = 0;
            prior = 1; // @todo priors = 1 / num of states of nature
            samples = new List<Color>();
        }

        public double get_averaged_meu()
        {
            meu = (meu_red + meu_green + meu_blue) / 3;
            return meu;
        }

        public double get_averaged_sigma()
        {
            sigma = (sigma_red + sigma_green + sigma_blue) / 3;
            return sigma;
        }

        public void calculate_meus_and_sigmas_from_samples()
        {
            calculate_sums_from_samples();
            calculate_meus_from_samples();
            calculate_sigmas_from_samples();
        }

        public void calculate_sums_from_samples()
        {
            if (samples.Count <= 0)
                return;
            for (int i = 0; i < samples.Count; i++)
            {
                sum_reds += samples[i].R;
                sum_greens += samples[i].G;
                sum_blues += samples[i].B;
            }
        }

        public void calculate_meus_from_samples()
        {
            if (samples.Count <= 0)
                return;
            meu_red = sum_reds / samples.Count;
            meu_green = sum_greens / samples.Count;
            meu_blue = sum_blues / samples.Count;
        }

        public void calculate_sigmas_from_samples()
        {
            if (samples.Count <= 0)
                return;
            for (int i = 0; i < samples.Count; i++)
            {
                sigma_red += Math.Pow(samples[i].R - meu_red, 2);
                sigma_green += Math.Pow(samples[i].G - meu_green, 2);
                sigma_blue += Math.Pow(samples[i].B - meu_blue, 2);
            }
            sigma_red = Math.Sqrt(sigma_red / (samples.Count /*- 1*/));
            sigma_green = Math.Sqrt(sigma_green / (samples.Count /*- 1*/));
            sigma_blue = Math.Sqrt(sigma_blue / (samples.Count /*- 1*/));
        }

        public double[] get_meus_vector()
        {
            return new double[] { meu_red, meu_green, meu_blue };
        }

        public double[] get_sigmas_vector()
        {
            return new double[] { sigma_red, sigma_green, sigma_blue };
        }
    }
}
