using System;
using System.Windows.Forms;

namespace bintree
{
    public partial class Form1 : Form
    {
        private NodeList nodeList;
        Help help;

        public Form1()
        {
            InitializeComponent();
            nodeList = new NodeList();
            resetLists();
        }

        private void resetLists()
        {
            listBox_Nodes.Items.Clear();
            listBox_Nodes2.Items.Clear();
            listBox_NextNodes.Items.Clear();
            listBox_NextNodesForCerrentNode.Items.Clear();

            // Заполнение "Добавление узла" и "Добавление связи между узлами"
            foreach (var node in nodeList._nodeList)
            {
                listBox_Nodes.Items.Add(node._data);

                listBox_Nodes2.Items.Add(node._data);
            }

            // Установка "Текущий узел"
            edittext_currentNode.Text = nodeList._currentNode._data;
            // Заполнение "Переход между узлами - Ссылки на другие узлы"
            foreach (var nextNode in nodeList._currentNode._nextNodes)
            {
                listBox_NextNodesForCerrentNode.Items.Add(nextNode._data);  
            }
        }

        // добавление узла
        private void Button2_Click(object sender, EventArgs e)
        {
            string data = dataNode.Text;
            var nodeRefers = listBox_Nodes.SelectedItem;

            // Проверка существования узла
            foreach (var node in nodeList._nodeList)
            {
                if (node._data == data)
                {
                    MessageBox.Show("Такой узел уже существует!");
                    return;
                }
            }

            // Проверка на заполнение формы
            if (nodeRefers == null || data == "")
            {
                MessageBox.Show("Заполнены не все поля");
                return;
            }

            nodeList.addNode(dataNode.Text);
            nodeList.addLink(nodeRefers.ToString(), data);

            resetLists();
        }

        // добавление связи
        private void ListBox_Nodes2_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox_NextNodes.Items.Clear();

            foreach (var node in nodeList._nodeList)
            {
                listBox_NextNodes.Items.Add(node._data);
            }
            listBox_NextNodes.Items.Remove(listBox_Nodes2.SelectedItem);

            Node findNode = nodeList._nodeList.Find(x => x._data == listBox_Nodes2.SelectedItem);
            if (findNode != null)
            {
                foreach (var nextNode in findNode._nextNodes)
                {
                    listBox_NextNodes.Items.Remove(nextNode._data);
                }
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            var node = listBox_Nodes2.SelectedItem;
            var nodeRefers = listBox_NextNodes.SelectedItem;
            if (nodeRefers == null || node == null)
            {
                MessageBox.Show("Выберите узлы из обоих списков!");
                return;
            }
            nodeList.addLink(node.ToString(), nodeRefers.ToString());
            resetLists();
        }

        // переход на следующий узел
        private void Button_NextNode_Click(object sender, EventArgs e)
        {
            var nodeRefers = listBox_NextNodesForCerrentNode.SelectedItem;
            // Проверка на заполнение формы
            if (nodeRefers == null)
            {
                MessageBox.Show("Не выбран узел для перехода");
                return;
            }
            nodeList.setCurrentNode(nodeRefers.ToString());
            resetLists();
        }


        // создание окно терии
        private void Button1_Click(object sender, EventArgs e)
        {
            if (help == null || help.IsDisposed)
            {
                help = new Help();
                help.Show();
            }
            else
            {
                help.WindowState = FormWindowState.Normal;
                help.Activate();
            }
        }

        private void Button_back_Click(object sender, EventArgs e)
        {
            nodeList.setCurrentNode("Root");
            resetLists();
        }

        private void Button_deleteNode_Click(object sender, EventArgs e)
        {
            if (nodeList._currentNode._data != "Root")
            {
                Node temp = nodeList._currentNode;
                nodeList.setCurrentNode("Root");

                foreach (var node in nodeList._nodeList)
                {
                    Node findNode = node._nextNodes.Find(x => x._data == temp._data);
                    nodeList._currentNode._nextNodes.Remove(findNode);
                }
                
                nodeList._nodeList.Remove(temp);
            }
            else
            {
                MessageBox.Show("Корень нельзя удалить");
                return;
            }
            resetLists();
        }

        private void Button_deleteLink_Click(object sender, EventArgs e)
        {

            if (listBox_NextNodesForCerrentNode.SelectedItem != null)
            {
                Node findNode = nodeList._nodeList.Find(x => x._data == listBox_NextNodesForCerrentNode.SelectedItem);
                nodeList._currentNode._nextNodes.Remove(findNode);

                resetLists();
            }
            else
            {
                MessageBox.Show("Выберите ссылку");
                return;
            }
        }
    }
}
