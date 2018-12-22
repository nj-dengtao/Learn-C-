using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double MonthlySalary = Convert.ToDouble(textBox1.Text);
            double Threshold = 5000;
            double Taxable = MonthlySalary - Threshold;
            int Level = 0;
            double[] TaxRate = new double[7] { 0.03, 0.1, 0.2, 0.25, 0.3, 0.35, 0.45 };
            double[] Deduct = new double[7] { 0, 210, 1410, 2660, 4410, 7160, 15160 };
            if (Taxable <= 3000) Level = 0;
            if ((Taxable > 3000.01) && (Taxable <= 12000)) Level = 1;
            if ((Taxable > 12000.01) && (Taxable <= 25000)) Level = 2;
            if ((Taxable > 25000.01) && (Taxable <= 35000)) Level = 3;
            if ((Taxable > 35000.01) && (Taxable <= 55000)) Level = 4;
            if ((Taxable > 55000.01) && (Taxable <= 80000)) Level = 5;
            if ((Taxable > 80000.01)) Level = 6;

            if (Taxable < 0)
            {
                textBox2.Text = @"太扎心了，连交税资格都没有！";
            }
            else
            {
                textBox2.Text = Convert.ToString(Taxable * TaxRate[Level] - Deduct[Level]);
            }
        }
    }
}
