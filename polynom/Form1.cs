using System;
using System.Windows.Forms;

namespace poly
{
    public partial class Form1 : Form
    {

        private double currentValue;
        private double X;
        private double n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            numericUpDown3.Visible = true;
            button1.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;

            currentValue = 0;
            X = Convert.ToInt32(numericUpDown1.Value);
            n = Convert.ToInt32(numericUpDown2.Value);

            textBox1.Text = "Программа запущена..." + Environment.NewLine +
                "Входные данные:" + Environment.NewLine +
                "X = " + X.ToString() + Environment.NewLine +
                "n = " + n.ToString() + Environment.NewLine +
                "Введите коэффицент перед X и нажмите Enter" + Environment.NewLine;
        }

        void HornerIter()
        {
            double m = Convert.ToInt32(numericUpDown3.Value);
            textBox1.Text = textBox1.Text + "Введен коэффицент перед X: " + m.ToString() + Environment.NewLine;
            currentValue = currentValue * X + m;
            n -= 1;

            if (n < 0)
            {
                label4.Visible = false;
                numericUpDown3.Visible = false;
                button1.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                textBox1.Text = textBox1.Text + "Результат: " + currentValue.ToString() + Environment.NewLine;
                MessageBox.Show("Результат вычисления по правилу Горнера: " + currentValue.ToString(), "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            textBox1.Text = textBox1.Text + "Введите коэффицент перед X и нажмите Enter" + Environment.NewLine;
        }

        private void NumericUpDown3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                HornerIter();
        }
    }
}
