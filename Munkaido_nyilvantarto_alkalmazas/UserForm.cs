using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Munkaido_nyilvantarto_alkalmazas
{
    public partial class UserForm : Form
    {
        Employee employee;
        public UserForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.Text = employee.full_name;
            this.lbMaradek.Text = employee.remaining_vacation.ToString();



        }
    }
}
