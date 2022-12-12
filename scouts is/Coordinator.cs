using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scouts
{
    public partial class Coordinator : Form
    {
        public Coordinator()
        {
            InitializeComponent();
            showPersonalDetails();
            textBox1.Text = Program.activUser.findDel(); //הצגת המשלחת של הרכז
        }
        public void showPersonalDetails()
        {
            comboBox_Gender.DataSource = Enum.GetValues(typeof(Gender));
            textBox_CoordinatorNameEng.Text = Program.activUser.NameEng;
            textBox_CoordinatorNameHeb.Text = Program.activUser.NameHeb;
            dateTimePicker1.Text = Program.activUser.Date_of_birth.Date.ToString();
            label_email.Text = Program.activUser.Email;
            textBox_PhoneNumber.Text = Program.activUser.Phone_number;
            comboBox_Gender.DisplayMember = Program.activUser.gender.ToString();
        }
        private void button_DelegationCampers_Click(object sender, EventArgs e)//new
        {
            myCampers mc = new myCampers();
            this.Visible = false;
            mc.ShowDialog();

            //DataTable dtCampers = new DataTable();

            //SqlCommand c = new SqlCommand();
            //c.CommandText = "EXECUTE showMyCampers @DelName";
            //c.Parameters.AddWithValue("@DelName", Program.activUser.findDel());

            ////SQL_CON SC = new SQL_CON();
            ////SC.execute_non_query(c);
            //SQL_CON.ShowTable(c, dtCampers);

        }

        //private void button_Update_Click_1(object sender, EventArgs e)
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "UPDATE [dbo].[User] SET[nameENG] = '" + textBox_CoordinatorNameEng.Text + "',[nameHEB] = '" + textBox_CoordinatorNameHeb.Text + "',[dateOfBirth] = '" + dateTimePicker_DateOfBirth.Value.Date.ToString().Substring(0, 11) + "',[email] = '" + label_email.Text + "',[Gender] = '" + comboBox_Gender.SelectedItem.ToString() + "',[phoneNumber] = '" + textBox_PhoneNumber.Text + "' WHERE[email] like '" + label_email.Text + "'";
        //   SQL_CON sc = new SQL_CON();
        //   SqlDataReader rdr = sc.execute_query(c);
        //   Program.initLists();
        //   MessageBox.Show(c.CommandText);
        //}
    }
}
