using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFALoginDBD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Resort_Mangement_System
{
    
    public partial class UC_Employee : UserControl
    {
        private DataAccess Da { get; set; }
        Function func = new Function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

       

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Load(object sender, EventArgs e)
        {
            query = "select * from EMP";
            DataSet ds = func.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

   
        

        private void txtSEarchID_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from EMP where UserID like '%" + this.txtSEarchID.Text + "%';";
            this.PopulateGridView(query);
        }
        private void PopulateGridView(string sql = "select * from EMP;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
