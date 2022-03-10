using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munkaido_nyilvantarto_alkalmazas
{
    public class Employee
    {
        public int? employee_id { get; set; }
        public string email_address { get; set; }
        public string full_name { get; set; }
        public DateTime birth_date { get; set; }
        public int password_hash { get; set; }
        public int remaining_vacation { get; set; }
        public int workhours_weekly { get; set; }
        public bool is_admin { get; set; }

        public Employee(int? employee_id, string email_address, string name, DateTime birth_date,
            int password_hash, int remaining_vacation, int workhours_weekly, bool is_admin)
        {
            this.employee_id = employee_id;
            this.email_address = email_address;
            this.full_name = name;
            this.birth_date = birth_date;
            this.password_hash = password_hash;
            this.remaining_vacation = remaining_vacation;
            this.workhours_weekly = workhours_weekly;
            this.is_admin = is_admin;
        }
    }
}
