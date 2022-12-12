using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scouts
{
    public partial class openDelegationUX : UserControl
    {
        public openDelegationUX()
        {
            InitializeComponent();
        }

        #region Properties

        private Color _iconBack;
        private string _title;
        private string _message;
        private Image _icon;
        private Delegation del;


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lable_delname.Text = value; }
        }

        [Category("Custom Props")]
        public Color IconBackground
        {
            get { return _iconBack; }
            set { _iconBack = value; panel1.BackColor = value; }
        }


        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lable_delinfo.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }


        [Category("Custom Props")]
        public Delegation delegation
        {
            get { return del; }
            set { del = value; }
        }
        #endregion

        private void openDelegationUX_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void openDelegationUX_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (!Program.activUser.isCoordinator(Program.activUser))
            {
                Form_SignUpDelegation s = new Form_SignUpDelegation(this.delegation);
                s.ShowDialog();
            }
            else MessageBox.Show("Only campers can register to a delegation");
        }
    }
}
