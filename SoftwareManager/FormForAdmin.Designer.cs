namespace SoftwareManager
{
    partial class FormForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForAdmin));
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfInstallationByAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomOfPc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLicenseButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindLicenseButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.voidLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 9);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(74, 13);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "fullNameLabel";
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.PCnumber,
            this.LicenseNumber,
            this.NamePo,
            this.ManufacturerPO,
            this.StartDate,
            this.EndDate,
            this.DateOfInstallationByAdmin,
            this.FullNameAdmin,
            this.RoomOfPc,
            this.department,
            this.ativated});
            this.mainGridView.Location = new System.Drawing.Point(1, 52);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.Size = new System.Drawing.Size(1229, 316);
            this.mainGridView.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "номер";
            this.id.Name = "id";
            // 
            // PCnumber
            // 
            this.PCnumber.HeaderText = "номер ПК";
            this.PCnumber.Name = "PCnumber";
            this.PCnumber.Width = 85;
            // 
            // LicenseNumber
            // 
            this.LicenseNumber.HeaderText = "Номер Лицензии";
            this.LicenseNumber.Name = "LicenseNumber";
            // 
            // NamePo
            // 
            this.NamePo.HeaderText = "название ПО";
            this.NamePo.Name = "NamePo";
            // 
            // ManufacturerPO
            // 
            this.ManufacturerPO.HeaderText = "Производитель ПО";
            this.ManufacturerPO.Name = "ManufacturerPO";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Дата начала действия";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Дата окончания действия";
            this.EndDate.Name = "EndDate";
            // 
            // DateOfInstallationByAdmin
            // 
            this.DateOfInstallationByAdmin.HeaderText = "Дата установки администраторм";
            this.DateOfInstallationByAdmin.Name = "DateOfInstallationByAdmin";
            // 
            // FullNameAdmin
            // 
            this.FullNameAdmin.HeaderText = "Полное имя администратора";
            this.FullNameAdmin.Name = "FullNameAdmin";
            // 
            // RoomOfPc
            // 
            this.RoomOfPc.HeaderText = "адрес";
            this.RoomOfPc.Name = "RoomOfPc";
            // 
            // department
            // 
            this.department.HeaderText = "отдел";
            this.department.Name = "department";
            // 
            // ativated
            // 
            this.ativated.HeaderText = "статус";
            this.ativated.Name = "ativated";
            // 
            // addLicenseButton
            // 
            this.addLicenseButton.Location = new System.Drawing.Point(368, 374);
            this.addLicenseButton.Name = "addLicenseButton";
            this.addLicenseButton.Size = new System.Drawing.Size(87, 46);
            this.addLicenseButton.TabIndex = 4;
            this.addLicenseButton.Text = "добавить лицензию";
            this.addLicenseButton.UseVisualStyleBackColor = true;
            this.addLicenseButton.Click += new System.EventHandler(this.addLicenseButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(319, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(570, 20);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "введите текст для поиска по всем полям";
            // 
            // bindLicenseButton
            // 
            this.bindLicenseButton.Location = new System.Drawing.Point(461, 374);
            this.bindLicenseButton.Name = "bindLicenseButton";
            this.bindLicenseButton.Size = new System.Drawing.Size(87, 46);
            this.bindLicenseButton.TabIndex = 11;
            this.bindLicenseButton.Text = "привязать лицензию";
            this.bindLicenseButton.UseVisualStyleBackColor = true;
            this.bindLicenseButton.Click += new System.EventHandler(this.bindLicenseButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(554, 374);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(87, 46);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(647, 374);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(87, 46);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(275, 374);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(87, 46);
            this.graphButton.TabIndex = 14;
            this.graphButton.Text = "показать график";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "кол-во свободных лицензий";
            // 
            // voidLable
            // 
            this.voidLable.AutoSize = true;
            this.voidLable.Location = new System.Drawing.Point(740, 391);
            this.voidLable.Name = "voidLable";
            this.voidLable.Size = new System.Drawing.Size(0, 13);
            this.voidLable.TabIndex = 16;
            // 
            // FormForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 427);
            this.Controls.Add(this.voidLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.bindLicenseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addLicenseButton);
            this.Controls.Add(this.mainGridView);
            this.Controls.Add(this.fullNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormForAdmin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormForAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.Button addLicenseButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfInstallationByAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomOfPc;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativated;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bindLicenseButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label voidLable;
    }
}