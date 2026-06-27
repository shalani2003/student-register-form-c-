namespace example4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c=double.Parse(textBox1.Text);
            double d = (9 * c / 5) + 32;
                textBox2.Text= d.ToString();

        }
    }
}
