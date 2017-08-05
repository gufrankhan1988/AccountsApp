using BusinessLayer;
using Entities;
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
    public partial class frmAddFirm : Form
    {
        private IBLFacade objFirmDetails;

        public frmAddFirm()
        {
            InitializeComponent();
        }

        public frmAddFirm(string strMode)
        {
            InitializeComponent();
            objFirmDetails = new BLFacade();
            switch (strMode)
            {
                case "Add":
                    //pnlAddCustomerDetails.Visible = true;
                    //pnlAddCustomerDetails.Location = new Point(10, 10);
                    break;

                case "Update":
                    //pnlEditCustomerDetails.Visible = true;
                    //pnlEditCustomerDetails.Location = new Point(10, 10);
                    break;
            }
        }

        private void ClearFields()
        {
            txtFirmEmail.Text = String.Empty;
            txtFirmGSTNo.Text = String.Empty;
            txtFirmMobile.Text = String.Empty;
            txtFirmName.Text = String.Empty;
            txtOfficeAddressLine1.Text = String.Empty;
            txtOfficeAddressLine2.Text = String.Empty;
            txtOfficeCity.Text = String.Empty;
            txtOfficeZipCode.Text = String.Empty;
            txtOtherAddressLine1.Text = String.Empty;
            txtOtherAddressLine2.Text = String.Empty;
            txtOtherCity.Text = String.Empty;
            txtOtherZipCode.Text = String.Empty;
            txtShippingAddressLine1.Text = String.Empty;
            txtShippingAddressLine2.Text = String.Empty;
            txtShippingCity.Text = String.Empty;
            txtShippingZipCode.Text = String.Empty;

            chkOfficeAddress.Checked = true;
            chkOtherAddress.Checked = true;
            chkShippingAddress.Checked = true;
        }

        private bool ValidateFirmDetailFields()
        {
            if (txtFirmName.Text == String.Empty)
            {
                MessageBox.Show("Please enter Firm Name", "Firm Name Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtFirmMobile.Text == String.Empty)
            {
                MessageBox.Show("Please enter Firm Mobile", "Firm Mobile Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtFirmGSTNo.Text == String.Empty)
            {
                MessageBox.Show("Please enter Firm GST No.", "Firm GST No. Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (chkOfficeAddress.Checked == false && chkOtherAddress.Checked == false && chkShippingAddress.Checked == false)
            {
                MessageBox.Show("Please enter at least one address", "No Firm Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //check the address
            else
                return true;
        }

        private bool ValidateFirmAddressFields()
        {
            bool blnShipping = false;
            bool blnOffice = false;
            bool blnOther = false;

            if (chkShippingAddress.Checked)
            {
                if (txtShippingAddressLine1.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Address Line 1 for Shipping.", "Address Line 1 Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnShipping = false;
                }
                else if (txtShippingCity.Text == String.Empty)
                {
                    MessageBox.Show("Please enter City for Shipping.", "City Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnShipping = false;
                }
                else if (txtShippingZipCode.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Zip Code for Shipping.", "Zip Code Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnShipping = false;
                }
                else
                    blnShipping = true;
            }

            if (chkOfficeAddress.Checked)
            {
                if (txtOfficeAddressLine1.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Address Line 1 for Office.", "Address Line 1 Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnOffice = false;
                }
                else if (txtOfficeCity.Text == String.Empty)
                {
                    MessageBox.Show("Please enter City for Office.", "City Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnOffice = false;
                }
                else if (txtOfficeZipCode.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Zip Code for Office.", "Zip Code Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnOffice = false;
                }
                else
                    blnOffice = true;
            }

            if (chkOtherAddress.Checked)
            {
                if (txtOtherAddressLine1.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Address Line 1 for Other.", "Address Line 1 Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnOther = false;
                }
                else if (txtOtherCity.Text == String.Empty)
                {
                    MessageBox.Show("Please enter City for Other.", "City Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnOther = false;
                }
                else if (txtOtherZipCode.Text == String.Empty)
                {
                    MessageBox.Show("Please enter Zip Code for Other.", "Zip Code Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blnOther = false;
                }
                else
                    blnOther = true;
            }

            if (blnShipping && blnOther && blnOffice)
                return true;
            else
                return false;
        }

        private void CreateFirmObject()
        {
            FirmDetails firmdetails = new FirmDetails();
            firmdetails.firmName = txtFirmName.Text;
            firmdetails.address = new List<Address>();
            Address add = new Address();
            add.addressLine1 = "abc";
            firmdetails.address.Add(add);
            objFirmDetails.SaveFirm(firmdetails);
        }

        private void chkOfficeAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOfficeAddress.Checked)
                pnlOfficeAddress.Visible = true;
            else
                pnlOfficeAddress.Visible = false;
        }

        private void chkShippingAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShippingAddress.Checked)
                pnlShippingAddress.Visible = true;
            else
                pnlShippingAddress.Visible = false;
        }

        private void chkOtherAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOtherAddress.Checked)
                pnlOtherAddress.Visible = true;
            else
                pnlOtherAddress.Visible = false;
        }

        private void btnAddFirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFirmDetailFields())
                {
                    if (ValidateFirmAddressFields())
                    {
                        CreateFirmObject();
                        //Call Save method.
                        MessageBox.Show("OK");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Firm details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
        }

        private void btnAddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
