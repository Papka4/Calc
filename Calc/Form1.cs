namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Operation = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            Operation = 1;
            //пупупум
            textBox1.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation = 2;

            textBox1.Text = "+";
        }


        private void button4_Click(object sender, EventArgs e)
        {

            Operation = 3;

            textBox1.Text = "*";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Operation = 4;

            textBox1.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double к = 0;
                double a = Convert.ToDouble(textBox2.Text);
                double b = Convert.ToDouble(textBox3.Text);
                double R = 0;

                if (Operation == 1) { R = a - b; }
                if (Operation == 2) { R = a + b; }
                if (Operation == 3) { R = a * b; }
                if (Operation == 4)
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("На ноль делить нельзя!");
                    }
                    R = a / b;
                }

                textBox1.Text = R.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите правильные значения.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка деления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
