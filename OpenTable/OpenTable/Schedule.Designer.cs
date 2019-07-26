namespace OpenTable
{
    partial class Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.SuspendLayout();
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.White;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.White;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.White;
            this.bunifuMetroTextbox2.BorderThickness = 1;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.Black;
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(18, 35);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(52, 29);
            this.bunifuMetroTextbox2.TabIndex = 40;
            this.bunifuMetroTextbox2.Text = "1000";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(77, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 37;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "21:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = ".";
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
        "0 tables",
        "1 table"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(77, 3);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.White;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(94, 26);
            this.bunifuDropdown1.TabIndex = 106;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuMetroTextbox2);
            this.Controls.Add(this.button2);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(174, 70);
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
    }
}
