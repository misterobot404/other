
namespace DBApp
{
    partial class ПоставкиОружия
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПоставкиОружия));
            this.табаровDataSet = new DBApp.табаровDataSet();
            this.поставкиОружияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкиОружияTableAdapter = new DBApp.табаровDataSetTableAdapters.ПоставкиОружияTableAdapter();
            this.tableAdapterManager = new DBApp.табаровDataSetTableAdapters.TableAdapterManager();
            this.поставкиОружияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.поставкиОружияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.поставкиОружияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.табаровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиОружияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиОружияBindingNavigator)).BeginInit();
            this.поставкиОружияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиОружияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // табаровDataSet
            // 
            this.табаровDataSet.DataSetName = "табаровDataSet";
            this.табаровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставкиОружияBindingSource
            // 
            this.поставкиОружияBindingSource.DataMember = "ПоставкиОружия";
            this.поставкиОружияBindingSource.DataSource = this.табаровDataSet;
            // 
            // поставкиОружияTableAdapter
            // 
            this.поставкиОружияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DBApp.табаровDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВоенныеTableAdapter = null;
            this.tableAdapterManager.Воинские_званияTableAdapter = null;
            this.tableAdapterManager.ОружияTableAdapter = null;
            this.tableAdapterManager.ПоставкиОружияTableAdapter = this.поставкиОружияTableAdapter;
            this.tableAdapterManager.ПродуктыTableAdapter = null;
            this.tableAdapterManager.СлужбаTableAdapter = null;
            this.tableAdapterManager.УчастиеTableAdapter = null;
            this.tableAdapterManager.ЧастьTableAdapter = null;
            // 
            // поставкиОружияBindingNavigator
            // 
            this.поставкиОружияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставкиОружияBindingNavigator.BindingSource = this.поставкиОружияBindingSource;
            this.поставкиОружияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставкиОружияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставкиОружияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставкиОружияBindingNavigatorSaveItem});
            this.поставкиОружияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставкиОружияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставкиОружияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставкиОружияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставкиОружияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставкиОружияBindingNavigator.Name = "поставкиОружияBindingNavigator";
            this.поставкиОружияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставкиОружияBindingNavigator.Size = new System.Drawing.Size(665, 25);
            this.поставкиОружияBindingNavigator.TabIndex = 0;
            this.поставкиОружияBindingNavigator.Text = "bindingNavigator1";
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
            // поставкиОружияBindingNavigatorSaveItem
            // 
            this.поставкиОружияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставкиОружияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставкиОружияBindingNavigatorSaveItem.Image")));
            this.поставкиОружияBindingNavigatorSaveItem.Name = "поставкиОружияBindingNavigatorSaveItem";
            this.поставкиОружияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.поставкиОружияBindingNavigatorSaveItem.Text = "Save Data";
            this.поставкиОружияBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставкиОружияBindingNavigatorSaveItem_Click);
            // 
            // поставкиОружияDataGridView
            // 
            this.поставкиОружияDataGridView.AutoGenerateColumns = false;
            this.поставкиОружияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поставкиОружияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.поставкиОружияDataGridView.DataSource = this.поставкиОружияBindingSource;
            this.поставкиОружияDataGridView.Location = new System.Drawing.Point(0, 28);
            this.поставкиОружияDataGridView.Name = "поставкиОружияDataGridView";
            this.поставкиОружияDataGridView.Size = new System.Drawing.Size(661, 220);
            this.поставкиОружияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодПоставки";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодПоставки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "КодТовара";
            this.dataGridViewTextBoxColumn2.HeaderText = "КодТовара";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ДатаПоставки";
            this.dataGridViewTextBoxColumn3.HeaderText = "ДатаПоставки";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "КоличествоПоставленного";
            this.dataGridViewTextBoxColumn4.HeaderText = "КоличествоПоставленного";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Остаток";
            this.dataGridViewTextBoxColumn5.HeaderText = "Остаток";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ЦенаРозничная";
            this.dataGridViewTextBoxColumn6.HeaderText = "ЦенаРозничная";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ПоставкиОружия
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 250);
            this.Controls.Add(this.поставкиОружияDataGridView);
            this.Controls.Add(this.поставкиОружияBindingNavigator);
            this.Name = "ПоставкиОружия";
            this.Text = "Поставщики Оружия";
            this.Load += new System.EventHandler(this.Рецепт_Load);
            ((System.ComponentModel.ISupportInitialize)(this.табаровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиОружияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиОружияBindingNavigator)).EndInit();
            this.поставкиОружияBindingNavigator.ResumeLayout(false);
            this.поставкиОружияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиОружияDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private табаровDataSet табаровDataSet;
        private System.Windows.Forms.BindingSource поставкиОружияBindingSource;
        private табаровDataSetTableAdapters.ПоставкиОружияTableAdapter поставкиОружияTableAdapter;
        private табаровDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставкиОружияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставкиОружияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView поставкиОружияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}