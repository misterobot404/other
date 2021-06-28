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
    public partial class ПоставкиОружия : Form
    {
        public ПоставкиОружия()
        {
            InitializeComponent();
        }

        private void Рецепт_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'табаровDataSet.ПоставкиОружия' table. You can move, or remove it, as needed.
            this.поставкиОружияTableAdapter.Fill(this.табаровDataSet.ПоставкиОружия);
            // TODO: This line of code loads data into the 'поврDataSet.Рецепт' table. You can move, or remove it, as needed.
           

        }


        private void поставкиОружияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставкиОружияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.табаровDataSet);

        }
    }
}
