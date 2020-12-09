namespace bintree
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Nodes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataNode = new System.Windows.Forms.TextBox();
            this.button_AddNode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_deleteNode = new System.Windows.Forms.Button();
            this.button_deleteLink = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_NextNode = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox_NextNodesForCerrentNode = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edittext_currentNode = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBox_NextNodes = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox_Nodes2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(847, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Помощь по многосвязным спискам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox_Nodes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataNode);
            this.groupBox1.Controls.Add(this.button_AddNode);
            this.groupBox1.Location = new System.Drawing.Point(33, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 258);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление узла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 68);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите узел , который будет \r\nсодержать указатель на создаваемый \r\nузел (для по" +
    "следующего доступа \r\nк созданному узлу) . ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox_Nodes
            // 
            this.listBox_Nodes.FormattingEnabled = true;
            this.listBox_Nodes.ItemHeight = 16;
            this.listBox_Nodes.Location = new System.Drawing.Point(333, 81);
            this.listBox_Nodes.Name = "listBox_Nodes";
            this.listBox_Nodes.Size = new System.Drawing.Size(162, 100);
            this.listBox_Nodes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Данные узла";
            // 
            // dataNode
            // 
            this.dataNode.Location = new System.Drawing.Point(270, 39);
            this.dataNode.Name = "dataNode";
            this.dataNode.Size = new System.Drawing.Size(127, 23);
            this.dataNode.TabIndex = 1;
            // 
            // button_AddNode
            // 
            this.button_AddNode.Location = new System.Drawing.Point(86, 194);
            this.button_AddNode.Name = "button_AddNode";
            this.button_AddNode.Size = new System.Drawing.Size(409, 30);
            this.button_AddNode.TabIndex = 0;
            this.button_AddNode.Text = "Добавить узел";
            this.button_AddNode.UseVisualStyleBackColor = true;
            this.button_AddNode.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_deleteNode);
            this.groupBox2.Controls.Add(this.button_deleteLink);
            this.groupBox2.Controls.Add(this.button_back);
            this.groupBox2.Controls.Add(this.button_NextNode);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(624, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 575);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Переходы между узлами";
            // 
            // button_deleteNode
            // 
            this.button_deleteNode.Location = new System.Drawing.Point(30, 409);
            this.button_deleteNode.Name = "button_deleteNode";
            this.button_deleteNode.Size = new System.Drawing.Size(200, 41);
            this.button_deleteNode.TabIndex = 5;
            this.button_deleteNode.Text = "Удалить текущий узел";
            this.button_deleteNode.UseVisualStyleBackColor = true;
            this.button_deleteNode.Click += new System.EventHandler(this.Button_deleteNode_Click);
            // 
            // button_deleteLink
            // 
            this.button_deleteLink.Location = new System.Drawing.Point(6, 456);
            this.button_deleteLink.Name = "button_deleteLink";
            this.button_deleteLink.Size = new System.Drawing.Size(244, 41);
            this.button_deleteLink.TabIndex = 4;
            this.button_deleteLink.Text = "Удалить выбранный указатель";
            this.button_deleteLink.UseVisualStyleBackColor = true;
            this.button_deleteLink.Click += new System.EventHandler(this.Button_deleteLink_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(30, 503);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(200, 44);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Вернутся к корневому узлу";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // button_NextNode
            // 
            this.button_NextNode.Location = new System.Drawing.Point(30, 355);
            this.button_NextNode.Name = "button_NextNode";
            this.button_NextNode.Size = new System.Drawing.Size(200, 48);
            this.button_NextNode.TabIndex = 2;
            this.button_NextNode.Text = "Перейти на  следующий узел";
            this.button_NextNode.UseVisualStyleBackColor = true;
            this.button_NextNode.Click += new System.EventHandler(this.Button_NextNode_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox_NextNodesForCerrentNode);
            this.groupBox5.Location = new System.Drawing.Point(30, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 202);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Указатели на другие узлы";
            // 
            // listBox_NextNodesForCerrentNode
            // 
            this.listBox_NextNodesForCerrentNode.FormattingEnabled = true;
            this.listBox_NextNodesForCerrentNode.ItemHeight = 16;
            this.listBox_NextNodesForCerrentNode.Location = new System.Drawing.Point(24, 22);
            this.listBox_NextNodesForCerrentNode.Name = "listBox_NextNodesForCerrentNode";
            this.listBox_NextNodesForCerrentNode.Size = new System.Drawing.Size(157, 164);
            this.listBox_NextNodesForCerrentNode.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edittext_currentNode);
            this.groupBox3.Location = new System.Drawing.Point(30, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 90);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Текущий узел";
            // 
            // edittext_currentNode
            // 
            this.edittext_currentNode.Location = new System.Drawing.Point(24, 39);
            this.edittext_currentNode.Name = "edittext_currentNode";
            this.edittext_currentNode.ReadOnly = true;
            this.edittext_currentNode.Size = new System.Drawing.Size(157, 23);
            this.edittext_currentNode.TabIndex = 0;
            this.edittext_currentNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Location = new System.Drawing.Point(33, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(574, 311);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавление связи между узлами";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(409, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "Добавить указатель";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBox_NextNodes);
            this.groupBox7.Location = new System.Drawing.Point(86, 155);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(409, 114);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Выберите доступный указатель";
            // 
            // listBox_NextNodes
            // 
            this.listBox_NextNodes.FormattingEnabled = true;
            this.listBox_NextNodes.ItemHeight = 16;
            this.listBox_NextNodes.Location = new System.Drawing.Point(16, 22);
            this.listBox_NextNodes.Name = "listBox_NextNodes";
            this.listBox_NextNodes.Size = new System.Drawing.Size(378, 84);
            this.listBox_NextNodes.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox_Nodes2);
            this.groupBox6.Location = new System.Drawing.Point(86, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(409, 116);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Выберите узел";
            // 
            // listBox_Nodes2
            // 
            this.listBox_Nodes2.FormattingEnabled = true;
            this.listBox_Nodes2.ItemHeight = 16;
            this.listBox_Nodes2.Location = new System.Drawing.Point(16, 22);
            this.listBox_Nodes2.Name = "listBox_Nodes2";
            this.listBox_Nodes2.Size = new System.Drawing.Size(378, 84);
            this.listBox_Nodes2.TabIndex = 0;
            this.listBox_Nodes2.SelectedValueChanged += new System.EventHandler(this.ListBox_Nodes2_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 679);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Многосвязный список";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_AddNode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox dataNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Nodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox_NextNodesForCerrentNode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox edittext_currentNode;
        private System.Windows.Forms.Button button_NextNode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox listBox_NextNodes;
        private System.Windows.Forms.ListBox listBox_Nodes2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_deleteNode;
        private System.Windows.Forms.Button button_deleteLink;
    }
}

