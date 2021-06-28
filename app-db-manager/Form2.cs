using System.Windows.Forms;

namespace DBApp
{
    public partial class Form2 : Form
    {
        public Form2(string login)
        {
            InitializeComponent();

            if (login == "Военный")
            {
                button1.Visible = true;
                button5.Visible = true;
            }
            else if (login == "Поставщик")
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
            else if (login == "Менеджер")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new Участие().ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            new Продукты().ShowDialog();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            new ПоставкиОружия().ShowDialog();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            new Часть().ShowDialog();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            new Оружия().ShowDialog();
        }
    }
}
