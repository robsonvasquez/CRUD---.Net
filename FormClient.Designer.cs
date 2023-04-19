namespace teste
{
    partial class FormClient
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
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            btnSave = new Button();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 47);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Robson";
            textBoxFirstName.Size = new Size(267, 23);
            textBoxFirstName.TabIndex = 0;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 29);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "First Name";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 136);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(12, 98);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Vasquez";
            textBoxLastName.Size = new Size(267, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(13, 80);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last Name";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 180);
            Controls.Add(labelLastName);
            Controls.Add(textBoxLastName);
            Controls.Add(btnSave);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxFirstName);
            Name = "FormClient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cliente";
            Load += FormClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private Button btnSave;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
    }
}