using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resort_Mangement_System
{
    public partial class UC_AddRoom : UserControl
    {
        Function func = new Function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection con = new SqlConnection("");
                con.Open();
            }
            catch 
            {

            }
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from Room_Table";
            DataSet ds = func.getData(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        }
    }
}
