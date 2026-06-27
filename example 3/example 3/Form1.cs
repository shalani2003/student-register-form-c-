namespace example_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
                { "India", "srilanka" ,"japan" ,"china" });
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string address = textBox3.Text;
            string country = comboBox1.Text;

            string gender = "";
            if (radioButton1.Checked) gender = " male";
            else if (radioButton2.Checked) gender = "femail";
            else if (radioButton3.Checked) gender = "other";

            string langhuage = "";
            if (checkBox1.Checked) langhuage += "sinhala";
            if (checkBox2.Checked) langhuage += "tamil";
            if (checkBox3.Checked) langhuage += "english";
            if (checkBox4.Checked) langhuage += "hindi";

            MessageBox.Show("firstName :" + firstName + "\n" +
                "lastNme:" + lastName + "\n" +
                "address:" + address + "\n" +
                "gender: " + gender + "\n" +
                "languages" + langhuage + "\n" +
                "language" + country
                );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
