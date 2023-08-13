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
    public partial class AddLicenseForm : Form
    {
        public AddLicenseForm(List<SoftwareInstallation> list)
        {
            InitializeComponent();
            ListOverAll = list;
        }
       private List<SoftwareInstallation> ListOverAll = new List<SoftwareInstallation>();
        
        private void AddLicenseForm_Load(object sender, EventArgs e)
        {
            DbConnection.Open();
            MySqlCommand cmd = DbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM `видыпо`";
            string name;
            string manufacturer;
            int number;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                for (int i = 0; reader.Read(); i++)
                {
                    manufacturer = reader.GetString("производитель");
                    name = reader.GetString("название");
                    number = reader.GetInt32("id");
                    kindSoftwareGridView.Rows.Add(number, name, manufacturer);
                }
            }
            DbConnection.Close();
        }


        private void activeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            endDateLabel.Visible = true;
            endDateTimePicker.Visible = true;
            startDateLabel.Visible = true;
            startDateTimePicker.Visible = true;
            PcNumberLabel.Visible = true;
            pcNumberTextBox.Visible = true;
            
        }

        private void disActivRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            endDateLabel.Visible = false;
            endDateTimePicker.Visible = false;
            startDateLabel.Visible = false;
            startDateTimePicker.Visible = false;
            PcNumberLabel.Visible = false;
            pcNumberTextBox.Visible = false;
        }

        private void addSoftwareButton_Click(object sender, EventArgs e)
        {   int licenseId = 0;
            string licenseNumber = "";
            string manufacturer;
            string softwareName;
            string startDate = "";
            string endDate = "";
            int idKindSoftware = 0;
            int state = 0;
             if(licenseNumberTextBox.Text == "")
            {
                MessageBox.Show("ошибка ввода");
            }
          licenseNumber = licenseNumberTextBox.Text;
            string a;
            idKindSoftware = kindSoftwareGridView.CurrentRow.Index + 1;
            for(int i = 0;i < ListOverAll.Count(); i++)
            {
                if(ListOverAll[i].license.Name == pcNumberTextBox.Text)
                {
                    MessageBox.Show("не может быть одинаковых номеров");
                    return;
                }
            }
            
            if (activeRadioButton.Checked)
            {
                state = 1;
               
                
                startDate = startDateTimePicker.Text;
                endDate = endDateTimePicker.Text;
                if(startDate == "" || endDate == "" || pcNumberTextBox.Text == "")
                {
                    MessageBox.Show("ошибка ввода");
                    return;
                }
                if(startDateTimePicker.Value.Date > endDateTimePicker.Value.Date)
                {
                    MessageBox.Show("дата начала не может быть больше даты конца");
                    return;

                }


            }

            if (disActivRadioButton.Checked)
            {
                state = 2;
            }
            if (state == 1)
            {
                
                DbConnection.Open();
                MySqlCommand cmd = DbConnection.CreateCommand();

                cmd.CommandText = "insert into `лицензии`" +
                    "(`дата начала действия`, `дата окончания действия`,`ВидыПО_id`,`номер`,`статус_id`)" +
                    " VALUES " +
                     $"('{startDateTimePicker.Value.ToString("yyyy.MM.dd")}', " +
                     $"'{endDateTimePicker.Value.ToString("yyyy.MM.dd")}'," +
                     $"'{idKindSoftware}'," +
                     $"'{licenseNumber}'," +
                     $"'{state}');";

                cmd.ExecuteNonQuery();
                cmd.CommandText = $"select * from `лицензии` where номер = {licenseNumber}";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    for (int i = 0; reader.Read(); i++) {


                        licenseId = reader.GetInt32("idЛицензии");
                    }
                        
                }
                cmd.ExecuteNonQuery();
                cmd.CommandText = "insert into `установки по` " +
                    "(`дата установки администратором`,`Лицензии_id1`,`пользователи_id`,`ПК_id`)" +
                    " VALUES " +
                     $"('{DateTime.Now.ToString("yyyy.MM.dd")}', " +
                     $"'{licenseId}'," +
                     $"'{User.id}'," +
                     $"'{pcNumberTextBox.Text}');";
                cmd.ExecuteNonQuery();
                DbConnection.Close();
                MessageBox.Show("лицензия успешно добавлена");
            }else
            if(state == 2){
                if(DateTime.Now > startDateTimePicker.Value || DateTime.Now < endDateTimePicker.Value)
                {
                    state = 3;
                }
                DbConnection.Open();
                MySqlCommand cmd = DbConnection.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `видыпо` where id = {idKindSoftware}";
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    for (int i = 0; reader.Read(); i++)
                    {
                        manufacturer = reader.GetString("производитель");
                        softwareName = reader.GetString("название");
                    }
                }
                cmd.CommandText = "insert into `лицензии`" +
                    "(`ВидыПО_id`,`номер`,`статус_id`)" +
                    " VALUES " +
                     $"('{idKindSoftware}'," +
                     $"'{licenseNumber}'," +
                     $"'{state}');";
                cmd.ExecuteNonQuery();
                DbConnection.Close();
                MessageBox.Show("лицензия успешно добавлена");
                
            }
            FormForAdmin formForAdmin = new FormForAdmin();

            
        }

        private void licenseNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void pcNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void pcNumberTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void licenseNumberTextBox_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void pcNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void licenseNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)  | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
