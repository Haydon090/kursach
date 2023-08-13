namespace SoftwareManager
{
    partial class ChangeLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLicenseForm));
            this.pcNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accepcChangeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.changeGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.licensNumberTextBox = new System.Windows.Forms.TextBox();
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
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kindSoftwareGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.changeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindSoftwareGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pcNumberTextBox
            // 
            this.pcNumberTextBox.Location = new System.Drawing.Point(24, 123);
            this.pcNumberTextBox.Name = "pcNumberTextBox";
            this.pcNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcNumberTextBox.TabIndex = 0;
            this.pcNumberTextBox.TextChanged += new System.EventHandler(this.pcNumberTextBox_TextChanged);
            this.pcNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pcNumberTextBox_KeyDown);
            this.pcNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pcNumberTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "номер ПК";
            // 
            // accepcChangeButton
            // 
            this.accepcChangeButton.Location = new System.Drawing.Point(347, 288);
            this.accepcChangeButton.Name = "accepcChangeButton";
            this.accepcChangeButton.Size = new System.Drawing.Size(383, 23);
            this.accepcChangeButton.TabIndex = 14;
            this.accepcChangeButton.Text = "применить";
            this.accepcChangeButton.UseVisualStyleBackColor = true;
            this.accepcChangeButton.Click += new System.EventHandler(this.accepcChangeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, -86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "выберите вид ПО";
            // 
            // changeGridView
            // 
            this.changeGridView.AllowUserToDeleteRows = false;
            this.changeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.changeGridView.Location = new System.Drawing.Point(12, 12);
            this.changeGridView.Name = "changeGridView";
            this.changeGridView.Size = new System.Drawing.Size(1058, 89);
            this.changeGridView.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "номер лицензии";
            // 
            // licensNumberTextBox
            // 
            this.licensNumberTextBox.Location = new System.Drawing.Point(139, 123);
            this.licensNumberTextBox.Name = "licensNumberTextBox";
            this.licensNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.licensNumberTextBox.TabIndex = 19;
            this.licensNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.licensNumberTextBox_KeyPress);
            // 
            // PCnumber
            // 
            this.PCnumber.HeaderText = "номер ПК";
            this.PCnumber.Name = "PCnumber";
            this.PCnumber.Width = 45;
            // 
            // LicenseNumber
            // 
            this.LicenseNumber.HeaderText = "Номер Лицензии";
            this.LicenseNumber.Name = "LicenseNumber";
            this.LicenseNumber.Width = 70;
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
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(41, 237);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.endDateTimePicker.TabIndex = 37;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(41, 183);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.startDateTimePicker.TabIndex = 39;
            // 
            // kindSoftwareGridView
            // 
            this.kindSoftwareGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kindSoftwareGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.poName,
            this.manufac});
            this.kindSoftwareGridView.Location = new System.Drawing.Point(386, 123);
            this.kindSoftwareGridView.Name = "kindSoftwareGridView";
            this.kindSoftwareGridView.Size = new System.Drawing.Size(290, 150);
            this.kindSoftwareGridView.TabIndex = 40;
            // 
            // number
            // 
            this.number.HeaderText = "номер";
            this.number.Name = "number";
            this.number.Width = 45;
            // 
            // poName
            // 
            this.poName.HeaderText = "название ПО";
            this.poName.Name = "poName";
            // 
            // manufac
            // 
            this.manufac.HeaderText = "производительПО";
            this.manufac.Name = "manufac";
            this.manufac.Width = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "выберите вид ПО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "введите дату окончания действия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "введите дату начала действия";
            // 
            // ChangeLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 315);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kindSoftwareGridView);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.licensNumberTextBox);
            this.Controls.Add(this.changeGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accepcChangeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcNumberTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeLicenseForm";
            this.Text = "ChangeLicenseForm";
            this.Load += new System.EventHandler(this.ChangeLicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.changeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindSoftwareGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pcNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accepcChangeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView changeGridView;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox licensNumberTextBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DataGridView kindSoftwareGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn poName;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}