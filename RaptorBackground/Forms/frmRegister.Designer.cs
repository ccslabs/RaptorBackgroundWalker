namespace RaptorBackground.Forms
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valid Email Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegister.Location = new System.Drawing.Point(313, 267);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(232, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = global::RaptorBackground.Properties.Settings.Default.tbInputBoxActive;
            this.cbCountries.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "tbInputBoxActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(14, 113);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(374, 21);
            this.cbCountries.Sorted = true;
            this.cbCountries.TabIndex = 13;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = global::RaptorBackground.Properties.Settings.Default.tbInputBoxActive;
            this.tbConfirmPassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "tbInputBoxActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbConfirmPassword.Location = new System.Drawing.Point(14, 231);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(374, 20);
            this.tbConfirmPassword.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = global::RaptorBackground.Properties.Settings.Default.tbInputBoxActive;
            this.tbPassword.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "tbInputBoxActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPassword.Location = new System.Drawing.Point(14, 192);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(374, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.BackColor = global::RaptorBackground.Properties.Settings.Default.tbInputBoxActive;
            this.tbEmailAddress.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "tbInputBoxActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbEmailAddress.Location = new System.Drawing.Point(14, 153);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(374, 20);
            this.tbEmailAddress.TabIndex = 6;
            this.tbEmailAddress.Leave += new System.EventHandler(this.tbEmailAddress_Leave);
            // 
            // tbFullName
            // 
            this.tbFullName.BackColor = global::RaptorBackground.Properties.Settings.Default.tbInputBoxActive;
            this.tbFullName.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "tbInputBoxActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbFullName.Location = new System.Drawing.Point(14, 75);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(374, 20);
            this.tbFullName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = global::RaptorBackground.Properties.Settings.Default.PanelTopBackColour;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::RaptorBackground.Properties.Settings.Default, "PanelTopBackColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 56);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "The Computer Crime Service";
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::RaptorBackground.Properties.Settings.Default, "PanelTopTextForeColour", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::RaptorBackground.Properties.Settings.Default.PanelTopTextForeColour;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you for helping to end Child Abuse Online";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(400, 302);
            this.ControlBox = false;
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCountries;
    }
}