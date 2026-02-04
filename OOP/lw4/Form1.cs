using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                if (checkBox1.Checked) textBox3.Text = Math.Round(num1 / num2, 2).ToString();
                else textBox3.Text = (num1 / num2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                if (checkBox1.Checked) textBox3.Text = Math.Round(num1 / num2, 2).ToString();
                else textBox3.Text = (num1 / num2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                if (checkBox1.Checked) textBox3.Text = Math.Round(num1 / num2, 2).ToString();
                else textBox3.Text = (num1 / num2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                if (checkBox1.Checked) textBox3.Text = Math.Round(num1 / num2, 2).ToString();
                else textBox3.Text = (num1 / num2).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex}");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.BackColor = Color.DimGray;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }
    }
}
