namespace OpenTable
{
    partial class reservations_admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.RES_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPECIFICDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPECIFICDATEANDTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMOFTABLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DININGPOINTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESERVATIONID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USEREMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._RESNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specific_dateandtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occasion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBEROFPEOPLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DININGPOINTSOPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.specificdate_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESERVATION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._USEREMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESNAME_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._SPECIFICDATEANDTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OCCASION_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBEROFPEOPLE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATE_ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._SPECIFICDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RES_NAME,
            this.SPECIFICDATE,
            this.SPECIFICDATEANDTIME,
            this.NUMOFTABLES,
            this.DININGPOINTS});
            this.dataGridView1.Location = new System.Drawing.Point(20, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(698, 121);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RESERVATIONID,
            this.USEREMAIL,
            this._RESNAME,
            this.specific_dateandtime,
            this.phone,
            this.occasion,
            this.NUMBEROFPEOPLE,
            this.DININGPOINTSOPTION,
            this.STATE,
            this.specificdate_});
            this.dataGridView2.Location = new System.Drawing.Point(20, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(698, 133);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RESERVATION_ID,
            this._USEREMAIL,
            this.FIRSTNAME,
            this.LASTNAME,
            this.RESNAME_,
            this._SPECIFICDATEANDTIME,
            this.PHONE_,
            this.OCCASION_,
            this.NUMBEROFPEOPLE_,
            this.STATE_,
            this._SPECIFICDATE});
            this.dataGridView3.Location = new System.Drawing.Point(20, 279);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(698, 132);
            this.dataGridView3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(291, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save Data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RES_NAME
            // 
            this.RES_NAME.DataPropertyName = "RESNAME";
            this.RES_NAME.HeaderText = "RES_NAME";
            this.RES_NAME.Name = "RES_NAME";
            this.RES_NAME.ReadOnly = true;
            // 
            // SPECIFICDATE
            // 
            this.SPECIFICDATE.DataPropertyName = "SPECIFICDATE";
            this.SPECIFICDATE.HeaderText = "SPECIFICDATE";
            this.SPECIFICDATE.Name = "SPECIFICDATE";
            this.SPECIFICDATE.ReadOnly = true;
            // 
            // SPECIFICDATEANDTIME
            // 
            this.SPECIFICDATEANDTIME.DataPropertyName = "SPECIFICDATEANDTIME";
            this.SPECIFICDATEANDTIME.HeaderText = "SPECIFICDATEANDTIME";
            this.SPECIFICDATEANDTIME.Name = "SPECIFICDATEANDTIME";
            this.SPECIFICDATEANDTIME.ReadOnly = true;
            // 
            // NUMOFTABLES
            // 
            this.NUMOFTABLES.DataPropertyName = "NUMOFTABLES";
            this.NUMOFTABLES.HeaderText = "NUMOFTABLES";
            this.NUMOFTABLES.Name = "NUMOFTABLES";
            this.NUMOFTABLES.ReadOnly = true;
            // 
            // DININGPOINTS
            // 
            this.DININGPOINTS.DataPropertyName = "DININGPOINTS";
            this.DININGPOINTS.HeaderText = "DININGPOINTS";
            this.DININGPOINTS.Name = "DININGPOINTS";
            this.DININGPOINTS.ReadOnly = true;
            // 
            // RESERVATIONID
            // 
            this.RESERVATIONID.DataPropertyName = "RESERVATIONID";
            this.RESERVATIONID.HeaderText = "RESERVATIONID";
            this.RESERVATIONID.Name = "RESERVATIONID";
            this.RESERVATIONID.ReadOnly = true;
            // 
            // USEREMAIL
            // 
            this.USEREMAIL.DataPropertyName = "USEREMAIL";
            this.USEREMAIL.HeaderText = "USEREMAIL";
            this.USEREMAIL.Name = "USEREMAIL";
            this.USEREMAIL.ReadOnly = true;
            // 
            // _RESNAME
            // 
            this._RESNAME.DataPropertyName = "RESNAME";
            this._RESNAME.HeaderText = "_RESNAME";
            this._RESNAME.Name = "_RESNAME";
            this._RESNAME.ReadOnly = true;
            // 
            // specific_dateandtime
            // 
            this.specific_dateandtime.DataPropertyName = "specificdateandtime";
            this.specific_dateandtime.HeaderText = "specific_dateandtime";
            this.specific_dateandtime.Name = "specific_dateandtime";
            this.specific_dateandtime.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // occasion
            // 
            this.occasion.DataPropertyName = "occasion";
            this.occasion.HeaderText = "occasion";
            this.occasion.Name = "occasion";
            this.occasion.ReadOnly = true;
            // 
            // NUMBEROFPEOPLE
            // 
            this.NUMBEROFPEOPLE.DataPropertyName = "NUMBEROFPEOPLE";
            this.NUMBEROFPEOPLE.HeaderText = "NUMBEROFPEOPLE";
            this.NUMBEROFPEOPLE.Name = "NUMBEROFPEOPLE";
            this.NUMBEROFPEOPLE.ReadOnly = true;
            // 
            // DININGPOINTSOPTION
            // 
            this.DININGPOINTSOPTION.DataPropertyName = "DININGPOINTSOPTION";
            this.DININGPOINTSOPTION.HeaderText = "DININGPOINTSOPTION";
            this.DININGPOINTSOPTION.Name = "DININGPOINTSOPTION";
            this.DININGPOINTSOPTION.ReadOnly = true;
            // 
            // STATE
            // 
            this.STATE.DataPropertyName = "STATE";
            this.STATE.HeaderText = "STATE";
            this.STATE.Items.AddRange(new object[] {
            "confirmed",
            "unconfirmed"});
            this.STATE.Name = "STATE";
            this.STATE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // specificdate_
            // 
            this.specificdate_.DataPropertyName = "specificdate";
            this.specificdate_.HeaderText = "specificdate_";
            this.specificdate_.Name = "specificdate_";
            this.specificdate_.ReadOnly = true;
            // 
            // RESERVATION_ID
            // 
            this.RESERVATION_ID.DataPropertyName = "RESERVATIONID";
            this.RESERVATION_ID.HeaderText = "RESERVATION_ID";
            this.RESERVATION_ID.Name = "RESERVATION_ID";
            this.RESERVATION_ID.ReadOnly = true;
            // 
            // _USEREMAIL
            // 
            this._USEREMAIL.DataPropertyName = "USEREMAIL";
            this._USEREMAIL.HeaderText = "_USEREMAIL";
            this._USEREMAIL.Name = "_USEREMAIL";
            this._USEREMAIL.ReadOnly = true;
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.DataPropertyName = "FIRSTNAME";
            this.FIRSTNAME.HeaderText = "FIRSTNAME";
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.ReadOnly = true;
            // 
            // LASTNAME
            // 
            this.LASTNAME.DataPropertyName = "LASTNAME";
            this.LASTNAME.HeaderText = "LASTNAME";
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.ReadOnly = true;
            // 
            // RESNAME_
            // 
            this.RESNAME_.DataPropertyName = "RESNAME";
            this.RESNAME_.HeaderText = "RESNAME_";
            this.RESNAME_.Name = "RESNAME_";
            this.RESNAME_.ReadOnly = true;
            // 
            // _SPECIFICDATEANDTIME
            // 
            this._SPECIFICDATEANDTIME.DataPropertyName = "SPECIFICDATEANDTIME";
            this._SPECIFICDATEANDTIME.HeaderText = "_SPECIFICDATEANDTIME";
            this._SPECIFICDATEANDTIME.Name = "_SPECIFICDATEANDTIME";
            this._SPECIFICDATEANDTIME.ReadOnly = true;
            // 
            // PHONE_
            // 
            this.PHONE_.DataPropertyName = "PHONE";
            this.PHONE_.HeaderText = "PHONE_";
            this.PHONE_.Name = "PHONE_";
            this.PHONE_.ReadOnly = true;
            // 
            // OCCASION_
            // 
            this.OCCASION_.DataPropertyName = "OCCASION";
            this.OCCASION_.HeaderText = "OCCASION_";
            this.OCCASION_.Name = "OCCASION_";
            this.OCCASION_.ReadOnly = true;
            // 
            // NUMBEROFPEOPLE_
            // 
            this.NUMBEROFPEOPLE_.DataPropertyName = "NUMBEROFPEOPLE";
            this.NUMBEROFPEOPLE_.HeaderText = "NUMBEROFPEOPLE_";
            this.NUMBEROFPEOPLE_.Name = "NUMBEROFPEOPLE_";
            this.NUMBEROFPEOPLE_.ReadOnly = true;
            // 
            // STATE_
            // 
            this.STATE_.DataPropertyName = "STATE";
            this.STATE_.HeaderText = "STATE_";
            this.STATE_.Items.AddRange(new object[] {
            "confirmed",
            "unconfirmed"});
            this.STATE_.Name = "STATE_";
            // 
            // _SPECIFICDATE
            // 
            this._SPECIFICDATE.DataPropertyName = "SPECIFICDATE";
            this._SPECIFICDATE.HeaderText = "_SPECIFICDATE";
            this._SPECIFICDATE.Name = "_SPECIFICDATE";
            this._SPECIFICDATE.ReadOnly = true;
            // 
            // reservations_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "reservations_admin";
            this.Size = new System.Drawing.Size(743, 488);
            this.Load += new System.EventHandler(this.reservations_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RES_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPECIFICDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPECIFICDATEANDTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMOFTABLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn DININGPOINTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVATIONID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USEREMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn _RESNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn specific_dateandtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn occasion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBEROFPEOPLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DININGPOINTSOPTION;
        private System.Windows.Forms.DataGridViewComboBoxColumn STATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificdate_;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVATION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _USEREMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESNAME_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _SPECIFICDATEANDTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn OCCASION_;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBEROFPEOPLE_;
        private System.Windows.Forms.DataGridViewComboBoxColumn STATE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _SPECIFICDATE;
    }
}
