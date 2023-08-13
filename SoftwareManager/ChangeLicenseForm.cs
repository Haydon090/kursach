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
    public partial class ChangeLicenseForm : Form
    {
        private List<SoftwareInstallation> ListOverAll = new List<SoftwareInstallation>();
        private List<SoftwareInstallation> NewList = new List<SoftwareInstallation>();
        private int currentIndex;
        public ChangeLicenseForm(List<SoftwareInstallation> ListOvverAll, List<SoftwareInstallation> newList, int index)
        {
            ListOverAll = ListOvverAll;
            NewList = newList;
            currentIndex = index;
            InitializeComponent();
        }

        private void ChangeLicenseForm_Load(object sender, EventArgs e)
        {

            changeGridView.Rows.Add(ListOverAll[currentIndex].Pc.IdPC, ListOverAll[currentIndex].license.Number, ListOverAll[currentIndex].license.Name, ListOverAll[currentIndex].license.Manufacturer, ListOverAll[currentIndex].license.StartDate, ListOverAll[currentIndex].license.EndDate, ListOverAll[currentIndex].InstallDate, ListOverAll[currentIndex].AdminSurname + ListOverAll[currentIndex].AdminName + ListOverAll[currentIndex].AdminPatronymic, ListOverAll[currentIndex].Pc.address, ListOverAll[currentIndex].Pc.departmentName, ListOverAll[currentIndex].license.State);
                    
            pcNumberTextBox.Text = ListOverAll[currentIndex].Pc.IdPC.ToString();
            licensNumberTextBox.Text = ListOverAll[currentIndex].license.Number.ToString();
            DbConnection.Open();
            MySqlCommand cmd = DbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM `видыпо`";
            string name;
            string manufacturer;
            int number = 0;
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                for (int i = 0; reader.Read(); i++)
                {
                    number++;
                    manufacturer = reader.GetString("производитель");
                    name = reader.GetString("название");


                    kindSoftwareGridView.Rows.Add(number, name, manufacturer);
                  

                }
            }
            DbConnection.Close();
        }

        private void accepcChangeButton_Click(object sender, EventArgs e)

        {
            if(pcNumberTextBox.Text == "")
            {
                MessageBox.Show("ошибка ввода");
                return;
            }
            pcNumberTextBox.Text = ListOverAll[currentIndex].Pc.IdPC.ToString();
            DbConnection.Open();
            MySqlCommand cmd = DbConnection.CreateCommand();
            
           
                if (pcNumberTextBox.Text == "0")
                {
                cmd.CommandText = $"UPDATE `лицензии` SET `ВидыПО_id` = {kindSoftwareGridView.CurrentRow.Index} WHERE (`idЛицензии` = {ListOverAll[currentIndex].id});";
                cmd.ExecuteNonQuery();
                MessageBox.Show("лицензия изменина");
               
            }
            else
            { string startDate = startDateTimePicker.Value.ToString("yyyy.MM.dd");
                string endDate = endDateTimePicker.Value.ToString("yyyy.MM.dd");
                cmd.CommandText = $"UPDATE `лицензии` SET `ВидыПО_id` = {kindSoftwareGridView.CurrentRow.Index} WHERE (`idЛицензии` = {ListOverAll[currentIndex].id});";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"UPDATE `установки по` SET `ПК_id` = {pcNumberTextBox.Text} WHERE (`лицензии_id1` = {ListOverAll[currentIndex].id})";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"UPDATE `лицензии` SET `номер` = {licensNumberTextBox.Text} WHERE (`idЛицензии` = {ListOverAll[currentIndex].id}) ";
                cmd.ExecuteNonQuery();
                //cmd.CommandText = $"UPDATE `лицензии` SET `дата начала действия` = {startDateTimePicker.Value.ToString()} WHERE (`idЛицензии` = {ListOverAll[currentIndex].id} )";
                //cmd.ExecuteNonQuery();
                //cmd.CommandText = $"UPDATE `лицензии` SET `дата окончания действия` = {endDateTimePicker.Value.ToString()} WHERE (`idЛицензии` = {ListOverAll[currentIndex].id} )";
                //cmd.ExecuteNonQuery();
                MessageBox.Show("лицензия изменина");
            }
                    
               DbConnection.Close();           
                      
           
           
          
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

        private void licensNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
