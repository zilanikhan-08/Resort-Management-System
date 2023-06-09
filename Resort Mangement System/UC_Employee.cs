﻿using Microsoft.SqlServer.Server;
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
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = ds.Tables[0];

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEName.Text != "" && txtUserID.Text != "" && txtPassword.Text != "" && txtSalary.Text != "" && txtDesignation.Text != "" && dateTimePicker1.Text != "")
                {
                    String eName = txtEName.Text;
                    String userID = txtUserID.Text;
                    String password = txtPassword.Text;
                    String salary = txtSalary.Text;
                    String designation = txtDesignation.Text;
                    DateTime joiningDate = DateTime.Today;

                    query = "insert into EMP(UserID, Password, Name, Designation, Salary, JoiningDate) values('" + userID + "', '" + password + "', '" + eName + "', '" + designation + "', '" + salary + "', '"+ joiningDate +"')";
                    func.setData(query, "Emplyoee Hired");
                    
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

        private void tabPage1_Load(object sender, EventArgs e)
        {
            query = "select * from EMP";
            DataSet ds = func.getData(query);
            this.PopulateGridView(query);
        }

        private void txtEID_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from EMP where UserID like '%" + this.txtEID.Text + "%';";
            this.PopulateGridView(query);
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            if(txtEID.Text != "")
            {
                if(MessageBox.Show("Are you Sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    query = "delete from EMP where UserID = '" + txtEID.Text + "'";
                    func.setData(query, "Terminated.");
                    tabEmployee_SelectedIndexChanged(query, null);
                }
            }
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabEmployee.SelectedIndex == 1)
            {
                query = "select * from EMP";
                DataSet ds = func.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }                
        }
    }
}
