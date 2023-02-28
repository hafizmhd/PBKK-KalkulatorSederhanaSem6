namespace KalkulatorSederhana
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool isOperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || isOperation)
            {
                textBox.Clear();
            }

            isOperation = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + btn.Text;

            }
            else
                textBox.Text = textBox.Text + btn.Text;
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;

            operation = btnOperator.Text;
            value = Double.Parse(textBox.Text);
            isOperation = true;

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation){
                case "+":
                    textBox.Text = (value + Double.Parse(textBox.Text)).ToString();
                break;

                case "-":
                    textBox.Text = (value - Double.Parse(textBox.Text)).ToString();
                break;

                case "*":
                    textBox.Text = (value * Double.Parse(textBox.Text)).ToString();
                break;

                case "/":
                    textBox.Text = (value / Double.Parse(textBox.Text)).ToString();
                break;

                default:
                    break;
            }

            value = Double.Parse(textBox.Text);
            isOperation = true;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            value = 0;
        }
    }
}