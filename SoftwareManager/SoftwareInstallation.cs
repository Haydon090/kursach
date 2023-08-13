using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManager
{
    public class SoftwareInstallation
    {
        public int id { get; set; } 
        public string InstallDate { get; set; }
        public License license { get; set; }
        public PC Pc { get; set; }

        public string AdminName { get; set; }
        public string AdminSurname { get; set; }
        public string AdminPatronymic { get; set; }
        public string AdminBirthDate { get; set; }
       public SoftwareInstallation(int id, string InstallDate,License license,PC Pc, string AdminName, string AdminSurname, string AdminPatronymic, string AdminBirthDate)
        {
            this.id = id;
            this.InstallDate = InstallDate;
            this.license = license;
            this.Pc = Pc;
            this.AdminName = AdminName;
            this.AdminSurname = AdminSurname;
            this.AdminPatronymic = AdminPatronymic;
            this.AdminBirthDate = AdminBirthDate;
        }
    }
}
