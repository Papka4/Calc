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

            textBox1.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation = 2;

            textBox1.Text = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double R = 0;

            if (Operation == 1) { R = a - b; }
            if (Operation == 2) { R = a + b; }

            textBox1.Text = R.ToString();
        }
    }
}
