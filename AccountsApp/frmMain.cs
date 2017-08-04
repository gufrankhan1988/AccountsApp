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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is used to see if a form is already open or not
        /// </summary>
        /// <param name="strFormName">Form Name</param>
        /// <returns>return true if form is already open</returns>
        private bool frmFound(string strFormName)
        {
            FormCollection fc = Application.OpenForms;
            bool blnFormFound = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == strFormName)
                {
                    frm.Focus();
                    blnFormFound = true;
                }
            }
            return blnFormFound;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call frmFound and check if customer form is already open, if not then open
            if (!frmFound("frmAddCustomer"))
            {
                frmCustomerDetails objAddCustomer = new frmCustomerDetails("Add");
                objAddCustomer.MdiParent = frmMain.ActiveForm;
                objAddCustomer.WindowState = FormWindowState.Maximized;
                objAddCustomer.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call frmFound and check if customer form is already open, if not then open
            if (!frmFound("frmAddCustomer"))
            {
                frmCustomerDetails objAddCustomer = new frmCustomerDetails("Update");
                objAddCustomer.MdiParent = frmMain.ActiveForm;
                objAddCustomer.WindowState = FormWindowState.Maximized;
                objAddCustomer.Show();
            }
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call frmFound and check if customer form is already open, if not then open
            if (!frmFound("frmCustomerDetails"))
            {
                frmCustomerDetails objAddCustomer = new frmCustomerDetails("Address");
                objAddCustomer.MdiParent = frmMain.ActiveForm;
                objAddCustomer.WindowState = FormWindowState.Maximized;
                objAddCustomer.Show();
            }
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call frmFound and check if items form is already open, if not then open
            if (!frmFound("frmItemDetails"))
            {
                frmItemDetails objItems = new frmItemDetails("Add");
                objItems.MdiParent = frmMain.ActiveForm;
                objItems.WindowState = FormWindowState.Maximized;
                objItems.Show();
            }
        }

        private void updateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call frmFound and check if items form is already open, if not then open
            if (!frmFound("frmItemDetails"))
            {
                frmItemDetails objItems = new frmItemDetails("Update");
                objItems.MdiParent = frmMain.ActiveForm;
                objItems.WindowState = FormWindowState.Maximized;
                objItems.Show();
            }
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call frmSale and check if items form is already open, if not then open
            if (!frmFound("frmSale"))
            {
                frmSale objSale = new frmSale();
                objSale.MdiParent = frmMain.ActiveForm;
                objSale.WindowState = FormWindowState.Maximized;
                objSale.Show();
            }
        }
    }
}
