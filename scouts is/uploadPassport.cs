using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scouts
{
    public partial class uploadPassport : Form
    {

        #region Variables
        int ImageID = 0;
        string strFilepath = "";
        Image DefultImage;
        byte[] ImageByteArray;
        SqlConnection sqlcon; //= new SqlConnection("Data Source=DESKTOP-QAJP2LK\\SQLNAME;Initial Catalog=master;Integrated Security=True");
        #endregion

        #region Methods
        public uploadPassport()
        {
            SQL_CON s = new SQL_CON();
            sqlcon = s.returnConnection();
            InitializeComponent();
            DefultImage = pbxImage.Image; //picturebox
            RefreshImageGrid();

        }

        void RefreshImageGrid()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("ImageViewAll", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbImages = new DataTable();
            sqlda.Fill(dtbImages);
            dgvImages.DataSource = dtbImages;//לדעתי זה גריד
            dgvImages.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImages.Columns[2].Visible = false;

        }

        void Clear()//fill
        {
            ImageID = 0;
            txtTitle.Clear();
            pbxImage.Image = DefultImage;
            strFilepath = "";
            btnSave.Text = "save";
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog o = new OpenFileDialog() { Filter = "JPEG|*.jpg", Multiselect = false })
            //{
            //    if (o.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox1.Image = Image.FromFile(o.FileName);

            //    }
            //}
        }

     
        private void button_save_Click(object sender, EventArgs e)
        {
            
              //SqlCommand c = new SqlCommand("insert into dbo.picture(photo) values( @photo)",conn);
              //conn = new SqlConnection("Data Source=DESKTOP-QAJP2LK\\SQLNAME;Initial Catalog=tempdb;Integrated Security=True");


        }
       
        #region Events
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strFilepath = ofd.FileName;
                pbxImage.Image = new Bitmap(strFilepath);
                if (txtTitle.Text.Trim().Length == 0)
                    txtTitle.Text = System.IO.Path.GetFileName(strFilepath);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text.Trim() != "")
            {
                if(strFilepath == "")
                {
                    if (ImageByteArray.Length != 0)
                        ImageByteArray = new byte[] { };
                }
                else
                {
                    Image temp = new Bitmap(strFilepath);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByteArray = strm.ToArray();

                }
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("ImageAddOrEdit", sqlcon) { CommandType = CommandType.StoredProcedure };
                sqlcmd.Parameters.Add("@ImageID", ImageID);
                sqlcmd.Parameters.Add("@Title", txtTitle.Text.Trim());
                sqlcmd.Parameters.Add("@Image", ImageByteArray);
                sqlcmd.Parameters.Add("@Email", Program.activUser.Email_);
                sqlcmd.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("Saved successfuly");
                Clear();
                RefreshImageGrid();
            }
            else
            {
                MessageBox.Show("Please enter image title");
            }
        }

        private void dgvImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvImages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTitle.Text = dgvImages.CurrentRow.Cells[1].Value.ToString();
            byte [] ImageArray = (byte[]) dgvImages.CurrentRow.Cells[2].Value;
            if (ImageArray.Length == 0)
                pbxImage.Image = DefultImage;
            else
            {
                ImageByteArray = ImageArray;
                pbxImage.Image = Image.FromStream(new MemoryStream(ImageArray));
            }
            ImageID = Convert.ToInt32(dgvImages.CurrentRow.Cells[0].Value);
            btnSave.Text = "Update";
        }
#endregion
    }
}

