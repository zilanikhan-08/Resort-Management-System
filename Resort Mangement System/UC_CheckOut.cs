using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFALoginDBD;
using static System.Collections.Specialized.BitVector32;

namespace Resort_Mangement_System
{
    public partial class UC_CheckOut : UserControl
    {
        private DataAccess Da { get; set; }
        Function func = new Function();
        String query;
        public UC_CheckOut()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Customer_Table;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Customer_Table where CustomerID like '%" + this.txtSearch.Text + "%';";
            this.PopulateGridView(query);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "" && dateTimePicker1.Text != "")
            {
                DateTime checkOutDate = DateTime.Today;
                query = @" update Customer_Table
                           set CheckOut = '"+ checkOutDate +@"' 
                           where CustomerID = '" + txtSearch.Text + "' ";
                func.setData(query, "Checked Out");
                this.PopulateGridView();
            }
        }
       
    }
}
