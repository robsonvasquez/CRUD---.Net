namespace teste
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnClientCreate = new Button();
            labelClient = new Label();
            btnClientUpdate = new Button();
            btnClientDelete = new Button();
            btnProductDelete = new Button();
            btnProductUpdate = new Button();
            labelProduct = new Label();
            btnProductCreate = new Button();
            btnBuyDelete = new Button();
            btnBuyUpdate = new Button();
            labelBuy = new Label();
            btnBuyCreate = new Button();
            versao2BindingSource = new BindingSource(components);
            dataGridViewBuy = new DataGridView();
            dataGridViewClient = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewProduct = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameProduct = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)versao2BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // btnClientCreate
            // 
            btnClientCreate.Location = new Point(66, 12);
            btnClientCreate.Name = "btnClientCreate";
            btnClientCreate.Size = new Size(75, 23);
            btnClientCreate.TabIndex = 0;
            btnClientCreate.Tag = "";
            btnClientCreate.Text = "Create";
            btnClientCreate.UseVisualStyleBackColor = true;
            btnClientCreate.Click += btnClientCreate_Click;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(22, 16);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(38, 15);
            labelClient.TabIndex = 1;
            labelClient.Text = "Client";
            // 
            // btnClientUpdate
            // 
            btnClientUpdate.Location = new Point(147, 12);
            btnClientUpdate.Name = "btnClientUpdate";
            btnClientUpdate.Size = new Size(75, 23);
            btnClientUpdate.TabIndex = 2;
            btnClientUpdate.Text = "Update";
            btnClientUpdate.UseVisualStyleBackColor = true;
            btnClientUpdate.Click += btnClientUpdate_Click;
            // 
            // btnClientDelete
            // 
            btnClientDelete.Location = new Point(228, 12);
            btnClientDelete.Name = "btnClientDelete";
            btnClientDelete.Size = new Size(75, 23);
            btnClientDelete.TabIndex = 3;
            btnClientDelete.Text = "Delete";
            btnClientDelete.UseVisualStyleBackColor = true;
            btnClientDelete.Click += btnClientDelete_Click;
            // 
            // btnProductDelete
            // 
            btnProductDelete.Location = new Point(240, 232);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(72, 23);
            btnProductDelete.TabIndex = 7;
            btnProductDelete.Text = "Delete";
            btnProductDelete.UseVisualStyleBackColor = true;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // btnProductUpdate
            // 
            btnProductUpdate.Location = new Point(159, 232);
            btnProductUpdate.Name = "btnProductUpdate";
            btnProductUpdate.Size = new Size(72, 23);
            btnProductUpdate.TabIndex = 6;
            btnProductUpdate.Text = "Update";
            btnProductUpdate.UseVisualStyleBackColor = true;
            btnProductUpdate.Click += btnProductUpdate_Click;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(27, 236);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(49, 15);
            labelProduct.TabIndex = 5;
            labelProduct.Text = "Product";
            // 
            // btnProductCreate
            // 
            btnProductCreate.Location = new Point(78, 232);
            btnProductCreate.Name = "btnProductCreate";
            btnProductCreate.Size = new Size(72, 23);
            btnProductCreate.TabIndex = 4;
            btnProductCreate.Tag = "";
            btnProductCreate.Text = "Create";
            btnProductCreate.UseVisualStyleBackColor = true;
            btnProductCreate.Click += btnProductCreate_Click;
            // 
            // btnBuyDelete
            // 
            btnBuyDelete.Location = new Point(617, 13);
            btnBuyDelete.Name = "btnBuyDelete";
            btnBuyDelete.Size = new Size(75, 23);
            btnBuyDelete.TabIndex = 11;
            btnBuyDelete.Text = "Delete";
            btnBuyDelete.UseVisualStyleBackColor = true;
            btnBuyDelete.Click += btnBuyDelete_Click;
            // 
            // btnBuyUpdate
            // 
            btnBuyUpdate.Location = new Point(536, 13);
            btnBuyUpdate.Name = "btnBuyUpdate";
            btnBuyUpdate.Size = new Size(75, 23);
            btnBuyUpdate.TabIndex = 10;
            btnBuyUpdate.Text = "Update";
            btnBuyUpdate.UseVisualStyleBackColor = true;
            btnBuyUpdate.Click += btnBuyUpdate_Click;
            // 
            // labelBuy
            // 
            labelBuy.AutoSize = true;
            labelBuy.Location = new Point(420, 17);
            labelBuy.Name = "labelBuy";
            labelBuy.Size = new Size(27, 15);
            labelBuy.TabIndex = 9;
            labelBuy.Text = "Buy";
            // 
            // btnBuyCreate
            // 
            btnBuyCreate.Location = new Point(455, 13);
            btnBuyCreate.Name = "btnBuyCreate";
            btnBuyCreate.Size = new Size(75, 23);
            btnBuyCreate.TabIndex = 8;
            btnBuyCreate.Tag = "";
            btnBuyCreate.Text = "Create";
            btnBuyCreate.UseVisualStyleBackColor = true;
            btnBuyCreate.Click += btnBuyCreate_Click;
            // 
            // dataGridViewBuy
            // 
            dataGridViewBuy.AllowUserToAddRows = false;
            dataGridViewBuy.AllowUserToDeleteRows = false;
            dataGridViewBuy.AllowUserToResizeColumns = false;
            dataGridViewBuy.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuy.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, nameProduct, dataGridViewTextBoxColumn2 });
            dataGridViewBuy.Location = new Point(420, 42);
            dataGridViewBuy.Name = "dataGridViewBuy";
            dataGridViewBuy.ReadOnly = true;
            dataGridViewBuy.RowHeadersVisible = false;
            dataGridViewBuy.RowTemplate.Height = 25;
            dataGridViewBuy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBuy.Size = new Size(313, 282);
            dataGridViewBuy.TabIndex = 14;
            // 
            // dataGridViewClient
            // 
            dataGridViewClient.AllowUserToAddRows = false;
            dataGridViewClient.AllowUserToDeleteRows = false;
            dataGridViewClient.AllowUserToResizeColumns = false;
            dataGridViewClient.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClient.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewClient.Location = new Point(27, 42);
            dataGridViewClient.Name = "dataGridViewClient";
            dataGridViewClient.ReadOnly = true;
            dataGridViewClient.RowHeadersVisible = false;
            dataGridViewClient.RowTemplate.Height = 25;
            dataGridViewClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClient.Size = new Size(354, 172);
            dataGridViewClient.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "firstName";
            dataGridViewTextBoxColumn3.HeaderText = "First Name";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "lastName";
            dataGridViewTextBoxColumn4.HeaderText = "Last Name";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn4.Width = 175;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AllowUserToDeleteRows = false;
            dataGridViewProduct.AllowUserToResizeColumns = false;
            dataGridViewProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewProduct.Location = new Point(27, 261);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersVisible = false;
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new Size(354, 172);
            dataGridViewProduct.TabIndex = 16;
            dataGridViewProduct.CellContentClick += btnProductUpdate_Click;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            dataGridViewTextBoxColumn5.HeaderText = "Name";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Price";
            dataGridViewTextBoxColumn6.HeaderText = "Price";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Client";
            dataGridViewTextBoxColumn1.HeaderText = "Name Client";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameProduct
            // 
            nameProduct.DataPropertyName = "Name";
            nameProduct.HeaderText = "Name Product";
            nameProduct.Name = "nameProduct";
            nameProduct.ReadOnly = true;
            nameProduct.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            dataGridViewTextBoxColumn2.HeaderText = "Price ";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn2.Width = 60;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 445);
            Controls.Add(dataGridViewProduct);
            Controls.Add(dataGridViewClient);
            Controls.Add(dataGridViewBuy);
            Controls.Add(btnBuyDelete);
            Controls.Add(btnBuyUpdate);
            Controls.Add(labelBuy);
            Controls.Add(btnBuyCreate);
            Controls.Add(btnProductDelete);
            Controls.Add(btnProductUpdate);
            Controls.Add(labelProduct);
            Controls.Add(btnProductCreate);
            Controls.Add(btnClientDelete);
            Controls.Add(btnClientUpdate);
            Controls.Add(labelClient);
            Controls.Add(btnClientCreate);
            Name = "FormHome";
            Text = "Home";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)versao2BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientCreate;
        private Label labelClient;
        private Button btnClientUpdate;
        private Button btnClientDelete;
        private Button btnProductDelete;
        private Button btnProductUpdate;
        private Label labelProduct;
        private Button btnProductCreate;
        private Button btnBuyDelete;
        private Button btnBuyUpdate;
        private Label labelBuy;
        private Button btnBuyCreate;
        private BindingSource versao2BindingSource;
        private DataGridView dataGridViewBuy;
        private DataGridView dataGridViewClient;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridView dataGridViewProduct;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameProduct;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}