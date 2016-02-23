using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sekant_Yöntemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void coz_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(baslangicDeger1.Text);
            double x1 = Convert.ToDouble(baslangicDeger2.Text);
            int i = 0;
            double eps = 1e-6;
            double dx, x2 ;


            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = 10;

            dataGridView1.Columns[0].HeaderText = "n";
            dataGridView1.Columns[1].HeaderText = "x0";
            dataGridView1.Columns[2].HeaderText = "x1";
            dataGridView1.Columns[3].HeaderText = "F(x0)";
            dataGridView1.Columns[4].HeaderText = "F(x1)";
            dataGridView1.Columns[5].HeaderText = "x2";
            dataGridView1.Columns[6].HeaderText = "|Dx|";

            do
            {
                x2 = (x0 * f(x1) - x1 * f(x0)) / (f(x1) - f(x0));
                dx = Math.Abs(x1-x0);
                dataGridView1[0, i].Value = i;
                dataGridView1[1, i].Value = x0;
                dataGridView1[2, i].Value = x1;
                dataGridView1[3, i].Value = f(x0);
                dataGridView1[4, i].Value = f(x1);
                dataGridView1[5, i].Value = x2;
                dataGridView1[6, i].Value = dx;
                i++;
                x0 = x1;
                x1 = x2;


            } while (dx > eps);



        }
        private double f(double x)
        {
            return x * Math.Exp(-x) + Math.Pow(x, 3.0) + 1.0;
        }
    }
}
