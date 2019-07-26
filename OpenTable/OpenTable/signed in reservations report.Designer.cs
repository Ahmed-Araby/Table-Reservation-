namespace OpenTable
{
    partial class signed_in_reservations_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signed_in_reservations_report));
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.button2 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.SuspendLayout();
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuDropdown1.BackgroundImage")));
            this.bunifuDropdown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuDropdown1.BorderRadius = 0;
            this.bunifuDropdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[] {
        "1 people",
        "2 people",
        "3 people",
        "4 people",
        "5 people",
        "6 people",
        "7 people",
        "8 people",
        "9 people",
        "10 people",
        "11 people",
        "12 people",
        "13 people",
        "14 people",
        "15 people",
        "16 people",
        "17 people",
        "18 people",
        "19 people",
        "20 people",
        "larger party"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(636, 34);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(314, 49);
            this.bunifuDropdown1.TabIndex = 70;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(312, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(397, 62);
            this.button2.TabIndex = 69;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 167);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(985, 431);
            this.crystalReportViewer1.TabIndex = 71;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuDropdown2.BackgroundImage")));
            this.bunifuDropdown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuDropdown2.BorderRadius = 1;
            this.bunifuDropdown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown2.Items = new string[] {
        "Birthday",
        "Anniversary",
        "Date night",
        "Business meal",
        "Celebration"};
            this.bunifuDropdown2.Location = new System.Drawing.Point(45, 34);
            this.bunifuDropdown2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(394, 49);
            this.bunifuDropdown2.TabIndex = 72;
            // 
            // signed_in_reservations_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "signed_in_reservations_report";
            this.Size = new System.Drawing.Size(991, 601);
            this.Load += new System.EventHandler(this.signed_in_reservations_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Button button2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
    }
}
