using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareManager
{
   public class PC
    {
       public int IdPC { get; set; }
        public string address { get; set; }
        public string departmentName { get; set; }
        public PC(string addres,string departmentName,int IdPC)
        {
            this.address = addres;
            this.departmentName = departmentName;
            this.IdPC = IdPC;
        }
        

    }
}
