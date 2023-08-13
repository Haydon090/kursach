namespace SoftwareManager
{
    partial class AddLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLicenseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.kindSoftwareGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerPo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.addSoftwareButton = new System.Windows.Forms.Button();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.disActivRadioButton = new System.Windows.Forms.RadioButton();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pcNumberTextBox = new System.Windows.Forms.TextBox();
            this.PcNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kindSoftwareGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "введите номер лицензии";
            // 
            // kindSoftwareGridView
            // 
            this.kindSoftwareGridView.AllowUserToAddRows = false;
            this.kindSoftwareGridView.AllowUserToDeleteRows = false;
            this.kindSoftwareGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kindSoftwareGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.namePO,
            this.ManufacturerPo});
            this.kindSoftwareGridView.Location = new System.Drawing.Point(9, 30);
            this.kindSoftwareGridView.Name = "kindSoftwareGridView";
            this.kindSoftwareGridView.Size = new System.Drawing.Size(283, 224);
            this.kindSoftwareGridView.TabIndex = 8;
            // 
            // number
            // 
            this.number.HeaderText = "номер";
            this.number.Name = "number";
            this.number.Width = 40;
            // 
            // namePO
            // 
            this.namePO.HeaderText = "название ПО";
            this.namePO.Name = "namePO";
            // 
            // ManufacturerPo
            // 
            this.ManufacturerPo.HeaderText = "производитель";
            this.ManufacturerPo.Name = "ManufacturerPo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "выберите вид ПО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "выберите статус";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(298, 95);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(161, 13);
            this.startDateLabel.TabIndex = 18;
            this.startDateLabel.Text = "введите дату начала действия";
            this.startDateLabel.Visible = false;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(303, 135);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(179, 13);
            this.endDateLabel.TabIndex = 19;
            this.endDateLabel.Text = "введите дату окончания действия";
            this.endDateLabel.Visible = false;
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Location = new System.Drawing.Point(307, 262);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.licenseNumberTextBox.TabIndex = 21;
            this.licenseNumberTextBox.TextChanged += new System.EventHandler(this.licenseNumberTextBox_TextChanged);
            this.licenseNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.licenseNumberTextBox_KeyDown);
            this.licenseNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.licenseNumberTextBox_KeyPress);
            // 
            // addSoftwareButton
            // 
            this.addSoftwareButton.Location = new System.Drawing.Point(12, 260);
            this.addSoftwareButton.Name = "addSoftwareButton";
            this.addSoftwareButton.Size = new System.Drawing.Size(280, 22);
            this.addSoftwareButton.TabIndex = 22;
            this.addSoftwareButton.Text = "добавить";
            this.addSoftwareButton.UseVisualStyleBackColor = true;
            this.addSoftwareButton.Click += new System.EventHandler(this.addSoftwareButton_Click);
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(303, 47);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(102, 17);
            this.activeRadioButton.TabIndex = 23;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "активированна";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            this.activeRadioButton.CheckedChanged += new System.EventHandler(this.activeRadioButton_CheckedChanged);
            // 
            // disActivRadioButton
            // 
            this.disActivRadioButton.AutoSize = true;
            this.disActivRadioButton.Checked = true;
            this.disActivRadioButton.Location = new System.Drawing.Point(303, 72);
            this.disActivRadioButton.Name = "disActivRadioButton";
            this.disActivRadioButton.Size = new System.Drawing.Size(117, 17);
            this.disActivRadioButton.TabIndex = 24;
            this.disActivRadioButton.TabStop = true;
            this.disActivRadioButton.Text = "не активированна";
            this.disActivRadioButton.UseVisualStyleBackColor = true;
            this.disActivRadioButton.CheckedChanged += new System.EventHandler(this.disActivRadioButton_CheckedChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(303, 151);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.endDateTimePicker.TabIndex = 25;
            this.endDateTimePicker.Visible = false;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(303, 112);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.startDateTimePicker.TabIndex = 26;
            this.startDateTimePicker.Visible = false;
            // 
            // pcNumberTextBox
            // 
            this.pcNumberTextBox.Location = new System.Drawing.Point(306, 198);
            this.pcNumberTextBox.Name = "pcNumberTextBox";
            this.pcNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcNumberTextBox.TabIndex = 28;
            this.pcNumberTextBox.Visible = false;
            this.pcNumberTextBox.TextChanged += new System.EventHandler(this.pcNumberTextBox_TextChanged);
            this.pcNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pcNumberTextBox_KeyDown);
            this.pcNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pcNumberTextBox_KeyPress);
            // 
            // PcNumberLabel
            // 
            this.PcNumberLabel.AutoSize = true;
            this.PcNumberLabel.Location = new System.Drawing.Point(306, 182);
            this.PcNumberLabel.Name = "PcNumberLabel";
            this.PcNumberLabel.Size = new System.Drawing.Size(101, 13);
            this.PcNumberLabel.TabIndex = 29;
            this.PcNumberLabel.Text = "введите номер ПК";
            this.PcNumberLabel.Visible = false;
            // 
            // AddLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 291);
            this.Controls.Add(this.PcNumberLabel);
            this.Controls.Add(this.pcNumberTextBox);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.disActivRadioButton);
            this.Controls.Add(this.activeRadioButton);
            this.Controls.Add(this.addSoftwareButton);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kindSoftwareGridView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddLicenseForm";
            this.Text = "AddLicenseForm";
            this.Load += new System.EventHandler(this.AddLicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kindSoftwareGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView kindSoftwareGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerPo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Button addSoftwareButton;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.RadioButton disActivRadioButton;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.TextBox pcNumberTextBox;
        private System.Windows.Forms.Label PcNumberLabel;
    }
}