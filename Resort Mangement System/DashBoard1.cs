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
    public partial class DashBoard1 : Form

    {
        UC_AddRoom ar;
        public DashBoard1()
        {
            InitializeComponent();
            UC_AddRoom addRoom = new UC_AddRoom();
            this.panel6.Controls.Add(addRoom);
            this.ar = addRoom;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            movingpanel1.Visible = true;
            movingpanel2.Visible = false;
            movingpanel3.Visible = false;
            this.panel6.Controls.Clear();
            this.panel6.Controls.Add(ar);
        }

        private void DashBoard1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            movingpanel1.Visible = false;
            movingpanel2.Visible = true; 
            movingpanel3.Visible = false;
            this.panel6.Controls.Clear();
            UC_CustomerDetails customerDetails = new UC_CustomerDetails();
            this.panel6.Controls.Add((customerDetails));
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            movingpanel1.Visible = false;
            movingpanel2.Visible = false;
            movingpanel3.Visible = true;
            this.panel6.Controls.Clear();
            UC_Employee employeeDetails = new UC_Employee();
            this.panel6.Controls.Add((employeeDetails));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    } 
}
