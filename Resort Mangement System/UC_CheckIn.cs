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
            this.AutoGenerateCusID();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCusID.Text != "" && txtCusName.Text != "" && txtGender.Text!= "" && txtPackageType.Text != "" && txtPhoneNo.Text != "" && txtRoomNo.Text != "" && txtRoomType.Text != "" && txtAddress.Text != "" && dateCheckInDate.Text != "")
                {
                    String cusID = txtCusID.Text;
                    String cusName = txtCusName.Text;
                    String gender = txtGender.Text;
                    String phoneNo = txtPhoneNo.Text;
                    String address = txtAddress.Text;
                    String roomNo = txtRoomNo.Text;
                    String roomType = txtRoomType.Text;
                    String packageType = txtPackageType.Text;

                    query = "insert into Customer_Table(CustomerID, Name, PhoneNumber, Address, Nationality, Gender, CheckInDate, RoomNo, RoomType, PackageType) values('"+ cusID +"', '"+ cusName +"','"+ gender +"', '"+ phoneNo +"', '"+ address +"', '" + roomNo + "', '" + roomType + "', '" + packageType +" )";
                    func.setData(query, "Check In Done.");
                    
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
        public void setComboBox(String query, ComboBox cb) 
        {
            SqlDataReader sdr = func.getForCombo(query);
            while (sdr.Read()) 
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    cb.Items.Add(sdr.GetString(i));
                }             
            }
            sdr.Close();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "selece RoomNo from Rooms where Bed = '" + txtBed.Text + "' and RoomType = '"+ txtRoomType.Text +"' and PackageType = '"+ txtPackageType.Text +"' and BookStatus = 'Available'";
            setComboBox(query, txtRoomNo);
        }
        private void AutoGenerateCusID()
        {
            query = "select CustomerID from Customer_Table order by CustomerID desc;";
           var dt = this.Da.ExecuteQueryTable(query);
           var lastCusiD = dt.Rows[0][0].ToString();
            string[] s = lastCusiD.Split('-');
            int temp = Convert.ToInt32(s[1]);
            var newCusID = "C-" + (++temp).ToString("d3");
            this.txtCusID.Text = newCusID;
        }
        public void clearAll()
        {
            txtCusID.Clear();
            txtCusName.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            txtGender.SelectedIndex = -1;
            txtRoomNo.SelectedIndex = -1;
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPackageType.SelectedIndex = -1;
            
        }

    }
}
