using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFALoginDBD;

namespace Resort_Mangement_System
{
    public partial class UC_CustomerDetails : UserControl
    {
        private DataAccess Da { get;set; }
        public UC_CustomerDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        private void PopulateGridView(string sql = "select * from Customer_Table;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Customer_Table where CustomerID like '%" + this.txtID.Text + "%';";
            this.PopulateGridView(query);
        }
    }
}
