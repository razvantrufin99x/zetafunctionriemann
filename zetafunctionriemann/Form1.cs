using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zetafunctionriemann
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double zetafunction(double x, double N)
        {
            double sumazetafunction = 0;
            double val = 0;
            for (int i = 1; i < N; i++)
            {
                 val = Math.Pow(i, -x);
                sumazetafunction += val;
                //zfvals.Add(val);

               //textBox1.Text += i.ToString()+"                \r\t";
               //textBox1.Text += val.ToString() + "\r\n";
            }
            return sumazetafunction;
        }
        //public List<double> zfvals = new List<double>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = zetafunction(1,100).ToString();
        }
    }
}
