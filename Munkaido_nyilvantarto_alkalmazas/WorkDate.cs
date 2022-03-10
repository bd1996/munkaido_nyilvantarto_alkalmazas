using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munkaido_nyilvantarto_alkalmazas
{
    enum DateType
    { 
        WORKDAY,WEEKEND,HOLIDAY
    }
    internal class WorkDate
    {
        int date_id { get; set; }
        //date_type-nál itt kéne beállítani a 3 fajtát???
        DateType date_type { get; set; }
        int date_year { get; set; }
        int date_month { get; set; }
        int date_day { get; set; }

        public WorkDate(int date_id, DateType date_type, int date_year, int date_month, int date_day)
        {
            this.date_id = date_id;
            this.date_type = date_type;
            this.date_year = date_year;
            this.date_month = date_month;
            this.date_day = date_day;
        }
    }
}
