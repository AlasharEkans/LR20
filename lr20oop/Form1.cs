using System;
using System.Windows.Forms;

namespace lr20oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);

                if (a == 0)
                {
                    if (b == 0)
                    {
                        labelResult.Text = "Рівняння має безліч рішень";
                    }
                    else
                    {
                        labelResult.Text = "Рівняння не має рішень";
                    }
                }
                else
                {
                    double x = -b / a;
                    labelResult.Text = $"Корінь рівняння: x = {x}";
                }
            }
            catch (FormatException)
            {
                labelResult.Text = "Помилка: введіть правильні числові значення для a та b.";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Невідома помилка: {ex.Message}";
            }
        }
    }
}
