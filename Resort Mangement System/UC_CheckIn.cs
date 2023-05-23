using Microsoft.VisualBasic;
using System;
using System.Collections;
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
    public partial class UC_CheckIn : UserControl
    {
        private DataAccess Da { get; set; }
        Function func = new Function();
        String query;
        public UC_CheckIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();
           this.PopulateGridView();

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCusID.Text != "" && txtCusName.Text != "" && txtGender.Text!= "" && txtPackageType.Text != "" && txtPhoneNo.Text != "" && txtRoomType.Text != "" && txtAddress.Text != "" && dateCheckInDate.Text != "" && txtBed.Text != "")
                {
                    String cusID = txtCusID.Text;
                    String cusName = txtCusName.Text;
                    String gender = txtGender.Text;
                    String phoneNo = txtPhoneNo.Text;
                    String address = txtAddress.Text;
                    DateTime checkInDate = DateTime.Today;
                    var roomNo = this.dataGridView1.CurrentRow.Cells["RoomNo"].Value.ToString();


                    query = "insert into Customer_Table(CustomerID, CusName, PhoneNo, Address, Gender, CheckIn, RoomNo) values('"+ cusID +"', '"+ cusName +"', '"+ phoneNo +"', '"+ address +"','"+ gender +"', '"+ checkInDate +"', '"+ roomNo +"' )";
                    func.setData(query, "Check In Done.");
                    String sql = @" update Rooms
                                set BookStatus = 'Not Available',
                                PackageType = '"+ this.txtPackageType.Text +@"',
                                RoomType = '"+ this.txtRoomType.Text +@"',
                                Bed = '"+ this.txtBed.Text +@"'
                                where RoomNo = '" + roomNo + "'; ";
                    func.setData(sql,"");
                    this.PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Fill all Fields.", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        
        public void clearAll()
        {
            txtCusID.Clear();
            txtCusName.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            txtGender.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPackageType.SelectedIndex = -1;
            
        }
        private void PopulateGridView(string sql = "select RoomNo from Rooms where BookStatus = 'Available';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_CheckIn_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
