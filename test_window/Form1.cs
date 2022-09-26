using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void area_but_Click(object sender, EventArgs e)
        {
            var arr = data.Text.Split();
            if (arr.Length == 1)
            {
                var some = new round(arr[0]);
                var s = some.count_area();
                data.Text = Convert.ToString(s);
            }
            if(arr.Length == 3)
            {
                var some = new triangle(arr);
                data.Text = Convert.ToString(some.count_area());
            }
        }
    }
}
