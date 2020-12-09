using System;
using System.Windows.Forms;

namespace bintree
{
    public partial class Form1 : Form
    {
        private BinaryTree tree;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Convert.ToInt32(numericUpDown1.Value));
        }

        private void ButtonCreateTree_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                return;
            }

            numericUpDown1.Enabled = false;
            buttonAddItem.Enabled = false;
            buttonCreateTree.Enabled = false;
            textBox1.Enabled = true;
            numericUpDown2.Enabled = true;
            buttonFind.Enabled = true;

            textBox1.Text = "Построение дерева..." + Environment.NewLine;

            tree = new BinaryTree();
            foreach (int item in listBox1.Items)
            {
                tree.Insert(item);
            }

            Print(tree);
            textBox1.Text += "Количество элементов в дереве-> " + tree.NodeAmount() + Environment.NewLine;
            textBox1.Text += "Минимальный элемент дерева-> " + tree.MinEl() + Environment.NewLine;
            textBox1.Text += "Максимальный элемент дерева-> " + tree.MaxEl() + Environment.NewLine;
            textBox1.Text += "Высота дерева-> " + tree.Height() + Environment.NewLine;
            textBox1.Text += "Количество листьев-> " + tree.ListAmount() + Environment.NewLine;
            textBox1.Text += "Прямой обход дерева:" + Environment.NewLine;
            TreeTraversalAndPrint(tree);
            textBox1.Text += "Обратный обход дерева:" + Environment.NewLine;
            TreeTraversalAndPrint2(tree);
            textBox1.Text += "Симетричный обход дерева:" + Environment.NewLine;
            TreeTraversalAndPrint3(tree);

        }

        private void Print(BinaryTree node)
        {
            if (node != null)
            {
                if (node.Parent == null)
                {
                    textBox1.Text += "Корень: " + node.Data + Environment.NewLine;
                }
                else
                {
                    if (node.Parent.Left == node)
                    {
                        textBox1.Text += "Левый узел для " + node.Parent.Data + " -- > " + node.Data + Environment.NewLine;
                    }

                    if (node.Parent.Right == node)
                    {
                        textBox1.Text += "Правый узел для " + node.Parent.Data + " -- > " + node.Data + Environment.NewLine;
                    }
                }
                if (node.Left != null)
                {
                    Print(node.Left);
                }
                if (node.Right != null)
                {
                    Print(node.Right);
                }
            }
        }
        private void TreeTraversalAndPrint(BinaryTree node)
        {
            if (node == null) return;

            textBox1.Text += node.Data + Environment.NewLine;

            TreeTraversalAndPrint(node.Left);
            TreeTraversalAndPrint(node.Right);
        }
        private void TreeTraversalAndPrint2(BinaryTree node)
        {
            if (node == null) return;

            TreeTraversalAndPrint2(node.Left);
            TreeTraversalAndPrint2(node.Right);

            textBox1.Text += node.Data + Environment.NewLine;
        }
        private void TreeTraversalAndPrint3(BinaryTree node)
        {
            if (node == null) return;

            TreeTraversalAndPrint3(node.Left);
            textBox1.Text += node.Data + Environment.NewLine;
            TreeTraversalAndPrint3(node.Right);
        }

        private void NumericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                listBox1.Items.Add(Convert.ToInt32(numericUpDown1.Value));
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            var res = tree.Find(Convert.ToInt32(numericUpDown2.Value));

            if (res == null)
            {
                textBox1.Text += "Элемент " + Convert.ToInt32(numericUpDown2.Value) + " не найден" + Environment.NewLine;
            }
            else
            {               
                textBox1.Text += "Элемент " + res.Data + " найден" + Environment.NewLine;
            }
        }
    }
}
