namespace Laba33
{
    partial class Main
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
            tbPhonesInfo = new TextBox();
            btnAddPhone = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // tbPhonesInfo
            // 
            tbPhonesInfo.Location = new Point(12, 12);
            tbPhonesInfo.Multiline = true;
            tbPhonesInfo.Name = "tbPhonesInfo";
            tbPhonesInfo.ReadOnly = true;
            tbPhonesInfo.Size = new Size(646, 426);
            tbPhonesInfo.TabIndex = 0;
            // 
            // btnAddPhone
            // 
            btnAddPhone.Location = new Point(664, 12);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(124, 29);
            btnAddPhone.TabIndex = 1;
            btnAddPhone.Text = "Add phone";
            btnAddPhone.UseVisualStyleBackColor = true;
            btnAddPhone.Click += btnAddPhone_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(664, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnAddPhone);
            Controls.Add(tbPhonesInfo);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratory work №3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddPhone;
        private Button btnClose;
        public TextBox tbPhonesInfo;
    }
}