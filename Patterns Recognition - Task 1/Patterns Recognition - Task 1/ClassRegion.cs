using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns_Recognition___Task_1
{
    class ClassRegion
    {
        public int x1, y1, x2, y2, width, height;
        public double meu, sigma;
        public double meu_red, meu_green, meu_blue;
        public double sigma_red, sigma_green, sigma_blue;

        public double get_averaged_meu(){
            return (meu_red + meu_green + meu_blue) / 3;
        }

        public double get_averaged_sigma()
        {
            return (sigma_red + sigma_green + sigma_blue) / 3;
        }
    }
}
