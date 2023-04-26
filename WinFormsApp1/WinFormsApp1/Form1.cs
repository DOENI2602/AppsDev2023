using System.Transactions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Input1
        {
            set
            {
                Input1_textBox.Text = value;
            }
        }
        public string input
        {
            set
            {
                Inputtwo_textBox.Text = value;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1Control1.Show();
            panel1Control1.BringToFront();
            panel2Control1.Hide();
        }

        private void panel2Control1_Load(object sender, EventArgs e)
        {

        }

        private void panel2Control1_Load_1(object sender, EventArgs e)
        {

        }

        private void panelButton2_Click(object sender, EventArgs e)
        {
            panel2Control1.Show();
            panel2Control1.BringToFront();
            panel1Control1.Hide();
        }

        private void panel1Control1_Load(object sender, EventArgs e)
        {

        }
    }
}