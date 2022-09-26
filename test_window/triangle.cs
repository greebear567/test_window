using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_window
{
    class triangle : figure
    {
        double[] lengths;
        bool square = false;
        public triangle(string[] arr)
        {
            lengths = new double[3];
            var j = 0;
            //double[] not_max_len = new double[2];
           // var k = 0;
           // var max_len = arr.Max();
            foreach (string i in arr)
            {
                lengths[j] = Convert.ToDouble(i);
                j++;
                //if (i != max_len)
                //{
                //    not_max_len[k] = i;
                //    k++;
                //}
            }
            Array.Sort(lengths);
            //if (Math.Pow(not_max_len[0],2)+Math.Pow(not_max_len[1],2)==Math.Pow(max_len, 2){
            if (Math.Pow(lengths[0], 2) + Math.Pow(lengths[1], 2) == Math.Pow(lengths[2], 2)) { 
                square = true;
            }
        }
        public override double count_area()
        {
            if (square)
            {
                return lengths[0] * lengths[1] * 0.5;
            }
            else
            {
                var p = (lengths[0] + lengths[1] + lengths[2]) * 0.5;
                return Math.Sqrt(p * (p - lengths[0]) * (p - lengths[1]) * (p - lengths[2]));
            }
        }
    }
}
