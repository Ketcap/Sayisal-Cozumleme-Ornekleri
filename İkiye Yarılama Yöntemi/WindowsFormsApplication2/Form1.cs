using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        double f(double x)
        {
            return x * Math.Exp(-x) + Math.Pow(x, 3.0) + 1.0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Double baslangic = Convert.ToDouble(aTextbox.Text);
            Double bitis = Convert.ToDouble(bTextBox.Text);
            Double eps = 1e-6;
            int i = 0;
            double m;

            if(f(baslangic) * f(bitis) > 0)
            {
                sonuc.Text = "Verilen Aralıkta Kök Yoktur";
            }
            else
            {
                dataGridView1.ColumnCount = 6;
                dataGridView1.RowCount = 21;
                dataGridView1.Columns[0].HeaderText = "i";
                dataGridView1.Columns[1].HeaderText = "Baslangic";
                dataGridView1.Columns[2].HeaderText = "Bitis";
                dataGridView1.Columns[3].HeaderText = "m";
                dataGridView1.Columns[4].HeaderText = "f(a) * f(m)";
                dataGridView1.Columns[5].HeaderText = "(b - a) / 2 |";

                do
                {
                    m = (baslangic + bitis) / 2;

                    dataGridView1[0, i].Value = i;
                    dataGridView1[1, i].Value = baslangic;
                    dataGridView1[2, i].Value = bitis;
                    dataGridView1[3, i].Value = m;
                    dataGridView1[4, i].Value = f(baslangic)*f(m);
                    dataGridView1[5, i].Value = (bitis-baslangic)/2;

                    if (f(baslangic) * f(m) < 0)
                    {
                        bitis = m;
                    }
                    else
                    {
                        baslangic = m;
                    }
                    i++;

                } while (Math.Abs((bitis - baslangic) / 2) > eps);

                sonuc.Text = (i-1)+". iterasyonda yakınsama sağlandı.";
            }


        }
    }
}
