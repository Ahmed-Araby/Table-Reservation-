namespace OpenTable
{
    partial class Schedule_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Update));
            this.button9 = new System.Windows.Forms.Button();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(572, 95);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(383, 52);
            this.button9.TabIndex = 99;
            this.button9.Text = "Add";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = "mm/dd/yyyy";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(16, 95);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(442, 51);
            this.bunifuDatepicker1.TabIndex = 102;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 4, 14, 1, 56, 53, 0);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 154);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(991, 594);
            this.flowLayoutPanel1.TabIndex = 103;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuDropdown1.BackgroundImage")));
            this.bunifuDropdown1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuDropdown1.BorderRadius = 0;
            this.bunifuDropdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(15, 16);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(442, 56);
            this.bunifuDropdown1.TabIndex = 105;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // Schedule_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.button9);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Schedule_Update";
            this.Size = new System.Drawing.Size(991, 748);
            this.Load += new System.EventHandler(this.Schedule_Update_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
    }
}
