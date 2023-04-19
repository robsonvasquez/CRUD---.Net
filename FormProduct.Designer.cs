namespace teste
{
    partial class FormProduct
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
            labelName = new Label();
            textBoxName = new TextBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 25);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 43);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(197, 23);
            textBoxName.TabIndex = 1;

            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 75);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(12, 93);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(78, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 175);
            Controls.Add(btnSave);
            Controls.Add(textBoxPrice);
            Controls.Add(labelPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormProduct";
            Load += FormProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelPrice;
        private Button btnSave;
        public TextBox textBoxName;
        public TextBox textBoxPrice;
    }
}