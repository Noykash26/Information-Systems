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
    public partial class personaldetails : Form
    {
        public personaldetails()
        {
            InitializeComponent();
            showUser();
        }

        
        public void showUser()
        {
            TextBox_nameENG.Text = Program.activUser.NameEng;
            TextBox_nameHeb.Text = Program.activUser.NameHeb;
            dateTimePicker_birth.Value = Program.activUser.Date_of_birth;
            label_email.Text = Program.activUser.Email;
            genderComboBox.DataSource = Enum.GetValues(typeof(Gender));
            genderComboBox.Text = Program.activUser.gender.ToString();
            textbox_phone.Text = Program.activUser.Phone_number;
        }

        private void button_updateDet_Click(object sender, EventArgs e)
        {
            if (TextBox_nameENG.TextLength == 0 || TextBox_nameHeb.TextLength == 0 || dateTimePicker_birth.Value.Date >= DateTime.Now.Date || textbox_phone.TextLength == 0)
            {
                MessageBox.Show("Fields were not filled correct");
            }

            else
            {
               Program.activUser.UpdateUser(TextBox_nameENG.Text, TextBox_nameHeb.Text, dateTimePicker_birth.Value, label_email.Text, (Gender)genderComboBox.SelectedItem, textbox_phone.Text);
               MessageBox.Show("Updated!");
               // else MessageBox.Show("Failed, Invalid fields");
            }
        }

        private void personaldetails_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_nameheb_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textbox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
