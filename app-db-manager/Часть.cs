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
    public partial class Часть : Form
    {
        public Часть()
        {
            InitializeComponent();
        }

        private void Продажи_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'табаровDataSet.Часть' table. You can move, or remove it, as needed.
            this.частьTableAdapter.Fill(this.табаровDataSet.Часть);
            // TODO: This line of code loads data into the 'поврDataSet.Продажа' table. You can move, or remove it, as needed.
           

        }

        private void частьBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.частьBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.табаровDataSet);

        }
    }
}
