using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw3
{
public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            richTextBox1.Text = (a + b).ToString();
        }
        catch (FormatException)
        {
            MessageBox.Show(
                "Ошибка формата ввода. Пожалуйста, введите корректные числа.", 
                "Ошибка", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
        catch (OverflowException)
        {
            MessageBox.Show(
                "Введенное число слишком большое или слишком маленькое.", 
                "Ошибка", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Произошла ошибка: {ex.Message}", 
                "Ошибка", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
    }
}
}
