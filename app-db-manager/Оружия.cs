using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    public partial class Оружия : Form
    {
        public Оружия()
        {
            InitializeComponent();
        }

        private void Покупки_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'табаровDataSet.Оружия' table. You can move, or remove it, as needed.
            this.оружияTableAdapter.Fill(this.табаровDataSet.Оружия);
            // TODO: This line of code loads data into the 'поврDataSet.Покупка' table. You can move, or remove it, as needed.


        }


        private void оружияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оружияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.табаровDataSet);

        }
    }
}
