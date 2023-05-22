using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resort_Mangement_System
{
    public partial class DashBoard2 : Form
    {
        UC_CheckIn ci;
        public DashBoard2()
        {
            InitializeComponent();
            UC_CheckIn checkIn = new UC_CheckIn();
            this.panel6.Controls.Add(checkIn);
            this.ci = checkIn;
        }

        private void DashBoard2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            movingPanel1.Visible = true; 
            movingpanel2.Visible = false;
            movingpanel3.Visible = false;
            movingpanel4.Visible = false;
            this.panel6.Controls.Clear();
            this.panel6.Controls.Add(ci);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            movingPanel1.Visible = false;
            movingpanel2.Visible = true;
            movingpanel3.Visible = false;
            movingpanel4.Visible = false;
            this.panel6.Controls.Clear();
            UC_CheckOut checkOut = new UC_CheckOut();
            this.panel6.Controls.Add((checkOut));
        }

        private void btnRoomDetails_Click(object sender, EventArgs e)
        {
            movingPanel1.Visible = false;
            movingpanel2.Visible = false;
            movingpanel3.Visible = false;
            movingpanel4.Visible = true;
            this.panel6.Controls.Clear();
            UC_RoomDetails roomDetails = new UC_RoomDetails();
            this.panel6.Controls.Add((roomDetails));
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            movingPanel1.Visible = false;
            movingpanel2.Visible = false;
            movingpanel3.Visible = true;
            movingpanel4.Visible = false;
            this.panel6.Controls.Clear();
            UC_CustomerDetails customerDetails = new UC_CustomerDetails();
            this.panel6.Controls.Add((customerDetails));
        }

        
    }
}
