using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regula_False_Yöntemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double f(double x)
        {
            return 10*Math.Exp(-x/2.0)*(Math.Cos(6.0*x)+Math.Sin(8.0*x));
        }
        private void coz_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(baslangicDeger1.Text);
            double b = Convert.ToDouble(baslangicDeger2.Text);
            double eps = 1e-6;
            
            int i = 0;

            data.ColumnCount = 8;
            data.RowCount = 100;

            data.Columns[0].HeaderText = "N";
            data.Columns[1].HeaderText = "a";
            data.Columns[2].HeaderText = "b";
            data.Columns[3].HeaderText = "F(a)";
            data.Columns[4].HeaderText = "F(b)"; 
            data.Columns[5].HeaderText = "c";
            data.Columns[6].HeaderText = "F(c)";
            data.Columns[7].HeaderText = "+/-";
            double c;
            do
            {
                c = (a * f(b) - b * f(a)) / (f(b) - f(a));

                data[0, i].Value = i;
                data[1, i].Value = a;
                data[2, i].Value = b;
                data[3, i].Value = f(a).ToString("N7");
                data[4, i].Value = f(b).ToString("N7");
                data[5, i].Value = c;
                data[6, i].Value = f(c).ToString("N7");
                data[7, i].Value = f(c) >= 0 ? "+" : "-";

                if(f(a) * f(c) > 0)
                {
                    a = c;
                }
                else
                {
                    b = c;
                }
                i++;
            } while (Math.Abs(f(c)) > eps);









        }
    }
}
