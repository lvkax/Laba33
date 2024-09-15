namespace Laba33
{
    partial class fPhone
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
            cbHas3Cameras = new CheckBox();
            cbHasWirelessCharging = new CheckBox();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            tbBatteryCapacity = new TextBox();
            tbYearofPurchase = new TextBox();
            tbReleaseYear = new TextBox();
            tbCost = new TextBox();
            tbModel = new TextBox();
            tbName = new TextBox();
            groupBox2 = new GroupBox();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbHas3Cameras
            // 
            cbHas3Cameras.AutoSize = true;
            cbHas3Cameras.Location = new Point(29, 41);
            cbHas3Cameras.Name = "cbHas3Cameras";
            cbHas3Cameras.Size = new Size(153, 24);
            cbHas3Cameras.TabIndex = 0;
            cbHas3Cameras.Text = "Has three cameras";
            cbHas3Cameras.UseVisualStyleBackColor = true;
            // 
            // cbHasWirelessCharging
            // 
            cbHasWirelessCharging.AutoSize = true;
            cbHasWirelessCharging.Location = new Point(29, 106);
            cbHasWirelessCharging.Name = "cbHasWirelessCharging";
            cbHasWirelessCharging.Size = new Size(174, 24);
            cbHasWirelessCharging.TabIndex = 1;
            cbHasWirelessCharging.Text = "Has wireless charging";
            cbHasWirelessCharging.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(41, 37);
            Label1.Name = "Label1";
            Label1.Size = new Size(38, 20);
            Label1.TabIndex = 2;
            Label1.Text = "Firm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 78);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 144);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 4;
            label3.Text = "Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 208);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 5;
            label4.Text = "Release year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 273);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 6;
            label5.Text = "Year of purchase";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 335);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 7;
            label6.Text = "Battery capacity";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbBatteryCapacity);
            groupBox1.Controls.Add(tbYearofPurchase);
            groupBox1.Controls.Add(tbReleaseYear);
            groupBox1.Controls.Add(tbCost);
            groupBox1.Controls.Add(tbModel);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 377);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "General info";
            // 
            // tbBatteryCapacity
            // 
            tbBatteryCapacity.Location = new Point(250, 335);
            tbBatteryCapacity.Name = "tbBatteryCapacity";
            tbBatteryCapacity.Size = new Size(125, 27);
            tbBatteryCapacity.TabIndex = 13;
            // 
            // tbYearofPurchase
            // 
            tbYearofPurchase.Location = new Point(250, 273);
            tbYearofPurchase.Name = "tbYearofPurchase";
            tbYearofPurchase.Size = new Size(125, 27);
            tbYearofPurchase.TabIndex = 12;
            // 
            // tbReleaseYear
            // 
            tbReleaseYear.Location = new Point(250, 208);
            tbReleaseYear.Name = "tbReleaseYear";
            tbReleaseYear.Size = new Size(125, 27);
            tbReleaseYear.TabIndex = 11;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(250, 144);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(125, 27);
            tbCost.TabIndex = 10;
            // 
            // tbModel
            // 
            tbModel.Location = new Point(250, 78);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(125, 27);
            tbModel.TabIndex = 9;
            // 
            // tbName
            // 
            tbName.Location = new Point(250, 26);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbHasWirelessCharging);
            groupBox2.Controls.Add(cbHas3Cameras);
            groupBox2.Location = new Point(12, 395);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 166);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Features";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(472, 33);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(129, 29);
            btnOk.TabIndex = 10;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(472, 86);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fPhone
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(613, 573);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox2);
            Controls.Add(Label1);
            Controls.Add(groupBox1);
            Name = "fPhone";
            Text = "New phone info";
            Load += fPhone_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbHas3Cameras;
        private CheckBox cbHasWirelessCharging;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbBatteryCapacity;
        private TextBox tbYearofPurchase;
        private TextBox tbReleaseYear;
        private TextBox tbCost;
        private TextBox tbModel;
        private TextBox tbName;
        private Button btnOk;
        private Button btnCancel;
    }
}