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
    public partial class FormToFill : Form
    {
        public FormToFill()
        {
            InitializeComponent();
            setBox();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.activUser.isCamper(Program.activUser)) 
            {
                foreach (MyForm f in Program.forms)
                {
                    if (f.formName.Equals(comboBox_selectForm.Text))
                    {
                        printForm(f);
                        
                    }
                }
            }
            else
            {
                if (Program.activUser.isCoordinator(Program.activUser))
                {
                    foreach (MyForm f in Program.forms)
                    {
                        if (f.formName.Equals(comboBox_selectForm.Text))
                        {
                            printForm(f);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("You dont have permissions");
                }
            }             
        }
        public void printForm(MyForm form)
        {
            Form tempform = new Form();
            tempform.Size = new Size(550, 440);
            tempform.Controls.Clear();
            //set label with form name
            Label formLabel = new Label();
            formLabel.Location = new Point(225, 30);
            formLabel.Text = form.formName;
            tempform.Controls.Add(formLabel);
            ////
            string s = "";
            int counter = 0;
            ////
            int pointXTextBox = 100;
            int pointYTextBox = 60;
            int pointXTextBoxLabel = 20;
            ////
            int pointXCheckBox = 300;
            int pointYCheckBox = 60;
            ///
            foreach (Query q in form.queries)
            {
                counter++;
                if (q.queryType.Equals("TextBox"))
                {
                    /////set textBox of the query
                    TextBox textBox = new TextBox();
                    textBox.Location = new Point(pointXTextBox, pointYTextBox);
                    textBox.Name = q.queryname.ToString();
                    tempform.Controls.Add(textBox);
                    ////
                    //set label with query name
                    Label queryLabel1 = new Label();
                    queryLabel1.Location = new Point(pointXTextBoxLabel, pointYTextBox);
                    queryLabel1.Name = q.queryname;
                    queryLabel1.Text = q.queryname;
                    tempform.Controls.Add(queryLabel1);
                    //////
                    pointYTextBox = pointYTextBox + 25;
                }
                if (q.queryType.Equals("CheckBox"))
                {
                    /////set checkBox of the query
                    CheckBox checkBox = new CheckBox();
                    checkBox.Location = new Point(pointXCheckBox, pointYCheckBox);
                    checkBox.Name = q.queryname.ToString();
                    checkBox.Text = q.queryname.ToString();
                    tempform.Controls.Add(checkBox);
                    pointYCheckBox = pointYCheckBox + 25;
                }
            }
            //create button go gunerate the data
            Button buttonSetData = new Button();
            buttonSetData.Name = "setData";
            buttonSetData.Text = "שלח";
            buttonSetData.Location = new Point(pointXCheckBox, pointYCheckBox);

            ///click do=....
            buttonSetData.Click += (object sender, EventArgs e) => {
                SQL_CON sc = new SQL_CON();
                SqlCommand scc = new SqlCommand();
                foreach (Control c in tempform.Controls)
                {
                    string updateToQuery = "UPDATE [dbo].[formQuerys] SET [queryValue]='";
                    if (c is TextBox || c is RichTextBox)
                    {

                        updateToQuery = updateToQuery + c.Text + "',[userFilldBy] = '" + Program.activUser.Email + "' "
                            + "WHERE [formName] like '" + form.formName + "' and [queryType] like 'TextBox' and [queryName]  like '" + c.Name + "'";
                        scc.CommandText = updateToQuery;
                        sc.execute_non_query(scc);
                        form.setQueryValue(c.Name, c.Text);

                    }
                    if (c is CheckBox)
                    {
                        CheckBox temp = (CheckBox)c;
                        updateToQuery = updateToQuery + temp.Checked + "',[userFilldBy] = '" + Program.activUser.Email + "' "
                        + "WHERE [formName] like '" + form.formName + "' and [queryType] like 'CheckBox' and [queryName]  like '" + c.Name + "'";
                        scc.CommandText = updateToQuery;
                        sc.execute_non_query(scc);
                    }

                }

            };
            tempform.Controls.Add(buttonSetData);
            tempform.Show();
            ////
        }
        private void setBox()
        {
            comboBox_selectForm.Items.Clear();
            if (Program.activUser.isCamper(Program.activUser))
            {
                if (Program.activCamper.myDelegation_.delegationForms.Count == 0)
                {
                    MessageBox.Show("no forms to fill");
                }
                else
                {
                    List<MyForm> formnames = Program.activCamper.myDelegation_.delegationForms;
                    foreach (MyForm f in formnames)
                    {
                        this.comboBox_selectForm.Items.Add(f.formName.ToString());
                    }
                }
            }
            if (Program.activUser.isCoordinator(Program.activUser))
            {
                List<MyForm> formnames = Program.forms;
                foreach (MyForm f in formnames)
                {
                    this.comboBox_selectForm.Items.Add(f.formName.ToString());
                }
            }
        }
    }
}
