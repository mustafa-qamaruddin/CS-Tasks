using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Patterns_Recognition___Task_1
{
    class Mueller_Box_Normal_RGNR
    {
        double meu, sigma;

        public Mueller_Box_Normal_RGNR(double _meu, double _sigma)
        {
            meu = _meu;
            sigma = _sigma;
        }

        // output must be de-normalized using z = sigma * x + meu
        public double generate_standard_normal_random(){
            double ret;
            int seed = Guid.NewGuid().GetHashCode();
            Random rnd = new Random(seed);
            double r1 = rnd.NextDouble();
            double r2 = rnd.NextDouble();
            ret = Math.Sqrt(-2 * Math.Log(r1, Math.E)) * 0.5 * Math.Cos( 2 * Math.PI * r2);
            return ret;
        }

        public double generate_normal_random()
        {
            return sigma * generate_standard_normal_random() + meu;
        }
    }
}
