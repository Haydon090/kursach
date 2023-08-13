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
using System.Security.Cryptography;
using System.IO;

namespace SoftwareManager
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.FormClosed += (s, args) => { Show(); };
            Hide();
            registrationForm.Show();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (!IsGoodLoginAndPassword())
            {
                return;
            }

            string login = loginTextBox.Text;
			
			DbConnection.Open();
			MySqlCommand cmd = DbConnection.CreateCommand();
			cmd.CommandText = "SELECT * FROM `пользователи` WHERE `имя для входа` = @login";
			cmd.Parameters.AddWithValue("@login", login);

			int id = 0;
			string dbPassword = null;
			string dbLogin = null;
			string name = null;
			string surname = null;
			string partonymic = null;
			string salt = null;
			//int PK_Number = 0;
		    MySqlDateTime dateOfBirth;
			UserRole role= 0;
			int roleNum;
			using (MySqlDataReader reader = cmd.ExecuteReader())
			{
				while (reader.Read())
				{
					dbLogin = reader.GetString("имя для входа");
					dbPassword = reader.GetString("пароль");
					id = reader.GetInt32("id");
					surname = reader.GetString("фамилия");
					name = reader.GetString("имя");
					partonymic = reader.GetString("отчество");
					dateOfBirth = reader.GetMySqlDateTime("дата рождения");
					roleNum = reader.GetInt32("роли_id");
					salt = reader.GetString("соль");
					
					switch (roleNum)
					{
						case 1:
							role = UserRole.Admin;
							break;
						case 2:
							role = UserRole.User;
							break;
					
					}

				}
			}
			DbConnection.Close();
			
			string InputPassword = PasswordTextBox.Text;
			byte[] InputPasswordHash = HashPassword(InputPassword);
			string inputHashAndSaltPassword = HashToString(InputPasswordHash) + salt;
			
			
			
			if (loginTextBox.Text == dbLogin && inputHashAndSaltPassword == dbPassword)
			{
				User.Login = dbLogin;
				User.Password = PasswordTextBox.Text;
				User.Surname = surname;
				User.Name = name;
				User.Patronymic = partonymic;
				
				User.id = id;
				
				

				User.Role = role;
				
                switch (role)
                {
					case UserRole.User:
						
						FormForUsers formForUsers = new FormForUsers();
						formForUsers.FormClosed +=(s, args) => { Show(); };
						Hide();
						formForUsers.Show();
						break;
					case UserRole.Admin:
						FormForAdmin formForAdmin = new FormForAdmin();
						formForAdmin.FormClosed +=(s,args) => { Show(); };
						Hide();
						formForAdmin.Show();
						break;
						
				}
				

			}
			else
			{
				MessageBox.Show("Введённого пользователя не существует. ", "Ошибка!");
				
			}

		}
		//метод для хеширования 
		public static byte[] HashPassword(string password)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			return SHA256.Create().ComputeHash(bytes);
		}
		//метод для конвертации хеша в строку
		public static string HashToString(byte[] hash)
		{
			return Convert.ToBase64String(hash);
		}
		//проверка на пустые TextBoxы
		private bool IsGoodLoginAndPassword()
        {
            if (loginTextBox.Text == "" && PasswordTextBox.Text == "")
            {
                MessageBox.Show("вы не ввели логин и пароль", "Ошибка!");
                return false;
            }
            else
           if (loginTextBox.Text == "")
            {
                MessageBox.Show("вы не ввели логин", "Ошибка!");
                return false;
            }
            else
           if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("вы не ввели пароль", "Ошибка!");
                return false;
            }
            else { return true; }
            
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
