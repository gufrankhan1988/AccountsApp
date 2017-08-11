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

        private bool ValidateFirmShippingAddressFields()
        {
            bool blnShipping = false;
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
            else
                blnShipping = true;

            return blnShipping;
        }

        private bool ValidateFirmOfficeAddressFields()
        {
            bool blnOffice = false;

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
            else
                blnOffice = true;

            return blnOffice;
        }

        private bool ValidateFirmOtherAddressFields()
        {
            bool blnOther = false;

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
            else
                blnOther = true;

            return blnOther;
        }

        private void CreateFirmObject()
        {
            FirmDetails firmdetails = new FirmDetails();
            ContactNumber cntNoFirm = new ContactNumber();
            FirmType fType = new FirmType();

            cntNoFirm.contactNumber = txtFirmMobile.Text.Trim();
            firmdetails.firmName = txtFirmName.Text.Trim();
            firmdetails.contactNumber = cntNoFirm;

            fType.FirmCategory = "Testing";
            firmdetails.firmtype = fType;

            firmdetails.GSTNumber = txtFirmGSTNo.Text.Trim();

            firmdetails.address = CreateAddresses();
            //where are use of registratin details.

            //Address add = CreateAddresses();
            //add.addressLine1 = txtof
            //firmdetails.address.Add(add);
            objFirmDetails.SaveFirm(firmdetails);
        }

        private List<Address> CreateAddresses()
        {
            List<Address> firmAddresses = new List<Address>();

            if (chkOfficeAddress.Checked)
            {
                Address addrOffice = new Address();
                ContactNumber addrcontNumber = new ContactNumber();
                AddressType addType = new AddressType();

                //add address details
                addrOffice.addressLine1 = txtOfficeAddressLine1.Text.Trim();
                addrOffice.addressLine2 = txtOfficeAddressLine2.Text.Trim();
                addType.addressType = "Office";
                addrOffice.addressType = addType;
                addrOffice.city = txtOfficeCity.Text.Trim();
                addrOffice.country = txtOfficeCountry.Text.Trim();

                //add contact details
                addrcontNumber.contactNumber = txtOfficeContactNo.Text.Trim();
                addrOffice.adressContactNumber.Add(addrcontNumber);

                //add to address return list
                firmAddresses.Add(addrOffice);
            }

            if (chkOtherAddress.Checked)
            {
                Address addrOther = new Address();
                ContactNumber addrcontNumber = new ContactNumber();
                AddressType addType = new AddressType();

                //add address details
                addrOther.addressLine1 = txtOtherAddressLine1.Text.Trim();
                addrOther.addressLine2 = txtOtherAddressLine2.Text.Trim();
                addType.addressType = "Other";
                addrOther.addressType = addType;
                addrOther.city = txtOtherCity.Text.Trim();
                addrOther.country = txtOtherCountry.Text.Trim();

                //add contact details
                addrcontNumber.contactNumber = txtOtherContactNo.Text.Trim();
                addrOther.adressContactNumber.Add(addrcontNumber);

                //add to address return list
                firmAddresses.Add(addrOther);
            }

            if (chkShippingAddress.Checked)
            {
                Address addrShipping = new Address();
                ContactNumber addrcontNumber = new ContactNumber();
                AddressType addType = new AddressType();

                //add address details
                addrShipping.addressLine1 = txtShippingAddressLine1.Text.Trim();
                addrShipping.addressLine2 = txtShippingAddressLine2.Text.Trim();
                addType.addressType = "Shipping";
                addrShipping.addressType = addType;
                addrShipping.city = txtShippingCity.Text.Trim();
                addrShipping.country = txtShippingCountry.Text.Trim();

                //add contact details
                addrcontNumber.contactNumber = txtShippingContactNo.Text.Trim();
                addrShipping.adressContactNumber.Add(addrcontNumber);

                //add to address return list
                firmAddresses.Add(addrShipping);
            }

            return firmAddresses;
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
                    if (ValidateFirmOfficeAddressFields() && ValidateFirmShippingAddressFields() && ValidateFirmOtherAddressFields())
                    {
                        CreateFirmObject();
                        //Call Save method.
                        MessageBox.Show("Firm added successfully.", "Add Firm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // here might be message for firm details errors. 
                // here might be message for address details errors.
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
