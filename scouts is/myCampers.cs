using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Configuration;

namespace scouts
{
    public partial class myCampers : Form
    {
        public myCampers()
        {
            InitializeComponent();
            DataTable dtCampers = new DataTable();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE showMyCampers @DelName";
            c.Parameters.AddWithValue("@DelName", Program.activUser.findDel());
            SQL_CON SC = new SQL_CON();
            //SC.execute_non_query(c);
            SC.ShowTable(c, dtCampers);
            dataGridView_Campers.DataSource = dtCampers;
        }
        private void myCampers_Load(object sender, EventArgs e)
        {
            //dataGridView_Campers.DataSource = ShowMyCampers();
        }

        //private DataTable ShowMyCampers ()
        //{
        //    //    DataTable dtCampers = new DataTable();

        //    //    string s = ConfigurationManager.ConnectionStrings["Data Source=NOY\\SQLEXPRESS;Initial Catalog=Noy;Integrated Security=True"].ConnectionString;
        //    //    using (sqlConnection)
        //    //    //ShowTable(SqlCommand cmd, DataTable dtb1)

        //    //return dtCampers;
        //}
    }
}
