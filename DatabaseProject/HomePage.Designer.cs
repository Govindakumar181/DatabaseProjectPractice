namespace DatabaseProject
{
    partial class HomePage
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
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.txtCountryUpdate = new System.Windows.Forms.ComboBox();
            this.lblCountryUpdate = new System.Windows.Forms.Label();
            this.txtEmailUpdate = new System.Windows.Forms.TextBox();
            this.lblEmailUpdate = new System.Windows.Forms.Label();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.lblPasswordUpdate = new System.Windows.Forms.Label();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblUserUpdate = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.Location = new System.Drawing.Point(373, 496);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(240, 46);
            this.btnUpdateAccount.TabIndex = 21;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // txtCountryUpdate
            // 
            this.txtCountryUpdate.FormattingEnabled = true;
            this.txtCountryUpdate.Items.AddRange(new object[] {
            "Pakistan",
            "India",
            "Japan",
            "USA",
            "Nederland",
            "Denmark",
            "Switzerland"});
            this.txtCountryUpdate.Location = new System.Drawing.Point(373, 437);
            this.txtCountryUpdate.Name = "txtCountryUpdate";
            this.txtCountryUpdate.Size = new System.Drawing.Size(240, 28);
            this.txtCountryUpdate.TabIndex = 20;
            // 
            // lblCountryUpdate
            // 
            this.lblCountryUpdate.AutoSize = true;
            this.lblCountryUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryUpdate.Location = new System.Drawing.Point(187, 438);
            this.lblCountryUpdate.Name = "lblCountryUpdate";
            this.lblCountryUpdate.Size = new System.Drawing.Size(104, 27);
            this.lblCountryUpdate.TabIndex = 19;
            this.lblCountryUpdate.Text = "Country:";
            // 
            // txtEmailUpdate
            // 
            this.txtEmailUpdate.Location = new System.Drawing.Point(373, 326);
            this.txtEmailUpdate.Name = "txtEmailUpdate";
            this.txtEmailUpdate.Size = new System.Drawing.Size(240, 26);
            this.txtEmailUpdate.TabIndex = 16;
            // 
            // lblEmailUpdate
            // 
            this.lblEmailUpdate.AutoSize = true;
            this.lblEmailUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailUpdate.Location = new System.Drawing.Point(190, 324);
            this.lblEmailUpdate.Name = "lblEmailUpdate";
            this.lblEmailUpdate.Size = new System.Drawing.Size(79, 27);
            this.lblEmailUpdate.TabIndex = 15;
            this.lblEmailUpdate.Text = "Email:";
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Location = new System.Drawing.Point(373, 383);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(240, 26);
            this.txtPasswordUpdate.TabIndex = 18;
            // 
            // lblPasswordUpdate
            // 
            this.lblPasswordUpdate.AutoSize = true;
            this.lblPasswordUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordUpdate.Location = new System.Drawing.Point(190, 381);
            this.lblPasswordUpdate.Name = "lblPasswordUpdate";
            this.lblPasswordUpdate.Size = new System.Drawing.Size(124, 27);
            this.lblPasswordUpdate.TabIndex = 17;
            this.lblPasswordUpdate.Text = "Password:";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(373, 270);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(240, 26);
            this.txtNameUpdate.TabIndex = 14;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUpdate.Location = new System.Drawing.Point(187, 268);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(82, 27);
            this.lblNameUpdate.TabIndex = 13;
            this.lblNameUpdate.Text = "Name:";
            // 
            // lblUserUpdate
            // 
            this.lblUserUpdate.AutoSize = true;
            this.lblUserUpdate.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUserUpdate.Location = new System.Drawing.Point(227, 189);
            this.lblUserUpdate.Name = "lblUserUpdate";
            this.lblUserUpdate.Size = new System.Drawing.Size(358, 42);
            this.lblUserUpdate.TabIndex = 12;
            this.lblUserUpdate.Text = "Update User Information";
            this.lblUserUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcomeTitle.Location = new System.Drawing.Point(509, 55);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(218, 42);
            this.lblWelcomeTitle.TabIndex = 22;
            this.lblWelcomeTitle.Text = "Welcome User";
            this.lblWelcomeTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(706, 496);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(240, 46);
            this.btnDeleteAccount.TabIndex = 23;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 587);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblWelcomeTitle);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.txtCountryUpdate);
            this.Controls.Add(this.lblCountryUpdate);
            this.Controls.Add(this.txtEmailUpdate);
            this.Controls.Add(this.lblEmailUpdate);
            this.Controls.Add(this.txtPasswordUpdate);
            this.Controls.Add(this.lblPasswordUpdate);
            this.Controls.Add(this.txtNameUpdate);
            this.Controls.Add(this.lblNameUpdate);
            this.Controls.Add(this.lblUserUpdate);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.ComboBox txtCountryUpdate;
        private System.Windows.Forms.Label lblCountryUpdate;
        private System.Windows.Forms.TextBox txtEmailUpdate;
        private System.Windows.Forms.Label lblEmailUpdate;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.Label lblPasswordUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblUserUpdate;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Button btnDeleteAccount;
    }
}