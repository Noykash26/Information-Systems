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
    public partial class coordinatorUX : Form
    {
        private readonly object panel_coorContent;
        private Form formToadd;

        public coordinatorUX()
        {
            InitializeComponent();
            label2.Text = label2+" "+ Program.activUser.findDel(); //הצגת המשלחת של הרכז
        }

        private void button_DelegationCampers_Click(object sender, EventArgs e)//new
        {
            myCampers mc = new myCampers();
            this.Visible = false;
            mc.ShowDialog();
        }

        private void button_Forms_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            comboBox_misiingForm.Items.Clear();
            string delName = Program.activUser.findDel();
            Delegation del = Program.GetDelegation(delName);
            List<MyForm> formnames = del.delegationForms;
            foreach (MyForm f in formnames)
            {
                this.comboBox_misiingForm.Items.Add(f.formName.ToString());
            }      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SQL_CON sc = new SQL_CON();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE [missingforms] @DelName,@FormName ";
            c.Parameters.AddWithValue("@DelName", Program.activUser.findDel());
            c.Parameters.AddWithValue("@FormName", comboBox_misiingForm.Text);
            DataTable table = new DataTable();
            sc.ShowTable(c, table);
            dataGridView1.DataSource = table;
        }

        private void button_DelegationCampers_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            DataTable dtCampers = new DataTable();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE showMyCampers @DelName";
            c.Parameters.AddWithValue("@DelName", Program.activUser.findDel());
            SQL_CON SC = new SQL_CON();
            SC.ShowTable(c, dtCampers);
            dataGridView_Campers.DataSource = dtCampers;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string delName = Program.activUser.findDel();
            Delegation del = Program.GetDelegation(delName);
            foreach (MyForm f in Program.forms)
            {
                if (f.formName.ToString().Equals(ComboBox_AddDel.Text))
                {
                    if (!del.delegationForms.Contains(f))
                    {
                        del.delegationForms.Add(f);
                        SqlCommand c = new SqlCommand();
                        c.CommandText = "INSERT INTO[dbo].[DelegationForms] ([startDate],[endDate],[name],[formName])  VALUES('"
                            + del.startDate + "','" + del.endDate + "','" + del.name_ + "','" + f.formName + "')";
                        SQL_CON sc = new SQL_CON();
                        SqlDataReader rdr = sc.execute_query(c);
                        MessageBox.Show("form added to your deligation");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            ComboBox_AddDel.Items.Clear();
            foreach (MyForm f in Program.forms)
            {
                this.ComboBox_AddDel.Items.Add(f.formName.ToString());
            }
        }

        private void button_createForm_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            CreateForm cf = new CreateForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel3.Controls.Clear();
            this.panel3.Controls.Add(cf);
            cf.Show();
        }

        private void button_DelegationInformation_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            foreach (Delegation d in Program.delegations)
            {
                if (d.name_ == Program.activUser.findDel())
                    label_delInfo.Text = d.getDescription();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
            DataTable dtCampers = new DataTable();
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE [badForms] @DelName";
            c.Parameters.AddWithValue("@DelName", Program.activUser.findDel());
            SQL_CON SC = new SQL_CON();
            SC.ShowTable(c, dtCampers);
            dataGridView2.DataSource = dtCampers;
        }

        private void label_delInfo_Click(object sender, EventArgs e)
        {

        }
    }
    }
