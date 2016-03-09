using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void coz_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 20;

            dataGridView1.Columns[0].HeaderText = "a";
            dataGridView1.Columns[1].HeaderText = "b";
            dataGridView1.Columns[2].HeaderText = "c";
            dataGridView1.Columns[3].HeaderText = "d";
            dataGridView1.Columns[4].HeaderText = "e";
            dataGridView1.Columns[5].HeaderText = "f";
            dataGridView1.Columns[6].HeaderText = "g";
            dataGridView1.Columns[7].HeaderText = "h";
            dataGridView1.Columns[8].HeaderText = "i";
            dataGridView1.Columns[9].HeaderText = "j";
         
            double[] a = { 1, -5, -34, -56, 192 };
            int n = a.GetLength(0);
            double[] x = new double[n-1]; 
            for (int i = 0; i < n-1; i++)
            {
                x[i] = Newton(0, a);
                a = Reduce(a, x[i]);
            }

            /* 
            int n = Convert.ToInt32(textBox1.Text);
            double[] a = new double[n + 1];
            Random r = new Random();
            for (int i = 0; i < n + 1; i++)
            {
                a[i] = Math.Truncate((r.NextDouble() - 0.5) * 10);
            } 
            */

        }
        /* Indirgeme */
        private double[] Reduce(double[] a,double r)
        {
            int n = a.GetLength(0);
            double[] b = new double[n - 1];
            b[n - 2] = a[n - 1];
            for (int i = n-3; i >= 0; i--)
            {
                b[i] = a[i + 1] + r *b[i + 1];
            }

            return b;
        }
        /* Kok Bulma */
        private double Newton(double x0, double[] a)
        {
            double eps = 1e-3;
            double x1 = x0;

            do
            {
                x0 = x1;
                x1 = (x0 - P(x0,a)) / Pt(x0,a);

            } while (Math.Abs(x1-x0) > eps);

            return x1;
        }
        /* Polinom Degeri */
        private double P(double x,double[] a)
        {
            int n = a.GetLength(0);
            double t = 0.0;
            for (int i = 0; i < n; i++)
            {
                t += a[i] * Math.Pow(x, i);
            }
            return t;
        }
        /* Polinom Turev Degeri */
        private double Pt(double x, double[] a)
        {
            int n = a.GetLength(0);
            double t = 0.0;
            for (int i = 1; i < n; i++)
            {
                t += a[i] * i * Math.Pow(x, i-1);
            }
            return t;
        }

    }
}
