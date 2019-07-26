using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace OpenTable
{
    public partial class Menu : UserControl
    {
        string source, category_name,restaurant_name;
        Restaurant_Profile past;
        Menu_Update past1;
        bool valid = true;
        string Connection = "Data Source=orcl;user id=hr;password=hr;";
        OracleConnection con;
        OracleCommand cmd;
        OracleDataReader dr;
        public Menu()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(Connection);
            con.Open();
            cmd = new OracleCommand();
            cmd.Connection = con;
            valid = true;
            if(bunifuMetroTextbox1.Text=="")
            {
                MessageBox.Show("please enter a valid Category name");
            }
            else
            {
                if (bunifuMetroTextbox1.Text != category_name)
                {
                    cmd.CommandText = "select count(*) from foodcategory where resname='" + restaurant_name + "' and categoryname='" + bunifuMetroTextbox1.Text + "'";
                    cmd.CommandType = CommandType.Text;
                    dr = cmd.ExecuteReader();
                    if (dr.Read() && Convert.ToInt32(dr[0]) > 0)
                        valid = false;
                    dr.Close();
                }
                if (valid == true)
                {
                    cmd.CommandText = "update foodcategory set categoryname='" + bunifuMetroTextbox1.Text + "' where resname = '" + restaurant_name + "' and categoryname = '" + category_name +"'";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("the data is updated");
                }
                else
                {
                    MessageBox.Show("the data already exists");
                }

                con.Close();
                past1.Menu_Update_Load(this, e);
            }
        }

        public Menu(Restaurant_Profile r,string _source,string res_name,string _category_name)
        {
            InitializeComponent();
            past = r;
            source = _source;
            category_name = _category_name;
            restaurant_name = res_name;
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Menu(Menu_Update r, string _source, string res_name, string _category_name)
        {
            InitializeComponent();
            past1 = r;
            source = _source;
            category_name = _category_name;
            restaurant_name = res_name;
        }
        public void Menu_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            bunifuMetroTextbox1.Text = category_name;
            if (source == "Restaurant_profile") 
            {
                button2.Visible = false;
                bunifuMetroTextbox1.BorderStyle = BorderStyle.None;
                bunifuMetroTextbox1.Enabled = false;
                this.Width += 10;
            }
            if (source == "menu_update")
            {
                this.Width = 743;
                this.Height *= 2;
                this.Height += 50;
               button2.Visible = true;
                button2.Location = new Point(this.Width - 100, button2.Location.Y);
                
                bunifuMetroTextbox1.BorderStyle = BorderStyle.FixedSingle;
                bunifuMetroTextbox1.Enabled = true;
                flowLayoutPanel1.Controls.Add(new Food(this, source, restaurant_name, category_name, "", "null", 0, "new"));
            }
            
            string query = "select foodname,description,price from foodcategory where resname='" + restaurant_name + "' and categoryname='"+category_name+"' and foodname!='null'";
            OracleDataAdapter adapter = new OracleDataAdapter(query, Connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            // connect with frontend
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                flowLayoutPanel1.Controls.Add(new Food(this, source, restaurant_name, category_name,r[0].ToString(),r[1].ToString() ,Convert.ToInt32( r[2]), "old"));
            }
            
        }
    }
}
