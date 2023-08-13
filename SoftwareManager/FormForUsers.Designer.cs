namespace SoftwareManager
{
    partial class FormForUsers
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
            this.FullUserNameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLable = new System.Windows.Forms.Label();
            this.RoleLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.PK_NumberLable = new System.Windows.Forms.Label();
            this.chaingeInformationForUserButtonchaingeInformationForUserButton = new System.Windows.Forms.Button();
            this.changeInformationForPK = new System.Windows.Forms.Button();
            this.adressOfRoom = new System.Windows.Forms.Label();
            this.DataGridViewForLicense = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // FullUserNameLabel
            // 
            this.FullUserNameLabel.AutoSize = true;
            this.FullUserNameLabel.Location = new System.Drawing.Point(-1, 0);
            this.FullUserNameLabel.Name = "FullUserNameLabel";
            this.FullUserNameLabel.Size = new System.Drawing.Size(99, 13);
            this.FullUserNameLabel.TabIndex = 1;
            this.FullUserNameLabel.Text = "FullUserNameLable";
            // 
            // DateOfBirthLable
            // 
            this.DateOfBirthLable.AutoSize = true;
            this.DateOfBirthLable.Location = new System.Drawing.Point(-1, 22);
            this.DateOfBirthLable.Name = "DateOfBirthLable";
            this.DateOfBirthLable.Size = new System.Drawing.Size(88, 13);
            this.DateOfBirthLable.TabIndex = 4;
            this.DateOfBirthLable.Text = "DateOfBirthLable";
            // 
            // RoleLable
            // 
            this.RoleLable.AutoSize = true;
            this.RoleLable.Location = new System.Drawing.Point(-1, 44);
            this.RoleLable.Name = "RoleLable";
            this.RoleLable.Size = new System.Drawing.Size(55, 13);
            this.RoleLable.TabIndex = 5;
            this.RoleLable.Text = "RoleLable";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(-1, 66);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(79, 13);
            this.PasswordLable.TabIndex = 6;
            this.PasswordLable.Text = "PasswordLable";
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Location = new System.Drawing.Point(-1, 88);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(59, 13);
            this.LoginLable.TabIndex = 7;
            this.LoginLable.Text = "LoginLable";
            // 
            // PK_NumberLable
            // 
            this.PK_NumberLable.AutoSize = true;
            this.PK_NumberLable.Location = new System.Drawing.Point(462, 0);
            this.PK_NumberLable.Name = "PK_NumberLable";
            this.PK_NumberLable.Size = new System.Drawing.Size(90, 13);
            this.PK_NumberLable.TabIndex = 8;
            this.PK_NumberLable.Text = "PK_NumberLable";
            // 
            // chaingeInformationForUserButtonchaingeInformationForUserButton
            // 
            this.chaingeInformationForUserButtonchaingeInformationForUserButton.Location = new System.Drawing.Point(23, 127);
            this.chaingeInformationForUserButtonchaingeInformationForUserButton.Name = "chaingeInformationForUserButtonchaingeInformationForUserButton";
            this.chaingeInformationForUserButtonchaingeInformationForUserButton.Size = new System.Drawing.Size(75, 23);
            this.chaingeInformationForUserButtonchaingeInformationForUserButton.TabIndex = 10;
            this.chaingeInformationForUserButtonchaingeInformationForUserButton.Text = "изменить";
            this.chaingeInformationForUserButtonchaingeInformationForUserButton.UseVisualStyleBackColor = true;
            // 
            // changeInformationForPK
            // 
            this.changeInformationForPK.Location = new System.Drawing.Point(465, 44);
            this.changeInformationForPK.Name = "changeInformationForPK";
            this.changeInformationForPK.Size = new System.Drawing.Size(75, 23);
            this.changeInformationForPK.TabIndex = 11;
            this.changeInformationForPK.Text = "изменить";
            this.changeInformationForPK.UseVisualStyleBackColor = true;
            // 
            // adressOfRoom
            // 
            this.adressOfRoom.AutoSize = true;
            this.adressOfRoom.Location = new System.Drawing.Point(462, 22);
            this.adressOfRoom.Name = "adressOfRoom";
            this.adressOfRoom.Size = new System.Drawing.Size(78, 13);
            this.adressOfRoom.TabIndex = 12;
            this.adressOfRoom.Text = "AdressOfRoom";
            // 
            // DataGridViewForLicense
            // 
            this.DataGridViewForLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewForLicense.Location = new System.Drawing.Point(2, 186);
            this.DataGridViewForLicense.Name = "DataGridViewForLicense";
            this.DataGridViewForLicense.Size = new System.Drawing.Size(711, 150);
            this.DataGridViewForLicense.TabIndex = 13;
            // 
            // FormForUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 335);
            this.Controls.Add(this.DataGridViewForLicense);
            this.Controls.Add(this.adressOfRoom);
            this.Controls.Add(this.changeInformationForPK);
            this.Controls.Add(this.chaingeInformationForUserButtonchaingeInformationForUserButton);
            this.Controls.Add(this.PK_NumberLable);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.RoleLable);
            this.Controls.Add(this.DateOfBirthLable);
            this.Controls.Add(this.FullUserNameLabel);
            this.Name = "FormForUsers";
            this.Text = "FormForUsers";
            this.Load += new System.EventHandler(this.FormForUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewForLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullUserNameLabel;
        private System.Windows.Forms.Label DateOfBirthLable;
        private System.Windows.Forms.Label RoleLable;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label PK_NumberLable;
        private System.Windows.Forms.Button chaingeInformationForUserButtonchaingeInformationForUserButton;
        private System.Windows.Forms.Button changeInformationForPK;
        private System.Windows.Forms.Label adressOfRoom;
        private System.Windows.Forms.DataGridView DataGridViewForLicense;
    }
}