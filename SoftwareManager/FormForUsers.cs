using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareManager
{
    public partial class FormForUsers : Form
    {
        public FormForUsers()
        {
            InitializeComponent();
        }

        private void FormForUsers_Load(object sender, EventArgs e)
        {
            FullUserNameLabel.Text = "ФИО: " + User.Surname + " " + User.Name + " " + User.Patronymic;
            DateOfBirthLable.Text ="дата рождения: " + User.DateOfBirth;
            RoleLable.Text ="роль: " + User.Role.ToString();
            PasswordLable.Text = "пароль: " + User.Password;
            LoginLable.Text = "имя для входа: " + User.Login;
            if (User.PK_Number == 0)
            {
                PK_NumberLable.Text = "ПК не назначен";
            }
            else
            {
                PK_NumberLable.Text = "Номер ПК: " + User.PK_Number;
            }

        }
    }
}
