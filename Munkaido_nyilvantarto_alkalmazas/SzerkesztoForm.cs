using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmailValidation;
using System.Data.SqlClient;

namespace Munkaido_nyilvantarto_alkalmazas
{
    public partial class SzerkesztoForm : Form
    {
        SqlDataAdapter adapter = new SqlDataAdapter();

        public SzerkesztoForm(bool forceAdmin)
        {
            InitializeComponent();
            if(forceAdmin)
            {
                cbAdminE.Checked = true;
                cbAdminE.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            //Hf: összes többi levalidálása
            //név: legalább 2 külön szó
            //jelszó: legalább 12 karakter. kisbetű, nagybetű, szám
            //születési dátum: min. 18 éves
            //kivehető szabi: min. 20 nap

            string nev = tbNev.Text.Trim();
            if (nev.Length<7 || !nev.Contains(" ") )
            {
                MessageBox.Show("Hibás név!");
                return;
            }

            if (!EmailValidator.Validate(tbEMail.Text))
            {
                MessageBox.Show("Hibás e-mail cím!");
                return;
            }

            if (tbJelszo.Text.Length < 12)
            {
                MessageBox.Show("Hibás jelszó!");
                return;
            }

            var kulonbseg = DateTime.Now - dtpSzulDatum.Value;
            if (kulonbseg.TotalDays<18*365)
            {
                MessageBox.Show("Nincs 18!");
                return;
            }

            if (numSzabi.Value <2)
            {
                MessageBox.Show("Túl kevés szabadnap!");
                return;
            }

            if(cbOraszam.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs megadva a heti munkaórák száma! ");
                return;
            }

            int? id = null;
            if (tbAzonosito.Text.Length > 0)
            {
                id =Convert.ToInt32(tbAzonosito.Text);
            }
            Employee employee = new Employee(id,
                                            tbEMail.Text,
                                            nev,
                                            dtpSzulDatum.Value,
                                            tbJelszo.Text.GetHashCode(),
                                            Decimal.ToInt32(numSzabi.Value),
                                            Convert.ToInt32(cbOraszam.SelectedItem),
                                            cbAdminE.Checked);
            using (SqlConnection con = new SqlConnection(Common.CON_STRING))
            {
                con.Open();
                //else ágon update-et kell megírni, hogy emloyee_id alapján
                //beupdate-eljük az employee-t. update command
                int is_admin_int;
                if (employee.is_admin)
                { 
                    is_admin_int = 1;
                }
                else
                {
                    is_admin_int=0;
                }
                if (employee.employee_id == null)
                {
                    string sql = string.Format(@"INSERT INTO Employee (email_address,
                                                                        full_name,
                                                                        birth_date,
                                                                        password_hash,
                                                                        remaining_vacation,
                                                                        workhours_weekly,
                                                                        is_admin) VALUES ('{0}','{1}','{2}',{3},{4},{5},{6})",
                                                                        employee.email_address, employee.full_name, employee.birth_date.Date.ToString("yyyy-MM-dd"),
                                                                        employee.password_hash, employee.remaining_vacation,
                                                                        employee.workhours_weekly, is_admin_int);
                    SqlCommand command = new SqlCommand(sql, con);
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();
                }
                else
                {
                    string sql = string.Format(@"UPDATE Employee SET email_address='{0}', 
                                                                      name='{1}', birth_date='{2}',
                                                                      password_hash={3}, remaining_vacation= {4},
                                                                      workhours_weekly= {5}, is_admin={6}
                                                                      WHERE employee_id= {7}",
                                                                      employee.email_address, employee.full_name,
                                                                      employee.birth_date.Date.ToString("yyyy-MM-dd"),
                                                                      employee.password_hash, employee.remaining_vacation,
                                                                      employee.workhours_weekly, is_admin_int, employee.employee_id);

                    SqlCommand command=new SqlCommand(sql, con);
                    adapter.UpdateCommand = command;
                    adapter.UpdateCommand.ExecuteNonQuery ();                    
                }
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
