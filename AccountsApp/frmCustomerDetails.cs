using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class frmCustomerDetails : Form
    {
        public frmCustomerDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for Customer form
        /// </summary>
        /// <param name="strMode">Add='Add customer details', Update='Update Customer Details', Address='Add/Update Address Detials'</param>
        public frmCustomerDetails(string strMode)
        {
            InitializeComponent();
            switch(strMode)
            {
                case "Add":
                    pnlAddCustomerDetails.Visible = true;
                    pnlAddCustomerDetails.Location = new Point(10, 10);
                    break;

                case "Update":
                    pnlEditCustomerDetails.Visible = true;
                    pnlEditCustomerDetails.Location = new Point(10, 10);
                    break;

                case "Address":
                    pnlEditAddress.Visible = true;
                    pnlEditAddress.Location = new Point(10, 10);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void btnEditClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void btnAddressClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }
    }
}
