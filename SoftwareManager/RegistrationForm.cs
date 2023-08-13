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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public static byte[] HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            return SHA256.Create().ComputeHash(bytes);



        }
        public static string HashToString(byte[] hash)
        {
            return Convert.ToBase64String(hash);
        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            if (!DbConnection.IsLoginUnique(login))
            {
                MessageBox.Show("Имя пользователя уже существует.");
                return;
            }
            else
            {
                if(nameTextBox.Text == "" || surnameTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "" || dateOfBirthTextBox.Text == "" || roleComboBox.Text == "") {
                    MessageBox.Show("Введены неверные данные!");
                    return;
                }
               
               
                string salt = "";
                Random rand = new Random();
                for (int i = 0; i < 5; i++)
                {
                    salt = rand.Next(0, 9).ToString();
                }

                byte[] HashSalt = HashPassword(salt);

                string inputPassword = passwordTextBox.Text;
                byte[] HashInputPassword = HashPassword(inputPassword);
                string resultSalt = HashToString(HashSalt);
                string resultPassword = HashToString(HashInputPassword) + resultSalt;
                int Role = 0; 
                switch ((string)roleComboBox.SelectedItem)
                {
                    case "Обычный пользователь":
                        Role = 2;
                        break;
                    case "Администратор":
                        Role = 1;
                        break;
                }
               
                

                DbConnection.Open();
                MySqlCommand cmd = DbConnection.CreateCommand();
                cmd.CommandText = "Insert into `пользователи` " +
                    " (`имя`, `пароль`, `отчество`, `дата рождения`,`фамилия`,`роли_id`,`имя для входа`,`соль`) " +
                    " VALUES " +
                    $"('{nameTextBox.Text}', " +
                    $" '{resultPassword}'," +
                    $" '{patronymicTextBox.Text}'," +
                    $"'{dateOfBirthTextBox.Text}'," +
                    $"'{passwordTextBox.Text}'," +
                    $"'{Role}'," +
                    $"'{loginTextBox.Text}'," +
                    $"'{resultSalt}');";
                 //   $"{PK_NumberTextBox.Text});";


                cmd.ExecuteNonQuery();
                DbConnection.Close();
            }

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
