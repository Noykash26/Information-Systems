using scouts.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace scouts
{
    public partial class openDelegations : Form
    {
        public openDelegations()
        {
            InitializeComponent();
        }


        private void populateItems()
        {
            //populate it here
            openDelegationUX [] listItems = new openDelegationUX [Program.delegations.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                if (Program.delegations[i].freeSpace() != 0)//משלחות שאין מקום לא יוצגו
                {
                    listItems[i] = new openDelegationUX();
                    listItems[i].Width = flowLayoutPanel1.Width;
                    listItems[i].Icon = Resources.output_onlinepngtools__2_;
                    listItems[i].IconBackground = Color.Silver;
                    listItems[i].Title = Program.delegations[i].name_;
                    listItems[i].Message = Program.delegations[i].getDescription();
                    listItems[i].delegation = Program.delegations[i];

                    //add to flowlayout
                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();
                    }
                    else
                        flowLayoutPanel1.Controls.Add(listItems[i]);
                }
            }
        }

        private void openDelegations_Load(object sender, EventArgs e)
        {
            populateItems();
            
        }

    }
}
