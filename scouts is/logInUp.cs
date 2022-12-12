using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scouts
{
    public partial class logInUp : Form
    {
        public logInUp()
        {
            InitializeComponent();
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
        }
        private void button_signIn_Click(object sender, EventArgs e)
        {
            pages.SelectTab(1);
        }
        private void button_signUp_Click(object sender, EventArgs e)
        {
            pages.SelectTab(0);
        }
        private void button_logIn_Click(object sender, EventArgs e)
        {
            if (checkUser(signInUserName.Text, signInPassword.Text))
            {
                Program.setActiveUser(signInUserName.Text);

                welcome camperUX = new welcome(); //מעבר לממשק משתמש - NEW
                this.Visible = false;
                camperUX.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong user name or password");
            }
        }
        public Boolean checkUser(String email, String password) //שיטה שבודקת האם השם משתמש והסיסמה(שהיא הטלפון) קיימים במערכת
        {
            User u = new User(email, password);
            if (Program.checkUser(u)) { return true; }
            else { return false; }
        }
        private void button_createAccount_Click(object sender, EventArgs e)
        {
            User u = new User(TextBox_email.Text, textbox_phone.Text);
            Gender g = (Gender)genderComboBox.SelectedItem;
           
            if (u.mailInSystem(u))
            {
                MessageBox.Show("User is already in system");
            }

            else if (TextBox_nameENG.TextLength == 0 || TextBox_nameHeb.TextLength == 0 || dateTimePicker1.Value.Date >= DateTime.Now.Date || TextBox_email.TextLength == 0 || textbox_phone.TextLength == 0)
            {
                MessageBox.Show("Fields were not filled correct");
            } //
            else
            {
                User newAccount = new User(TextBox_nameENG.Text, TextBox_nameHeb.Text, dateTimePicker1.Value, TextBox_email.Text, g, textbox_phone.Text, true);
                
            }
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

