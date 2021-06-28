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
    public partial class Участие : Form
    {
        public Участие()
        {
            InitializeComponent();
        }

        private void Блюда_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'табаровDataSet.Участие' table. You can move, or remove it, as needed.
            this.участиеTableAdapter.Fill(this.табаровDataSet.Участие);
            // TODO: This line of code loads data into the 'поврDataSet.Блюда' table. You can move, or remove it, as needed.


        }

        private void участиеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.участиеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.табаровDataSet);

        }
    }
}
