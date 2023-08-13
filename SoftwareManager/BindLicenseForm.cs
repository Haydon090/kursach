using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace SoftwareManager
{
    public partial class BindLicenseForm : Form
    {
       private int licenseId;
        private bool isOk;

        public BindLicenseForm(int id,bool isok)
        {
            licenseId = id;
            isOk = isok;
            InitializeComponent();
        }
        
        private void BindLicenseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void chaingeButton_Click(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value.Date > endDateTimePicker.Value.Date) {
                MessageBox.Show("дата начала не может быть больше даты конца");
                return;
            
            }
           
            
               if(pcNumberTextBox.Text == "")
            {
                MessageBox.Show("ошибка ввода");
                return;
            }
                DbConnection.Open();
                MySqlCommand cmd = DbConnection.CreateCommand();
              
                cmd.CommandText = "insert into `установки по` " +
                    "(`дата установки администратором`,`Лицензии_id1`,`пользователи_id`,`ПК_id`)" +
                    " VALUES " +
                     $"('{ DateTime.Now.ToString("yyyy.MM.dd")}', " +
                     $"'{licenseId}'," +
                     $"'{User.id}'," +
                     $"'{pcNumberTextBox.Text}');";

                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE `лицензии` SET `дата начала действия` =" +
                   $" '{startDateTimePicker.Value.ToString("yyyy.MM.dd")}', `дата окончания действия` = '{endDateTimePicker.Value.ToString("yyyy.MM.dd")}' WHERE (`idЛицензии` = {licenseId});";

                cmd.ExecuteNonQuery();
                DbConnection.Close();
            MessageBox.Show("лицензия привязана");


        }

        private void pcNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void pcNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
