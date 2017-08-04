﻿using System;
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

        private void btnAddItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
