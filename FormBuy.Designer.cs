namespace teste
{
    partial class FormBuy
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
            components = new System.ComponentModel.Container();
            labelClient = new Label();
            comboBoxClient = new ComboBox();
            versaoBindingSource = new BindingSource(components);
            labelProduct = new Label();
            listViewProduct = new ListView();
            buttonProduct = new Button();
            comboBoxProduct = new ComboBox();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)versaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(24, 25);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(38, 15);
            labelClient.TabIndex = 0;
            labelClient.Text = "Client";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(24, 43);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(121, 23);
            comboBoxClient.Sorted = true;
            comboBoxClient.TabIndex = 1;
            // 
            // versaoBindingSource
            // 
            versaoBindingSource.DataSource = typeof(Migrations.versao);
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(24, 82);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(49, 15);
            labelProduct.TabIndex = 2;
            labelProduct.Text = "Product";
            // 
            // listViewProduct
            // 
            listViewProduct.Location = new Point(174, 43);
            listViewProduct.Name = "listViewProduct";
            listViewProduct.Size = new Size(121, 167);
            listViewProduct.TabIndex = 3;
            listViewProduct.UseCompatibleStateImageBehavior = false;
            // 
            // buttonProduct
            // 
            buttonProduct.Location = new Point(25, 133);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(75, 23);
            buttonProduct.TabIndex = 5;
            buttonProduct.Text = "Add";
            buttonProduct.UseVisualStyleBackColor = true;
            buttonProduct.Click += buttonProduct_Click;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(24, 104);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(121, 23);
            comboBoxProduct.Sorted = true;
            comboBoxProduct.TabIndex = 6;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(95, 234);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(113, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormBuy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 296);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxProduct);
            Controls.Add(buttonProduct);
            Controls.Add(listViewProduct);
            Controls.Add(labelProduct);
            Controls.Add(comboBoxClient);
            Controls.Add(labelClient);
            Name = "FormBuy";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormBuy";
            Load += FormBuy_Load;
            ((System.ComponentModel.ISupportInitialize)versaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelClient;
        private ComboBox comboBoxClient;
        private Label labelProduct;
        private ListView listViewProduct;
        private Button buttonProduct;
        private BindingSource versaoBindingSource;
        private ComboBox comboBoxProduct;
        private Button buttonSave;
    }
}