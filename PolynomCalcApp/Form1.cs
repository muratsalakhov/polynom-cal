using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolynomCalcApp
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataCheck.polynomCheck(textP.Text) && DataCheck.argumentCheck(textX.Text))
            {
                resultP.Text = "" + CalcModule.polynomCalc(textP.Text, textX.Text);
                if (DataCheck.polynomCheck(textQ.Text) && DataCheck.argumentCheck(textY.Text))
                {
                    resultQ.Text = "" + CalcModule.polynomCalc(textQ.Text, textY.Text);
                    resultPQ.Text = "" + CalcModule.expressionCalc(textP.Text, textX.Text, textQ.Text, textY.Text);
                }
                else
                {
                    MessageBox.Show("Строка Q не является полиномом или аргумент Y неприемлим");
                }
            }
            else {
                MessageBox.Show("Строка P не является полиномом или аргумент X неприемлим");
            }
            
        }
    }
}
