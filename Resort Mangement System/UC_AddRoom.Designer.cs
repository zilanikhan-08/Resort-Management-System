namespace Resort_Mangement_System
{
    partial class UC_AddRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddRoom = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.ComboBox();
            this.txtBed = new System.Windows.Forms.ComboBox();
            this.btn_AddRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddRoom
            // 
            this.lblAddRoom.AutoSize = true;
            this.lblAddRoom.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRoom.Location = new System.Drawing.Point(10, 25);
            this.lblAddRoom.Name = "lblAddRoom";
            this.lblAddRoom.Size = new System.Drawing.Size(189, 40);
            this.lblAddRoom.TabIndex = 0;
            this.lblAddRoom.Text = "Add Room";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(928, 83);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(106, 23);
            this.lblRoomNo.TabIndex = 1;
            this.lblRoomNo.Text = "Room No.";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(928, 180);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(119, 23);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(928, 285);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(48, 23);
            this.lblBed.TabIndex = 3;
            this.lblBed.Text = "Bed";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.Location = new System.Drawing.Point(1207, 180);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(54, 23);
            this.lblRent.TabIndex = 4;
            this.lblRent.Text = "Rent";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 458);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(932, 109);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(157, 22);
            this.txtRoomNo.TabIndex = 6;
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(1211, 206);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(157, 22);
            this.txtRent.TabIndex = 7;
            // 
            // txtRoomType
            // 
            this.txtRoomType.FormattingEnabled = true;
            this.txtRoomType.Items.AddRange(new object[] {
            "AC",
            "Non-AC"});
            this.txtRoomType.Location = new System.Drawing.Point(932, 206);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(157, 24);
            this.txtRoomType.TabIndex = 8;
            // 
            // txtBed
            // 
            this.txtBed.FormattingEnabled = true;
            this.txtBed.Items.AddRange(new object[] {
            "KingSize",
            "Double",
            "Triple"});
            this.txtBed.Location = new System.Drawing.Point(932, 311);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(157, 24);
            this.txtBed.TabIndex = 10;
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddRoom.Location = new System.Drawing.Point(1046, 448);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(146, 33);
            this.btn_AddRoom.TabIndex = 11;
            this.btn_AddRoom.Text = "ADD";
            this.btn_AddRoom.UseVisualStyleBackColor = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1207, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Package Type";
            // 
            // txtPackageType
            // 
            this.txtPackageType.FormattingEnabled = true;
            this.txtPackageType.Items.AddRange(new object[] {
            "Regular",
            "Couple",
            "VIP",
            "HoneyMoon",
            "Wedding",
            "Hoilday"});
            this.txtPackageType.Location = new System.Drawing.Point(1211, 109);
            this.txtPackageType.Name = "txtPackageType";
            this.txtPackageType.Size = new System.Drawing.Size(157, 24);
            this.txtPackageType.TabIndex = 13;
            // 
            // UC_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPackageType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AddRoom);
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.lblAddRoom);
            this.Name = "UC_AddRoom";
            this.Size = new System.Drawing.Size(1545, 1020);
            this.Load += new System.EventHandler(this.UC_AddRoom_Load);
            this.Enter += new System.EventHandler(this.UC_AddRoom_Enter);
            this.Leave += new System.EventHandler(this.UC_AddRoom_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddRoom;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.ComboBox txtRoomType;
        private System.Windows.Forms.ComboBox txtBed;
        private System.Windows.Forms.Button btn_AddRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtPackageType;
    }
}
