namespace SoftwareManager
{
    partial class BindLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BindLicenseForm));
            this.chaingeButton = new System.Windows.Forms.Button();
            this.pcNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // chaingeButton
            // 
            this.chaingeButton.Location = new System.Drawing.Point(25, 85);
            this.chaingeButton.Name = "chaingeButton";
            this.chaingeButton.Size = new System.Drawing.Size(75, 23);
            this.chaingeButton.TabIndex = 0;
            this.chaingeButton.Text = "Привязать";
            this.chaingeButton.UseVisualStyleBackColor = true;
            this.chaingeButton.Click += new System.EventHandler(this.chaingeButton_Click);
            // 
            // pcNumberTextBox
            // 
            this.pcNumberTextBox.Location = new System.Drawing.Point(12, 43);
            this.pcNumberTextBox.Name = "pcNumberTextBox";
            this.pcNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.pcNumberTextBox.TabIndex = 1;
            this.pcNumberTextBox.TextChanged += new System.EventHandler(this.pcNumberTextBox_TextChanged);
            this.pcNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pcNumberTextBox_KeyDown);
            this.pcNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pcNumberTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "введите номер ПК";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(140, 43);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.endDateTimePicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "введите дату начала действия";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(140, 97);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.startDateTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "введите дату окончания действия";
            // 
            // nowDateTimePicker
            // 
            this.nowDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nowDateTimePicker.Location = new System.Drawing.Point(56, 232);
            this.nowDateTimePicker.Name = "nowDateTimePicker";
            this.nowDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.nowDateTimePicker.TabIndex = 9;
            // 
            // BindLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 135);
            this.Controls.Add(this.nowDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcNumberTextBox);
            this.Controls.Add(this.chaingeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BindLicenseForm";
            this.Text = "BindLicenseForm";
            this.Load += new System.EventHandler(this.BindLicenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chaingeButton;
        private System.Windows.Forms.TextBox pcNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker nowDateTimePicker;
    }
}