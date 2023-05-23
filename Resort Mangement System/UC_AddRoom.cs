using Microsoft.VisualBasic;
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
using WFALoginDBD;

namespace Resort_Mangement_System
{
    public partial class UC_AddRoom : UserControl
    {
        private DataAccess Da { get; set; }
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
                if (txtRoomNo.Text !="" && txtRoomType.Text !="" && txtBed.Text !="" && txtPackageType.Text !="" && txtRent.Text!="")
                {
                    String roomNo = txtRoomNo.Text;
                    String roomType = txtRoomType.Text;
                    String bed = txtBed.Text;
                    String packageType = txtPackageType.Text;
                    String rent = txtRent.Text;
                    String bookStatus = "Available";

                    query = "insert into Rooms(RoomNo, RoomType, Bed, PackageType, Price, BookStatus) values('"+roomNo+"', '"+roomType+"', '"+bed+"', '"+packageType+"', "+rent+", '"+ bookStatus +"')";
                    func.setData(query, "Room Added.");
                    UC_AddRoom_Load(this, null);
                }
                else 
                {
                    MessageBox.Show("Fill all Fields.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPackageType.SelectedIndex = -1;
            txtRent.Clear();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from Rooms";
            DataSet ds = func.getData(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
      
    }
}
