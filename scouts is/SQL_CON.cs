using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace scouts
{
    class SQL_CON
    {
         SqlConnection conn;
         
        public SQL_CON(){
            SqlConnection sqlConnection = new SqlConnection("Data Source=NOY\\SQLEXPRESS;Initial Catalog=Noy;Integrated Security=True");
            conn = sqlConnection;//update this!!
        }
         public SqlConnection returnConnection ()
        {
            return conn;
        }
        public void execute_non_query(SqlCommand cmd){
           
            try
         {
             // open a connection object
             this.conn.Open();
             cmd.Connection = conn;
             cmd.ExecuteNonQuery();
             //MessageBox.Show(" השאילתה בוצעה בהצלחה"+cmd.CommandText, "המשך", MessageBoxButtons.OK);
         }
            catch (Exception ex) {
               // MessageBox.Show("שגיאה בביצוע השאילתה " + cmd.CommandText, "המשך", MessageBoxButtons.OK);
            }
           finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public SqlDataReader execute_query(SqlCommand cmd){
            try
               {
                   // open a connection object
                     conn.Open();
                     cmd.Connection = conn;
                     SqlDataReader READER =cmd.ExecuteReader(); 
                     return READER;
              }
            catch (Exception ex)
               {
                MessageBox.Show("שגיאה בביצוע השאילתה  " + cmd.CommandText, "המשך", MessageBoxButtons.OK);
                return null;
              }


        }
        public void ShowTable(SqlCommand cmd, DataTable dtb1)
        {
            try
            {
                // open a connection object
                conn.Open();
                cmd.Connection = conn;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtb1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בהכנה לטבלה", "המשך", MessageBoxButtons.OK);
            }


        }
    }
}
//checked