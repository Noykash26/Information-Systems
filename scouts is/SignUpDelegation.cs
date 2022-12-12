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
    public partial class Form_SignUpDelegation : Form
    {
        public Form_SignUpDelegation()
        {
            InitializeComponent();

            label_CamperNameEnglish.Text = Program.activUser.NameEng;
            label_CamperNameHebre.Text = Program.activUser.NameHeb;
            label_camperPhone.Text = Program.activUser.Phone_number;
            label_email.Text = Program.activUser.Email;
            label_camperGender.Text = Program.activUser.gender.ToString();
            label_camperBirth.Text = Program.activUser.Date_of_birth.ToString();
        }
        public Form_SignUpDelegation(Delegation delegation)
        {
            InitializeComponent();

            label_CamperNameEnglish.Text = Program.activUser.NameEng;
            label_CamperNameHebre.Text = Program.activUser.NameHeb;
            label_camperPhone.Text = Program.activUser.Phone_number;
            label_email.Text = Program.activUser.Email;
            label_camperGender.Text = Program.activUser.gender.ToString();
            label_camperBirth.Text = Program.activUser.Date_of_birth.ToString().Substring(0, 10);
         
            showDelName.Text = delegation.name_;
            delStart.Text = delegation.startDate.Date.ToString().Substring(0, 10);
            delEnd.Text = delegation.endDate.Date.ToString().Substring(0, 10);
        }
        private void button_SignIn_Click(object sender, EventArgs e)//register a camper to a delegation
        {
            //if (textBox_ParentName.TextLength == 0 || textBox_ParentPhone.TextLength == 0)
            //{
            //    MessageBox.Show("Fields were not filled correct");
            //}
            //else
            //{
            //    Camper c = new Camper(label_CamperNameEnglish.Text, label_CamperNameHebre.Text, Program.activUser.Date_of_birth, label_email.Text, Program.activUser.gender, label_camperPhone.Text, textBox_ParentPhone.Text, textBox_ParentName.Text, DateTime.Parse(delStart.Text), DateTime.Parse(delEnd.Text), showDelName.Text, true);
            //    MessageBox.Show("Camper was created successfully");
            //}


        }
        private void button_cancel_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox_ParentPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void Form_SignUpDelegation_Load(object sender, EventArgs e)
        {

        }

        private void textBox_ParentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (textBox_ParentName.TextLength == 0 || textBox_ParentPhone.TextLength == 0)
            {
                MessageBox.Show("Fields were not filled correct");
            }
            else
            {
                Camper c = new Camper(label_CamperNameEnglish.Text, label_CamperNameHebre.Text, Program.activUser.Date_of_birth, label_email.Text, Program.activUser.gender, label_camperPhone.Text, textBox_ParentPhone.Text, textBox_ParentName.Text, DateTime.Parse(delStart.Text), DateTime.Parse(delEnd.Text), showDelName.Text, true);
                MessageBox.Show("Camper was created successfully");
            }

        }

        private void button_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }




        //private void button_SignIn_Click(object sender, EventArgs e)
        //{//להוסיף בדיקה אם המשתמש קיים במערכת 
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "update INTO[dbo].[User] ([nameENG],[nameHEB],[dateOfBirth],[email],[Gender],[phoneNumber])VALUES" + "('" + textBox_CamperNameEnglish.Text + "','" + textBox_CamperNameHebrew.Text + "','"

        //}
    }
}

