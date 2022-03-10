using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Munkaido_nyilvantarto_alkalmazas
{
    public partial class BejelentkezesForm : Form
    {
        private List<Employee> employees = new List<Employee>();

        public BejelentkezesForm()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(Common.CON_STRING))
            {
                con.Open();
                String sql = "SELECT employee_id,email_address,full_name,birth_date,password_hash,remaining_vacation,workhours_weekly,is_admin FROM Employee";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Employee employee = new Employee(dataReader.GetInt32(0), dataReader.GetString(1),
                        dataReader.GetString(2), dataReader.GetDateTime(3), dataReader.GetInt32(4),
                        dataReader.GetInt32(5), dataReader.GetInt32(6), dataReader.GetBoolean(7));
                    employees.Add(employee);
                }
            }
            //létre kell hozni egy szerkesztoformot és feldobni a usernek
            //while ciklusba amíg nincs mentés
            //ha mentésre kattint OK, ha mégse akkor Cancellel térjünk vissza
            if(employees.Count == 0)
            {
                //ha üres az adatbázis hozzon létre egy admint a szerkesztoformon
                //messagebox->szerkesztoform->user mentése->bejelentkezes
                MessageBox.Show("Hozzon létre egy új admint!");
                SzerkesztoForm szerkeszto=new SzerkesztoForm(true);
                DialogResult result=szerkeszto.ShowDialog();
                while (result != DialogResult.OK)
                {
                    MessageBox.Show("Hozzon létre egy új admint!");
                    szerkeszto = new SzerkesztoForm(true);
                    result = szerkeszto.ShowDialog();
                }


            }

        }

        private void btnBejelentkezes_Click(object sender, EventArgs e)
        {
            if(tbEMailCim.Text =="" || tbJelszo.Text == "") 
            {
                MessageBox.Show("Egyik mező sem lehet üres!");
                return;
            }
            foreach (Employee employee in employees)
            { 
                if(employee.email_address==tbEMailCim.Text)
                {
                    if (employee.password_hash==tbJelszo.Text.GetHashCode())
                    {
                        UserForm userform = new UserForm(employee);
                        Hide();
                        userform.ShowDialog();
                        Close();

                    }
                }
            }
            MessageBox.Show("Nem megfelelő e-mail cím vagy jelszó! ");
            
        }
    }
}
