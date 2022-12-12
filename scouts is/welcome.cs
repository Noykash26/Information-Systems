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
    public partial class welcome : Form
    {
        public welcome()//new
        {
            InitializeComponent();
        //    setBox();
            welcomUserName.Text = "Welcome " + Program.activUser.NameEng;
        }
        public void showUser()
        {
            //TextBox_nameENG.Text = Program.activUser.NameEng;
            //TextBox_nameHeb.Text= Program.activUser.NameHeb;
            //dateTimePicker1.Value = Program.activUser.Date_of_birth;
            //TextBox_email.Text = Program.activUser.Email;
            //TextBox_Gender.Text = Program.activUser.gender.ToString();
            ////ganderComboBox.SelectedItem = Program.activUser.gender;
            //textbox_phone.Text = Program.activUser.Phone_number;
        }
        private void button_PersonalDetails_Click(object sender, EventArgs e)
        {
            personaldetails p = new personaldetails() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel_content.Controls.Clear();
            this.panel_content.Controls.Add(p);
            p.Show();
            //showUser();
        }
        private void button_OpenDelegations_Click(object sender, EventArgs e)
        {
            openDelegations f = new openDelegations() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true,  };
            this.panel_content.Controls.Clear();
            this.panel_content.Controls.Add(f);
            f.Show();
        }
        private void button_exit_Click(object sender, EventArgs e)//כפתור יציאה
        {
            this.Close();
        }
        private void button_coordinator_Click(object sender, EventArgs e)//מסך שנפתח רק לרכזים
        {
            if (Program.activUser.isCoordinator(Program.activUser)) {//רק אם היוזר הפעיל הוא רכז, החלון יוצג
                coordinatorUX c = new coordinatorUX() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panel_content.Controls.Clear();
                this.panel_content.Controls.Add(c);
                c.Show();
            }
            else MessageBox.Show("You dont have permissions");
        }
        private void button_logOut_Click(object sender, EventArgs e)
        {
            Program.activUser = null;
            logInUp l = new logInUp();
            this.Visible = false;
            l.ShowDialog();

        }
        private void button_passport_Click(object sender, EventArgs e)
        {
            uploadPassport passport = new uploadPassport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel_content.Controls.Clear();
            this.panel_content.Controls.Add(passport);
            passport.Show();
        }
        private void button_fillForms_Click(object sender, EventArgs e)
        {
            FormToFill f = new FormToFill() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, };
            this.panel_content.Controls.Clear();
            this.panel_content.Controls.Add(f);
            f.Show();
        }




        //private void setBox()
        //{
        //    List<Delegation> delegations = Program.delegations;
        //    foreach(Delegation d in delegations)
        //    {
        //       // this.comboBox_selectDel.Items.Add(d.name_);
        //    }
        //}



    }



}
