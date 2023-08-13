using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Types;

namespace SoftwareManager
{
    public enum UserRole
    {
        Admin,
        User
       
    }
    public class User
    {
        public static string Surname { get; set; } //Фамилия
        public static string Name { get; set; } //Имя
        public static string Patronymic { get; set; } //Отчество

        public static string Login { get; set; }//имя для входа
        public static string Password { get; set; }//пароль
        public static MySqlDateTime DateOfBirth { get; set; }//дата рождения
        public static string Salt { get; set; }//соль
        public static int PK_Number { get; set; }//номер ПК
        public static UserRole Role { get; set; }//роль
        public static int id{ get; set; }
    }
}
