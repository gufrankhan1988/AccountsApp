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
    public partial class frmItemDetails : Form
    {
        public frmItemDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for ItemDetails form
        /// </summary>
        /// <param name="strMode">Add='Add item details', Update='Update item details'</param>
        public frmItemDetails(string strMode)
        {
            InitializeComponent();
            switch (strMode)
            {
                case "Add":
                    pnlAddItemDetails.Visible = true;
                    pnlAddItemDetails.Location = new Point(10, 10);
                    break;

                case "Update":
                    pnlEditItemDetails.Visible = true;
                    pnlEditItemDetails.Location = new Point(10, 10);
                    break;
            }
        }

        private bool ValidateFields()
        {
            if (txtAddItemName.Text == String.Empty)
            {
                MessageBox.Show("Please enter Item Name", "No Item Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtAddItemCode.Text == String.Empty)
            {
                MessageBox.Show("Please enter Item Code", "Item Code Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void btnAddItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFields())
                {
                    //Call Save method.
                    MessageBox.Show("OK");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Item Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { }
        }
    }
}
