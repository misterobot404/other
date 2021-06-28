
namespace DBApp
{
    partial class Оружия
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Оружия));
            this.табаровDataSet = new DBApp.табаровDataSet();
            this.оружияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оружияTableAdapter = new DBApp.табаровDataSetTableAdapters.ОружияTableAdapter();
            this.tableAdapterManager = new DBApp.табаровDataSetTableAdapters.TableAdapterManager();
            this.оружияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.оружияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.оружияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.табаровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оружияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оружияBindingNavigator)).BeginInit();
            this.оружияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оружияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // табаровDataSet
            // 
            this.табаровDataSet.DataSetName = "табаровDataSet";
            this.табаровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оружияBindingSource
            // 
            this.оружияBindingSource.DataMember = "Оружия";
            this.оружияBindingSource.DataSource = this.табаровDataSet;
            // 
            // оружияTableAdapter
            // 
            this.оружияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DBApp.табаровDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВоенныеTableAdapter = null;
            this.tableAdapterManager.Воинские_званияTableAdapter = null;
            this.tableAdapterManager.ОружияTableAdapter = this.оружияTableAdapter;
            this.tableAdapterManager.ПоставкиОружияTableAdapter = null;
            this.tableAdapterManager.ПродуктыTableAdapter = null;
            this.tableAdapterManager.СлужбаTableAdapter = null;
            this.tableAdapterManager.УчастиеTableAdapter = null;
            this.tableAdapterManager.ЧастьTableAdapter = null;
            // 
            // оружияBindingNavigator
            // 
            this.оружияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оружияBindingNavigator.BindingSource = this.оружияBindingSource;
            this.оружияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оружияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оружияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.оружияBindingNavigatorSaveItem});
            this.оружияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.оружияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оружияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оружияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оружияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оружияBindingNavigator.Name = "оружияBindingNavigator";
            this.оружияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оружияBindingNavigator.Size = new System.Drawing.Size(271, 25);
            this.оружияBindingNavigator.TabIndex = 0;
            this.оружияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // оружияBindingNavigatorSaveItem
            // 
            this.оружияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оружияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оружияBindingNavigatorSaveItem.Image")));
            this.оружияBindingNavigatorSaveItem.Name = "оружияBindingNavigatorSaveItem";
            this.оружияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.оружияBindingNavigatorSaveItem.Text = "Save Data";
            this.оружияBindingNavigatorSaveItem.Click += new System.EventHandler(this.оружияBindingNavigatorSaveItem_Click);
            // 
            // оружияDataGridView
            // 
            this.оружияDataGridView.AutoGenerateColumns = false;
            this.оружияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.оружияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.оружияDataGridView.DataSource = this.оружияBindingSource;
            this.оружияDataGridView.Location = new System.Drawing.Point(0, 28);
            this.оружияDataGridView.Name = "оружияDataGridView";
            this.оружияDataGridView.Size = new System.Drawing.Size(259, 220);
            this.оружияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодТовара";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодТовара";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Оружия
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 249);
            this.Controls.Add(this.оружияDataGridView);
            this.Controls.Add(this.оружияBindingNavigator);
            this.Name = "Оружия";
            this.Text = "Оружие";
            this.Load += new System.EventHandler(this.Покупки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.табаровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оружияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оружияBindingNavigator)).EndInit();
            this.оружияBindingNavigator.ResumeLayout(false);
            this.оружияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.оружияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private табаровDataSet табаровDataSet;
        private System.Windows.Forms.BindingSource оружияBindingSource;
        private табаровDataSetTableAdapters.ОружияTableAdapter оружияTableAdapter;
        private табаровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оружияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton оружияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView оружияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}