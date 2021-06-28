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
    public partial class Продукты : Form
    {
        public Продукты()
        {
            InitializeComponent();
        }

        private void Продукты_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'табаровDataSet.Продукты' table. You can move, or remove it, as needed.
            this.продуктыTableAdapter.Fill(this.табаровDataSet.Продукты);

        }

        private void продуктыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.продуктыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.табаровDataSet);

        }
    }
}
