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
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowCount = 20;
            dataGridView1.Columns[0].HeaderText = "i";
            dataGridView1.Columns[1].HeaderText = "xi";
            dataGridView1.Columns[2].HeaderText = "fxi";
            dataGridView1.Columns[3].HeaderText = "f'xi";
            dataGridView1.Columns[4].HeaderText = "xi+1";
            dataGridView1.Columns[5].HeaderText = "Dx";

            double x0 = Convert.ToDouble(textBox1.Text);
            double x1;
            double eps = 1e-6;
            double Dx;
            int i = 0;  

            do
            {
                x1 = x0 - f(x0) / df(x0);
                Dx = Math.Abs(x1 - x0);

                dataGridView1[0, i].Value = i;
                dataGridView1[1, i].Value = x0;
                dataGridView1[2, i].Value = f(x0);
                dataGridView1[3, i].Value = df(x0);
                dataGridView1[4, i].Value = x1;
                dataGridView1[5, i].Value = Dx;
                i++;
                x0 = x1;

            } while(Dx > eps);
        }
        private double f(double x)
        {
            return x * Math.Exp(-x) + Math.Pow(x, 3.0) + 1;
        }
        private double df(double x)
        {
            return Math.Exp(-x) - x * Math.Exp(-x) + 3 * Math.Pow(x, 2.0);
        }
    }
}
