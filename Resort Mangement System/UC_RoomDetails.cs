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

namespace Resort_Mangement_System
{
    public partial class UC_RoomDetails : UserControl
    {
        private DataAccess Da { get; set; }
        public UC_RoomDetails()
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Room_Table where RoomNo like '%" + this.textBox1.Text + "%';";
            this.PopulateGridView(query);
        }
    }
}
