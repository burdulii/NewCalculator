namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        double FirstNumber = 0;
        string choise = "";


        public Form1()
        {
            InitializeComponent();
        }




        private void no_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            Button no = (Button)sender;
            textBox1.Text += no.Text;

        }



        private void bClear_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNumber = 0;
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            switch (choise)
            {
                case "+":
                    string sum = (FirstNumber + Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = sum;
                    break;
                case "-":
                    textBox1.Text = (FirstNumber - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (FirstNumber * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (FirstNumber / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void op_click(object sender, EventArgs e)
        {
            Button no = (Button)sender;
            if (FirstNumber != 0)
            {
                bEquals.PerformClick();
                choise = no.Text;
            }
            else
            {
                choise = no.Text;
                FirstNumber = Double.Parse(textBox1.Text);
                textBox1.Text = "0";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
