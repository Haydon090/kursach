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

    public partial class FormForAdmin : Form
    {
        public FormForAdmin()
        {
            InitializeComponent();
        }
            List<SoftwareInstallation> listInstallPo = new List<SoftwareInstallation>();
            List<SoftwareInstallation> ListNotActivatedPo = new List<SoftwareInstallation>();
            List<SoftwareInstallation>ListOverall = new List<SoftwareInstallation>();
            List<SoftwareInstallation> ListActivatedPo = new List<SoftwareInstallation>();
            List<SoftwareInstallation> newList = new List<SoftwareInstallation>();
        public void loadGridView()

        {   mainGridView.Rows.Clear();

            ListNotActivatedPo.Clear();
            ListNotActivatedPo.Clear();
            listInstallPo.Clear();
            newList.Clear();
            ListOverall.Clear();
            mainGridView.Rows.Clear();
            DbConnection.Open();
            MySqlCommand cmd = DbConnection.CreateCommand();
            cmd.CommandText = "SELECT * FROM `установки по` join  `пк` on `установки по`.`ПК_id` join `помещение` on `пк`.`Помещение_id`" +
            "join `отделы` on `помещение`.`Отделы_id` join `лицензии` on `установки по`.`Лицензии_id1`" +
            "join `видыпо` on `лицензии`.`ВидыПО_id` and `лицензии`.`idЛицензии`= `установки по`.`Лицензии_id1` and `лицензии`.`ВидыПО_id` = `видыпо`.`id`" +
            "join `пользователи` on `установки по`.`пользователи_id` and `пользователи`.`id`= `установки по`.`пользователи_id`and `лицензии`.`idЛицензии` = `установки по`.`Лицензии_id1` and `пк`.id = `установки по`.пк_id";
            string installDate;
            string startDate;
            string endDate;
            string number;
            string softwareName;
            string manufacturer;
            int pcId;
            string addres;
            string departmentName;
            string birthDateAdmin;
            string adminName;
            string adminSurename;
            string adminPatronimic;
            string state;
            int count = 0;
            int id;


            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                

                for (int i = 0; reader.Read(); i++)
                {
                    count++;
                    installDate = reader.GetString("дата установки администратором");

                        startDate = reader.GetString("дата начала действия");

                        endDate = reader.GetString("дата окончания действия");
                            

                  
                    number = reader.GetString("номер");
                    softwareName = reader.GetString("название");
                    manufacturer = reader.GetString("производитель");
                    pcId = reader.GetInt32("ПК_id");
                    addres = reader.GetString("адрес помещения");
                    departmentName = reader.GetString("название отдела");
                    birthDateAdmin = reader.GetString("дата рождения");
                    adminName = reader.GetString("имя");
                    adminSurename = reader.GetString("фамилия");
                    adminPatronimic = reader.GetString("отчество");
                    int tempState = reader.GetInt32("статус_id");
                    if (tempState == 1)
                    {
                        state = "активирован";
                    }
                    else
                    {
                        state = "закончен";
                    }
                    // mainGridView.Rows.Add(pcId, number, softwareName, manufacturer, startDate, endDate, installDate, adminSurename + " " + adminName + " " + adminPatronimic, addres, departmentName, state);
                    PC Pc = new PC(addres, departmentName, pcId);
                    id = reader.GetInt32("лицензии_id1");
                    License license = new License(startDate, endDate, softwareName, number, state, manufacturer);
                    SoftwareInstallation software = new SoftwareInstallation(id,installDate, license, Pc, adminName, adminSurename, adminPatronimic, birthDateAdmin);
                    
                        listInstallPo.Add(software);
                  
                        ListOverall.Add(software);
                   
                      //count,software.Pc.IdPC, software.license.Number, software.license.Name, software.license.Manufacturer, software.license.StartDate, software.InstallDate, software.license.EndDate, software.AdminSurname + " " + software.AdminName + " " + software.AdminPatronymic, software.Pc.address, software.Pc.departmentName, software.license.State);
                }

            }
            cmd.CommandText = "SELECT * FROM `лицензии` join `видыпо` where `лицензии`.`ВидыПО_id` and "+
               " `лицензии`.`статус_id` = 2  and `лицензии`.`ВидыПО_id` = `видыпо`.`id` ";
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                for (int i = 0; reader.Read(); i++)
                {   count++;
                    departmentName = "";
                    addres = "";
                    adminSurename = "";
                    adminPatronimic = "";
                    adminName = "";
                    pcId = 0;
                    number = reader.GetString("номер");
                    softwareName = reader.GetString("название");
                    manufacturer = reader.GetString("производитель");
                    installDate = "";
                    startDate = "";
                    endDate = "";
                    state = "не активирован";
                    birthDateAdmin = "";
                    id = reader.GetInt32("idЛицензии");
                    PC Pc = new PC(addres, departmentName, pcId);
                    
                    License license = new License(startDate, endDate, softwareName, number, state, manufacturer);
                    SoftwareInstallation software = new SoftwareInstallation(id,installDate, license, Pc, adminName, adminSurename, adminPatronimic, birthDateAdmin);
                    ListNotActivatedPo.Add(software);
                    ListOverall.Add(software);
                   // mainGridView.Rows.Add(count,"",software.Pc.IdPC, software.license.Number, software.license.Name, software.license.Manufacturer, software.license.StartDate, software.InstallDate, software.license.EndDate, software.AdminSurname + " " + software.AdminName + " " + software.AdminPatronymic, software.Pc.address, software.Pc.departmentName, software.license.State);
                }

            }

           
            addGridview(ListOverall);
            DbConnection.Close();
          
        } 
        private void FormForAdmin_Load(object sender, EventArgs e)
        {



            fullNameLabel.Text = "Иванов Иван Иванович";
            loadGridView();
            int count = 0;
            for(int i = 0;i < ListOverall.Count(); i++)
            {
                if(ListOverall[i].Pc.IdPC == 0)
                {
                    count++;
                }

            }
            voidLable.Text = count.ToString();

        }

        
        

        private void addLicenseButton_Click(object sender, EventArgs e)
        {
            
            AddLicenseForm addLicenseForm = new AddLicenseForm(ListOverall);
            
            addLicenseForm.FormClosed +=(s, args) => { Show();loadGridView(); };
            Hide();
            addLicenseForm.Show();
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            mainGridView.Rows.Clear();
            newList = ListOverall.Where(
                t => (t.Pc.IdPC.ToString().ToLower().Contains(searchTextBox.Text.ToLower())) ||
                (t.license.Number.ToString().ToLower().Contains(searchTextBox.Text.ToLower())) || (t.license.Manufacturer.ToLower().Contains(searchTextBox.Text.ToLower()))||
                (t.license.Name.ToLower().Contains(searchTextBox.Text.ToLower()))|| (t.license.StartDate.ToLower().Contains(searchTextBox.Text.ToLower()))||
                (t.InstallDate.ToLower().Contains(searchTextBox.Text.ToLower()))|| (t.license.EndDate.ToLower().Contains(searchTextBox.Text.ToLower()))||
                (t.AdminName.ToLower().Contains(searchTextBox.Text.ToLower()))|| (t.AdminSurname.ToLower().Contains(searchTextBox.Text.ToLower()))||
                (t.AdminPatronymic.ToLower().Contains(searchTextBox.Text.ToLower()))|| (t.Pc.address.ToLower().Contains(searchTextBox.Text.ToLower()))||
                (t.Pc.departmentName.ToLower().Contains(searchTextBox.Text.ToLower()))|| (t.license.Name.ToLower().Contains(searchTextBox.Text.ToLower()))||
                (t.license.State.ToLower().Contains(searchTextBox.Text.ToLower()))).ToList();
           for(int i = 0;i < newList.Count(); i++)
            {
                count++;
                mainGridView.Rows.Add(count,newList[i].Pc.IdPC, newList[i].license.Number, newList[i].license.Name, newList[i].license.Manufacturer, newList[i].license.StartDate, newList[i].InstallDate, newList[i].license.EndDate, newList[i].AdminSurname + " " + newList[i].AdminName + " " + newList[i].AdminPatronymic, newList[i].Pc.address, newList[i].Pc.departmentName, newList[i].license.State);
            }
        }

       

       /* private void filtrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainGridView.Rows.Clear();
            int count = 0;
            switch ((string)filtrComboBox.SelectedItem)
            {
                case "все":
                    for (int i = 0; i < ListOverall.Count(); i++)
                    {
                        
                            count++;

                        
                        addOneAliment(ListOverall[i], count);
                    }
                    break;
                case "показать занятые лицензии":
                    for (int i = 0; i < ListOverall.Count(); i++)
                    {
                        if (ListOverall[i].Pc.IdPC != 0)
                        {
                            count++;
                            addOneAliment(ListOverall[i], count);
                        }
                    }
                    break;
                case "показать свободные лицензии":
                    for (int i = 0; i < ListOverall.Count(); i++)
                    {
                        if (ListOverall[i].Pc.IdPC == 0)
                        {
                            count++;
                            addOneAliment(ListOverall[i], count);
                           
                        }

                    }
                    break;
                  
                
            }
           
        }*/
            void addGridview(List<SoftwareInstallation> software)
        
            {
            int count = 0;
            for (int i = 0; i < software.Count(); i++)
            {
                    count++;

                    mainGridView.Rows.Add(count, software[i].Pc.IdPC, software[i].license.Number, software[i].license.Name, software[i].license.Manufacturer,  software[i].license.StartDate, software[i].license.EndDate, software[i].InstallDate, software[i].AdminSurname + " " + software[i].AdminName + " " + software[i].AdminPatronymic, software[i].Pc.address, software[i].Pc.departmentName, software[i].license.State);
            }
        }
            void addOneAliment(SoftwareInstallation soft,int cunt)
            {
                mainGridView.Rows.Add(cunt, soft.Pc.IdPC, soft.license.Number, soft.license.Name, soft.license.Manufacturer, soft.license.StartDate, soft.InstallDate, soft.license.EndDate, soft.AdminSurname + " " + soft.AdminName + " " + soft.AdminPatronymic, soft.Pc.address, soft.Pc.departmentName, soft.license.State);
            }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (mainGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("лицензия не выбрана!");
                return;
            }
            if (

                MessageBox.Show("Вы действительно хотите удалить " +
                (mainGridView.SelectedRows[0].Index + 1) +
                " лицензию?",
                "Подтверждение удаления лицензии",
                MessageBoxButtons.YesNo) == DialogResult.No
                ) { 
                return;
            }
            
            
            int deleteId = mainGridView.SelectedRows[0].Index;
            if (newList.Count() != 0)
            {
                DbConnection.Open();
                MySqlCommand cmd = DbConnection.CreateCommand();
                try
                {
                    
                    if (newList.Count() != 0 && newList[deleteId].Pc.IdPC != 0)
                    {

                        cmd.CommandText = $"delete  FROM `установки По` where лицензии_id1 = {newList[deleteId].id}";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = $"delete  FROM `лицензии` where idЛицензии = {newList[deleteId].id}";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    if (newList.Count() != 0 && newList[deleteId].Pc.IdPC == 0)
                    {
                        cmd.CommandText = $"delete  FROM `лицензии` where idЛицензии = {newList[deleteId].id}";

                        cmd.ExecuteNonQuery();
                        
                    }
                    DbConnection.Close();
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ошибка " + ex.Message);
                    DbConnection.Close();
                    return;

                }

            }
            else if(searchTextBox.Text == "")
            {
                DbConnection.Open();
                MySqlCommand cmd = DbConnection.CreateCommand();
               
                try
                {
                    
                    if (ListOverall.Count() != 0 && ListOverall[deleteId].Pc.IdPC != 0)
                    {

                        cmd.CommandText = $"delete  FROM `установки По` where лицензии_id1 = {ListOverall[deleteId].id}";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = $"delete  FROM `лицензии` where idЛицензии = {ListOverall[deleteId].id}";
                        cmd.ExecuteNonQuery();
                    }
                    else
                    if (ListOverall.Count() != 0 && ListOverall[deleteId].Pc.IdPC == 0)
                    {
                        cmd.CommandText = $"delete  FROM `лицензии` where idЛицензии = {ListOverall[deleteId].id}";

                        cmd.ExecuteNonQuery();
                       
                    }
                    DbConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ошибка " + ex.Message);
                    DbConnection.Close();
                    return;

                }
     
            }
            if (searchTextBox.Text != "")
            {

                MessageBox.Show("лицензия удалина");
                ListNotActivatedPo.Clear();
                ListNotActivatedPo.Clear();
                listInstallPo.Clear();
                newList.Clear();
                ListOverall.Clear();
                mainGridView.Rows.Clear();
                loadGridView();
                searchTextBox.Text = "";
            }
            else
            {
                ListNotActivatedPo.Clear();
                ListNotActivatedPo.Clear();
                listInstallPo.Clear();
                newList.Clear();
                ListOverall.Clear();
                mainGridView.Rows.Clear();
                loadGridView();
                MessageBox.Show("лицензия удалина");
            }

        }
        int selectId;
        int currentIndex;
        bool isOk;
        private void bindLicenseButton_Click(object sender, EventArgs e)
        {
            
            currentIndex = mainGridView.CurrentRow.Index;
            selectId = ListOverall[currentIndex].id;
            if(ListOverall[currentIndex].Pc.IdPC != 0)
            {
                isOk = true;
                MessageBox.Show("у лицензии есть назанченый пк");
                return;  
            }

            if(ListOverall[currentIndex].license.StartDate == "")
            {
                isOk = true;
            }else
            {
                isOk = false;
            }
            
            BindLicenseForm bindLicenseForm = new BindLicenseForm(selectId,isOk);
            bindLicenseForm.FormClosed += (s,args) => {loadGridView(); Show(); };
            Hide();
            bindLicenseForm.Show();
            

        }
      
       

        private void changeButton_Click(object sender, EventArgs e)
        {
            currentIndex = mainGridView.CurrentRow.Index;
           
            ChangeLicenseForm changeLicenseForm = new ChangeLicenseForm(ListOverall,newList, currentIndex);
            changeLicenseForm.FormClosed +=(s, args) => {loadGridView(); Show();  };
            Hide();
            changeLicenseForm.Show();
            
        }
     

        private void graphButton_Click(object sender, EventArgs e)
        {
            GraficForm graficForm = new GraficForm(ListOverall);
            graficForm.FormClosed += (s,args) => { loadGridView(); Show(); };
            graficForm.Show();
        }
    }
}
