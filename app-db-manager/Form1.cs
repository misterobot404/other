using System;
using System.Windows.Forms;

namespace DBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "123" && listBox1.Text != "")
            {
                Hide();
                Form2 sistema = new Form2(listBox1.Text);
                sistema.ShowDialog();
                Close();
            }
        }
    }
}
