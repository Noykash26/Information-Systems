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
    public partial class CreateForm : Form
    {
        private int freeTextAtribute = 0;
        private int boolAribute = 0;

        public CreateForm()
        {
            InitializeComponent();
        }
        private void button_ganerate_Click(object sender, EventArgs e)
        {
            createTextBox();
            createCheckBox();
        }
        public void createTextBox()
        {
            if (freeTextAtribute == 0)
            {
                this.freeTextAtribute = int.Parse(textBox_FreeText.Text);
                int pointX = 25;
                int pointY = 50;
                panelCreateForm.Controls.Clear();
                for (int i = 0; i < freeTextAtribute + 1; i++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Name = "yes" + i.ToString();
                    if (i == 0)
                    {
                        textBox.Name = "form name";
                        textBox.Text = "form name " + (i + 1).ToString();
                    }
                    else
                    { 
                    textBox.Text = "filld name " + (i + 1).ToString(); }
                    textBox.Location = new Point(pointX, pointY);
                    panelCreateForm.Controls.Add(textBox);
                    panelCreateForm.Show();
                    pointY = pointY + 25;
                }
                this.Size = new Size(this.Size.Width, this.Size.Height + freeTextAtribute * 5);
                panelCreateForm.Size = new Size(this.Size.Width, this.Size.Height + (freeTextAtribute - 2) * 20);
                Label instructions = new Label();
                instructions.AutoSize = true;
                instructions.Text = "fill the questions ";
                panelCreateForm.Controls.Add(instructions);
                instructions.Location = new Point(pointX, 10);
            }
        }
        public void createCheckBox()
        {
            if (boolAribute == 0)
            {
                this.boolAribute = int.Parse(textBox_boolean.Text);
                int pointX = 250;
                int pointY = 50;
                for (int i = 0; i < boolAribute ; i++)
                {
                    TextBox textBox = new TextBox();
                    CheckBox checkbox = new CheckBox();
                    checkbox.Name = "call Name" + i.ToString();
                    textBox.Text = "field name " + i.ToString();
                    textBox.Name = "no" + i.ToString();
                    textBox.Location = new Point(pointX, pointY);
                    checkbox.Location = new Point(pointX + 110, pointY);
                    panelCreateForm.Controls.Add(checkbox);
                    panelCreateForm.Controls.Add(textBox);
                    pointY = pointY + 25;
                }
                this.Size = new Size(this.Size.Width, this.Size.Height + freeTextAtribute * 5);
                panelCreateForm.Size = new Size(this.Size.Width, this.Size.Height + (freeTextAtribute - 2) * 20);
                //create label and show
                Label CheckBoxinstructions = new Label();
                CheckBoxinstructions.AutoSize = true;
                CheckBoxinstructions.Text = "file the questions of the checkBox";
                panelCreateForm.Controls.Add(CheckBoxinstructions);
                CheckBoxinstructions.Location = new Point(pointX, 10);
                //create button who ganerate the table
                Button buttonCreateTable = new Button();
                buttonCreateTable.Text = "create";
                button_ganerate.Hide();
                buttonCreateTable.Location = new Point(pointX, pointY);
                //set button action
                buttonCreateTable.Click += (sender, args) =>
                {
                    createForm();
                };
                panelCreateForm.Controls.Add(buttonCreateTable);
                panelCreateForm.Show();
            }
        }
        private void createForm()
        {
            SQL_CON sc = new SQL_CON();
            SqlCommand scc = new SqlCommand();
            string insertToFormList = "INSERT INTO [dbo].[formList]([formName])VALUES('";
            string formName = "";
            MyForm form = new MyForm();
            // create and set form 
            foreach (Control c in panelCreateForm.Controls)
            {
                if (c is TextBox || c is RichTextBox)
                {
                    if (c.Name == "form name")
                    {
                        formName = c.Text;
                        insertToFormList = insertToFormList + formName + "')";
                        scc.CommandText = insertToFormList;
                        form.formName = formName;
                        if (!Program.findForm(formName))
                        {
                            sc.execute_non_query(scc);
                            Program.forms.Add(form);
                        }
                    }
                }
            }
            //create and set query
            foreach (Control c in panelCreateForm.Controls)
            {
                string insertToQuery = "INSERT INTO [dbo].[query]([queryType],[queryName]) VALUES(";
                if (c is TextBox || c is RichTextBox)
                {

                    if (c.Name.Substring(0, 3).Equals("yes"))
                    {
                        insertToQuery = insertToQuery + "'TextBox','" + c.Text + "')";
                        Query query = new Query("TextBox", c.Text);
                        //if (!Program.findQueries("TextBox", c.Text))
                        {
                            scc.CommandText = insertToQuery;
                            sc.execute_non_query(scc);
                        }
                        query.setForm(form);
                        form.insertQuery(query);
                    }
                    if (c.Name.Substring(0, 2).Equals("no"))
                    {
                        insertToQuery = insertToQuery + "'CheckBox','" + c.Text + "')";
                        Query query = new Query("CheckBox", c.Text);
                        if (!Program.findQueries(c.Text, "CheckBox"))
                        {
                            scc.CommandText = insertToQuery;
                            sc.execute_non_query(scc);
                        }
                        query.setForm(form);
                        form.insertQuery(query);
                    }

                }

            }
            form.insertToFormQuere();
            printForm(form);
        }
        private void textBox_FreeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBox_boolean_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
    }
}
