namespace Resort_Mangement_System
{
    partial class DashBoard2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRoomDetails = new System.Windows.Forms.Button();
            this.movingPanel = new System.Windows.Forms.Panel();
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1422, 673);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnRoomDetails);
            this.panel5.Controls.Add(this.movingPanel);
            this.panel5.Controls.Add(this.btnCustomerDetails);
            this.panel5.Controls.Add(this.btnCheckOut);
            this.panel5.Controls.Add(this.btnCheckIn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 673);
            this.panel5.TabIndex = 3;
            // 
            // btnRoomDetails
            // 
            this.btnRoomDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRoomDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDetails.Location = new System.Drawing.Point(1, 329);
            this.btnRoomDetails.Name = "btnRoomDetails";
            this.btnRoomDetails.Size = new System.Drawing.Size(197, 39);
            this.btnRoomDetails.TabIndex = 3;
            this.btnRoomDetails.Text = "Room Details";
            this.btnRoomDetails.UseVisualStyleBackColor = false;
            this.btnRoomDetails.Click += new System.EventHandler(this.btnRoomDetails_Click);
            // 
            // movingPanel
            // 
            this.movingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.movingPanel.Location = new System.Drawing.Point(5, 201);
            this.movingPanel.Name = "movingPanel";
            this.movingPanel.Size = new System.Drawing.Size(195, 10);
            this.movingPanel.TabIndex = 1;
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCustomerDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.Location = new System.Drawing.Point(3, 274);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(197, 39);
            this.btnCustomerDetails.TabIndex = 2;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.UseVisualStyleBackColor = false;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(3, 217);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(197, 39);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(3, 160);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(197, 39);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // DashBoard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "DashBoard2";
            this.Text = "DashBoard2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard2_FormClosing);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRoomDetails;
        private System.Windows.Forms.Panel movingPanel;
        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
    }
}