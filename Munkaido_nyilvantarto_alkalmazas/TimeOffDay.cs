using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munkaido_nyilvantarto_alkalmazas
{
    internal enum TimeOffType
    {
        PAID_LEAVE,SICK_LEAVE,UNPAID_LEAVE
    }
    internal class TimeOffDay
    {

        TimeOffType time_off_type { get; set; }

        //idegen kulcsoknál így kell beállítani?
        int employee_id { get; set; }
        int date_id { get; set; }

        public TimeOffDay(TimeOffType time_off_type, int employee_id, int date_id)
        {
            this.time_off_type = time_off_type;
            this.employee_id = employee_id;
            this.date_id = date_id;
        }
    }
}
