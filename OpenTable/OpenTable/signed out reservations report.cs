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
using CrystalDecisions.Shared;
namespace OpenTable
{
    public partial class signed_out_reservations_report : UserControl
    {

        string resname;
        Restaurant_admin past;

        string con = "data source = orcl; user id = hr; password = hr;";
        OracleConnection connection;
        OracleCommand cmd;
        public signed_out_reservations_report(Restaurant_admin r, string res_name)
        {
            InitializeComponent();
            bunifuDropdown2.selectedIndex = 0;
            past = r;
            resname = res_name;
        }

        private void signed_out_reservations_report_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(con);
            connection.Open();
            cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select maxparty_size from restaurant where resname='" + resname + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            bunifuDropdown1.Clear();
            if (dr.Read())
            {
                for (int i = 1; i <= Convert.ToInt32(dr[0]); i++)
                {
                    bunifuDropdown1.AddItem(i.ToString() + " people");
                }

                bunifuDropdown1.selectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedValue=="")
            {
                MessageBox.Show("You should complete information");
            }
            else
            {
                
                connection = new OracleConnection(con);
                connection.Open();
                cmd = new OracleCommand("select RESNAME from ADMINS where EMAIL='" + log_in.User_Email + "'", connection);
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                CrystalReport3 CR = new CrystalReport3();
                string resname = "";
                while (reader.Read())
                {
                    resname = reader[0].ToString();
                }
                reader.Close();
                CR.SetParameterValue(0, bunifuDropdown1.selectedValue.ToString().Split(' ')[0]);
                CR.SetParameterValue(1, bunifuDropdown2.selectedValue);
                CR.SetParameterValue(2, resname);
                crystalReportViewer1.ReportSource = CR;
                connection.Close();
                
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
