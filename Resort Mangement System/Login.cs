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
using System.Data.Sql;

namespace Resort_Mangement_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
            
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-236VNGRV\\SQLEXPRESS;Initial Catalog=\"Resort Management Database\";Integrated Security=True");
                    con.Open();
                   
                    SqlCommand cmd = new SqlCommand("select * from EMP where UserID= @UserID and Password = @Password", con);

                    cmd.Parameters.AddWithValue("@UserID",txtUserID.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlDataAdapter sqda = new SqlDataAdapter(cmd);
                    DataTable Dt = new DataTable();
                    

                    sqda.Fill(Dt);

                    if(Dt.Rows.Count > 0) 
                    {
                        if (Convert.ToString(Dt.Rows[0]["Designation"]) == "Manager")
                        {
                            lblError.Visible = false;
                            DashBoard1 ds = new DashBoard1();
                            this.Hide();
                            ds.Show();
                        }
                        else if(Convert.ToString(Dt.Rows[0]["Designation"]) == "Receptionist")
                        {
                            lblError.Visible = false;
                            DashBoard2 db = new DashBoard2();
                            this.Hide();
                            db.Show();
                        }


                    }
                    else 
                    {
                        lblError.Visible = true;
                        txtPassword.Text = " ";
                        txtUserID.Text = " ";
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("" + ex);
                }
          

               
        }
        public void clearAll()
        {
            txtPassword.Clear();
            txtUserID.Clear();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
