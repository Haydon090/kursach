using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Types;

namespace SoftwareManager
{
    public class License
    {

        public string StartDate { set; get; }
        public string EndDate { get; set; }
        public string Name { set; get; }
        public string Number { set; get; }
        public string State { get; set; }
        public string Manufacturer { set; get; }
        public License(string StartDate,string EndDate, string Name,string Number,string State, string Manufacturer)
        {
            this.State = State;
            this.StartDate = StartDate;
            this.EndDate = EndDate; 
            this.Name = Name;
            this.Number = Number;
            this.Manufacturer = Manufacturer;
        }



    }
}
