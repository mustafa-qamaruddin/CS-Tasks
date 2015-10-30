using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Patterns_Recognition___Task_1
{
    class Unique_Random_Color
    {
        const int max_color = 255;
        const int min_color = 0;
        List<Color> colors_taken_for_classes;

        public Unique_Random_Color()
        {
            colors_taken_for_classes = new List<Color>();
        }

        public Color get_unique_random_color()
        {
            Random r = new Random();
            Color new_color = Color.FromArgb(r.Next(min_color, max_color), r.Next(min_color, max_color), r.Next(min_color, max_color));
            while (linear_array_find(new_color))
            {
                new_color = Color.FromArgb(r.Next(min_color, max_color), r.Next(min_color, max_color), r.Next(min_color, max_color));
            }
            colors_taken_for_classes.Add(new_color);
            return new_color;
        }

        public bool linear_array_find(Color x)
        {
            for (int i = 0; i < colors_taken_for_classes.Count; i++)
            {
                if (colors_taken_for_classes[i] == x)
                    return true;
            }
            return false;
        }
    }
}
