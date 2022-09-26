using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_window
{
    class round : figure
    {
        double[] lengths;
        public round(double radius)
        {
            lengths.Append(radius);
        }

        public round(string v)
        {
            var some = Convert.ToDouble(v);
            lengths = new double[1];
            lengths[0]=some;
        }

        public override double count_area()
        {
            return lengths[0] * (Math.PI * Math.PI);
        }
    }
}
