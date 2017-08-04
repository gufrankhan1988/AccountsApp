namespace AccountsApp
{
    partial class frmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddCustomerDetails = new System.Windows.Forms.Panel();
            this.txtInoiceDate = new System.Windows.Forms.TextBox();
            this.lblInoiceDate = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.cboEditCustName = new System.Windows.Forms.ComboBox();
            this.txtAddCustEmail = new System.Windows.Forms.TextBox();
            this.txtAddCustMobile = new System.Windows.Forms.TextBox();
            this.txtAddCustGSTNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblGSTIN = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlAddItemDetails = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.txtAddItemCode = new System.Windows.Forms.TextBox();
            this.txtAddItemDetails = new System.Windows.Forms.TextBox();
            this.lblAddItemCode = new System.Windows.Forms.Label();
            this.lblAddItemDescription = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splAddAddressDetails = new System.Windows.Forms.SplitContainer();
            this.cboAddAddressType = new System.Windows.Forms.ComboBox();
            this.lblBilledTo = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtAddCountry = new System.Windows.Forms.TextBox();
            this.txtAddZipCode = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtAddAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtAddCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblShippedTo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSNCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlAddCustomerDetails.SuspendLayout();
            this.pnlAddItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splAddAddressDetails)).BeginInit();
            this.splAddAddressDetails.Panel1.SuspendLayout();
            this.splAddAddressDetails.Panel2.SuspendLayout();
            this.splAddAddressDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddCustomerDetails
            // 
            this.pnlAddCustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddCustomerDetails.Controls.Add(this.txtInoiceDate);
            this.pnlAddCustomerDetails.Controls.Add(this.lblInoiceDate);
            this.pnlAddCustomerDetails.Controls.Add(this.txtInvoiceNumber);
            this.pnlAddCustomerDetails.Controls.Add(this.lblInvoiceNumber);
            this.pnlAddCustomerDetails.Controls.Add(this.cboEditCustName);
            this.pnlAddCustomerDetails.Controls.Add(this.txtAddCustEmail);
            this.pnlAddCustomerDetails.Controls.Add(this.txtAddCustMobile);
            this.pnlAddCustomerDetails.Controls.Add(this.txtAddCustGSTNo);
            this.pnlAddCustomerDetails.Controls.Add(this.lblEmail);
            this.pnlAddCustomerDetails.Controls.Add(this.lblMobile);
            this.pnlAddCustomerDetails.Controls.Add(this.lblGSTIN);
            this.pnlAddCustomerDetails.Controls.Add(this.lblName);
            this.pnlAddCustomerDetails.Location = new System.Drawing.Point(26, 24);
            this.pnlAddCustomerDetails.Name = "pnlAddCustomerDetails";
            this.pnlAddCustomerDetails.Size = new System.Drawing.Size(1200, 95);
            this.pnlAddCustomerDetails.TabIndex = 24;
            // 
            // txtInoiceDate
            // 
            this.txtInoiceDate.Enabled = false;
            this.txtInoiceDate.Location = new System.Drawing.Point(964, 13);
            this.txtInoiceDate.Name = "txtInoiceDate";
            this.txtInoiceDate.Size = new System.Drawing.Size(195, 26);
            this.txtInoiceDate.TabIndex = 33;
            // 
            // lblInoiceDate
            // 
            this.lblInoiceDate.AutoSize = true;
            this.lblInoiceDate.Location = new System.Drawing.Point(856, 16);
            this.lblInoiceDate.Name = "lblInoiceDate";
            this.lblInoiceDate.Size = new System.Drawing.Size(98, 20);
            this.lblInoiceDate.TabIndex = 32;
            this.lblInoiceDate.Text = "Invoice Date";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Enabled = false;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(627, 13);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(195, 26);
            this.txtInvoiceNumber.TabIndex = 30;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(519, 16);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(87, 20);
            this.lblInvoiceNumber.TabIndex = 29;
            this.lblInvoiceNumber.Text = "Invoice No.";
            // 
            // cboEditCustName
            // 
            this.cboEditCustName.FormattingEnabled = true;
            this.cboEditCustName.Location = new System.Drawing.Point(168, 12);
            this.cboEditCustName.Name = "cboEditCustName";
            this.cboEditCustName.Size = new System.Drawing.Size(314, 28);
            this.cboEditCustName.TabIndex = 28;
            // 
            // txtAddCustEmail
            // 
            this.txtAddCustEmail.Enabled = false;
            this.txtAddCustEmail.Location = new System.Drawing.Point(845, 52);
            this.txtAddCustEmail.Name = "txtAddCustEmail";
            this.txtAddCustEmail.Size = new System.Drawing.Size(314, 26);
            this.txtAddCustEmail.TabIndex = 16;
            // 
            // txtAddCustMobile
            // 
            this.txtAddCustMobile.Enabled = false;
            this.txtAddCustMobile.Location = new System.Drawing.Point(496, 52);
            this.txtAddCustMobile.Name = "txtAddCustMobile";
            this.txtAddCustMobile.Size = new System.Drawing.Size(195, 26);
            this.txtAddCustMobile.TabIndex = 15;
            // 
            // txtAddCustGSTNo
            // 
            this.txtAddCustGSTNo.Enabled = false;
            this.txtAddCustGSTNo.Location = new System.Drawing.Point(168, 52);
            this.txtAddCustGSTNo.Name = "txtAddCustGSTNo";
            this.txtAddCustGSTNo.Size = new System.Drawing.Size(195, 26);
            this.txtAddCustGSTNo.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(737, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(388, 55);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(83, 20);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "Mobile No.";
            // 
            // lblGSTIN
            // 
            this.lblGSTIN.AutoSize = true;
            this.lblGSTIN.Location = new System.Drawing.Point(35, 55);
            this.lblGSTIN.Name = "lblGSTIN";
            this.lblGSTIN.Size = new System.Drawing.Size(70, 20);
            this.lblGSTIN.TabIndex = 1;
            this.lblGSTIN.Text = "GST No.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // pnlAddItemDetails
            // 
            this.pnlAddItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddItemDetails.Controls.Add(this.btnExit);
            this.pnlAddItemDetails.Controls.Add(this.btnSavePrint);
            this.pnlAddItemDetails.Controls.Add(this.txtQuantity);
            this.pnlAddItemDetails.Controls.Add(this.lblQuantity);
            this.pnlAddItemDetails.Controls.Add(this.btnAddItem);
            this.pnlAddItemDetails.Controls.Add(this.cboItemName);
            this.pnlAddItemDetails.Controls.Add(this.txtAddItemCode);
            this.pnlAddItemDetails.Controls.Add(this.txtAddItemDetails);
            this.pnlAddItemDetails.Controls.Add(this.lblAddItemCode);
            this.pnlAddItemDetails.Controls.Add(this.lblAddItemDescription);
            this.pnlAddItemDetails.Controls.Add(this.label11);
            this.pnlAddItemDetails.Location = new System.Drawing.Point(26, 397);
            this.pnlAddItemDetails.Name = "pnlAddItemDetails";
            this.pnlAddItemDetails.Size = new System.Drawing.Size(1200, 96);
            this.pnlAddItemDetails.TabIndex = 27;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(790, 13);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(195, 26);
            this.txtQuantity.TabIndex = 30;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(698, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 29;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(784, 47);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(123, 36);
            this.btnAddItem.TabIndex = 28;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // cboItemName
            // 
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(132, 13);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(273, 28);
            this.cboItemName.TabIndex = 27;
            // 
            // txtAddItemCode
            // 
            this.txtAddItemCode.Enabled = false;
            this.txtAddItemCode.Location = new System.Drawing.Point(516, 13);
            this.txtAddItemCode.Name = "txtAddItemCode";
            this.txtAddItemCode.Size = new System.Drawing.Size(175, 26);
            this.txtAddItemCode.TabIndex = 15;
            // 
            // txtAddItemDetails
            // 
            this.txtAddItemDetails.Enabled = false;
            this.txtAddItemDetails.Location = new System.Drawing.Point(132, 58);
            this.txtAddItemDetails.Name = "txtAddItemDetails";
            this.txtAddItemDetails.Size = new System.Drawing.Size(559, 26);
            this.txtAddItemDetails.TabIndex = 14;
            // 
            // lblAddItemCode
            // 
            this.lblAddItemCode.AutoSize = true;
            this.lblAddItemCode.Location = new System.Drawing.Point(424, 17);
            this.lblAddItemCode.Name = "lblAddItemCode";
            this.lblAddItemCode.Size = new System.Drawing.Size(83, 20);
            this.lblAddItemCode.TabIndex = 3;
            this.lblAddItemCode.Text = "Item Code";
            // 
            // lblAddItemDescription
            // 
            this.lblAddItemDescription.AutoSize = true;
            this.lblAddItemDescription.Location = new System.Drawing.Point(35, 61);
            this.lblAddItemDescription.Name = "lblAddItemDescription";
            this.lblAddItemDescription.Size = new System.Drawing.Size(89, 20);
            this.lblAddItemDescription.TabIndex = 1;
            this.lblAddItemDescription.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name";
            // 
            // splAddAddressDetails
            // 
            this.splAddAddressDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splAddAddressDetails.Location = new System.Drawing.Point(26, 124);
            this.splAddAddressDetails.Name = "splAddAddressDetails";
            // 
            // splAddAddressDetails.Panel1
            // 
            this.splAddAddressDetails.Panel1.Controls.Add(this.cboAddAddressType);
            this.splAddAddressDetails.Panel1.Controls.Add(this.lblBilledTo);
            this.splAddAddressDetails.Panel1.Controls.Add(this.txtState);
            this.splAddAddressDetails.Panel1.Controls.Add(this.txtAddCountry);
            this.splAddAddressDetails.Panel1.Controls.Add(this.txtAddZipCode);
            this.splAddAddressDetails.Panel1.Controls.Add(this.lblCountry);
            this.splAddAddressDetails.Panel1.Controls.Add(this.lblState);
            this.splAddAddressDetails.Panel1.Controls.Add(this.lblZipCode);
            this.splAddAddressDetails.Panel1.Controls.Add(this.txtAddAddressLine1);
            this.splAddAddressDetails.Panel1.Controls.Add(this.txtAddAddressLine2);
            this.splAddAddressDetails.Panel1.Controls.Add(this.txtAddCity);
            this.splAddAddressDetails.Panel1.Controls.Add(this.lblCity);
            this.splAddAddressDetails.Panel1.Controls.Add(this.lblAddressLine2);
            this.splAddAddressDetails.Panel1.Controls.Add(this.lblAddressLine1);
            // 
            // splAddAddressDetails.Panel2
            // 
            this.splAddAddressDetails.Panel2.Controls.Add(this.comboBox1);
            this.splAddAddressDetails.Panel2.Controls.Add(this.lblShippedTo);
            this.splAddAddressDetails.Panel2.Controls.Add(this.textBox1);
            this.splAddAddressDetails.Panel2.Controls.Add(this.textBox2);
            this.splAddAddressDetails.Panel2.Controls.Add(this.textBox3);
            this.splAddAddressDetails.Panel2.Controls.Add(this.label2);
            this.splAddAddressDetails.Panel2.Controls.Add(this.label3);
            this.splAddAddressDetails.Panel2.Controls.Add(this.label4);
            this.splAddAddressDetails.Panel2.Controls.Add(this.textBox4);
            this.splAddAddressDetails.Panel2.Controls.Add(this.textBox5);
            this.splAddAddressDetails.Panel2.Controls.Add(this.textBox6);
            this.splAddAddressDetails.Panel2.Controls.Add(this.label5);
            this.splAddAddressDetails.Panel2.Controls.Add(this.label6);
            this.splAddAddressDetails.Panel2.Controls.Add(this.label7);
            this.splAddAddressDetails.Size = new System.Drawing.Size(1200, 268);
            this.splAddAddressDetails.SplitterDistance = 600;
            this.splAddAddressDetails.TabIndex = 29;
            // 
            // cboAddAddressType
            // 
            this.cboAddAddressType.FormattingEnabled = true;
            this.cboAddAddressType.Items.AddRange(new object[] {
            "Office",
            "Godown",
            "Factory"});
            this.cboAddAddressType.Location = new System.Drawing.Point(210, 23);
            this.cboAddAddressType.Name = "cboAddAddressType";
            this.cboAddAddressType.Size = new System.Drawing.Size(195, 28);
            this.cboAddAddressType.TabIndex = 53;
            // 
            // lblBilledTo
            // 
            this.lblBilledTo.AutoSize = true;
            this.lblBilledTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilledTo.Location = new System.Drawing.Point(77, 27);
            this.lblBilledTo.Name = "lblBilledTo";
            this.lblBilledTo.Size = new System.Drawing.Size(78, 20);
            this.lblBilledTo.TabIndex = 52;
            this.lblBilledTo.Text = "Billed To";
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(210, 185);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(314, 26);
            this.txtState.TabIndex = 51;
            // 
            // txtAddCountry
            // 
            this.txtAddCountry.Enabled = false;
            this.txtAddCountry.Location = new System.Drawing.Point(210, 217);
            this.txtAddCountry.Name = "txtAddCountry";
            this.txtAddCountry.Size = new System.Drawing.Size(195, 26);
            this.txtAddCountry.TabIndex = 50;
            // 
            // txtAddZipCode
            // 
            this.txtAddZipCode.Enabled = false;
            this.txtAddZipCode.Location = new System.Drawing.Point(210, 153);
            this.txtAddZipCode.Name = "txtAddZipCode";
            this.txtAddZipCode.Size = new System.Drawing.Size(195, 26);
            this.txtAddZipCode.TabIndex = 49;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(77, 225);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(64, 20);
            this.lblCountry.TabIndex = 48;
            this.lblCountry.Text = "Country";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(77, 192);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 20);
            this.lblState.TabIndex = 47;
            this.lblState.Text = "State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(77, 159);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(73, 20);
            this.lblZipCode.TabIndex = 46;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtAddAddressLine1
            // 
            this.txtAddAddressLine1.Enabled = false;
            this.txtAddAddressLine1.Location = new System.Drawing.Point(210, 57);
            this.txtAddAddressLine1.Name = "txtAddAddressLine1";
            this.txtAddAddressLine1.Size = new System.Drawing.Size(314, 26);
            this.txtAddAddressLine1.TabIndex = 45;
            // 
            // txtAddAddressLine2
            // 
            this.txtAddAddressLine2.Enabled = false;
            this.txtAddAddressLine2.Location = new System.Drawing.Point(210, 89);
            this.txtAddAddressLine2.Name = "txtAddAddressLine2";
            this.txtAddAddressLine2.Size = new System.Drawing.Size(314, 26);
            this.txtAddAddressLine2.TabIndex = 44;
            // 
            // txtAddCity
            // 
            this.txtAddCity.Enabled = false;
            this.txtAddCity.Location = new System.Drawing.Point(210, 121);
            this.txtAddCity.Name = "txtAddCity";
            this.txtAddCity.Size = new System.Drawing.Size(195, 26);
            this.txtAddCity.TabIndex = 43;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(77, 126);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 20);
            this.lblCity.TabIndex = 42;
            this.lblCity.Text = "City";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(77, 93);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine2.TabIndex = 41;
            this.lblAddressLine2.Text = "Address Line 2";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(77, 60);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(115, 20);
            this.lblAddressLine1.TabIndex = 40;
            this.lblAddressLine1.Text = "Address Line 1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Office",
            "Godown",
            "Factory"});
            this.comboBox1.Location = new System.Drawing.Point(208, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 28);
            this.comboBox1.TabIndex = 67;
            // 
            // lblShippedTo
            // 
            this.lblShippedTo.AutoSize = true;
            this.lblShippedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippedTo.Location = new System.Drawing.Point(75, 27);
            this.lblShippedTo.Name = "lblShippedTo";
            this.lblShippedTo.Size = new System.Drawing.Size(100, 20);
            this.lblShippedTo.TabIndex = 66;
            this.lblShippedTo.Text = "Shipped To";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(208, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 26);
            this.textBox1.TabIndex = 65;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(208, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 26);
            this.textBox2.TabIndex = 64;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(208, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 26);
            this.textBox3.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Zip Code";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(208, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(314, 26);
            this.textBox4.TabIndex = 59;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(208, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(314, 26);
            this.textBox5.TabIndex = 58;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(208, 121);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(195, 26);
            this.textBox6.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Address Line 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Address Line 1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.ItemDescription,
            this.HSNCode,
            this.Quantity,
            this.Rate,
            this.SGST,
            this.CGST,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(26, 502);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 250);
            this.dataGridView1.TabIndex = 30;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Description";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // HSNCode
            // 
            this.HSNCode.HeaderText = "HSN Code";
            this.HSNCode.Name = "HSNCode";
            this.HSNCode.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST";
            this.SGST.Name = "SGST";
            this.SGST.ReadOnly = true;
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST";
            this.CGST.Name = "CGST";
            this.CGST.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(1008, 9);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(151, 36);
            this.btnSavePrint.TabIndex = 31;
            this.btnSavePrint.Text = "Save && Print";
            this.btnSavePrint.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1008, 50);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 36);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 762);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splAddAddressDetails);
            this.Controls.Add(this.pnlAddItemDetails);
            this.Controls.Add(this.pnlAddCustomerDetails);
            this.Name = "frmSale";
            this.Text = "Sale";
            this.pnlAddCustomerDetails.ResumeLayout(false);
            this.pnlAddCustomerDetails.PerformLayout();
            this.pnlAddItemDetails.ResumeLayout(false);
            this.pnlAddItemDetails.PerformLayout();
            this.splAddAddressDetails.Panel1.ResumeLayout(false);
            this.splAddAddressDetails.Panel1.PerformLayout();
            this.splAddAddressDetails.Panel2.ResumeLayout(false);
            this.splAddAddressDetails.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splAddAddressDetails)).EndInit();
            this.splAddAddressDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddCustomerDetails;
        private System.Windows.Forms.TextBox txtAddCustEmail;
        private System.Windows.Forms.TextBox txtAddCustMobile;
        private System.Windows.Forms.TextBox txtAddCustGSTNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblGSTIN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboEditCustName;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Panel pnlAddItemDetails;
        private System.Windows.Forms.TextBox txtAddItemCode;
        private System.Windows.Forms.TextBox txtAddItemDetails;
        private System.Windows.Forms.Label lblAddItemCode;
        private System.Windows.Forms.Label lblAddItemDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInoiceDate;
        private System.Windows.Forms.Label lblInoiceDate;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.SplitContainer splAddAddressDetails;
        private System.Windows.Forms.ComboBox cboAddAddressType;
        private System.Windows.Forms.Label lblBilledTo;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtAddCountry;
        private System.Windows.Forms.TextBox txtAddZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtAddAddressLine1;
        private System.Windows.Forms.TextBox txtAddAddressLine2;
        private System.Windows.Forms.TextBox txtAddCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblShippedTo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSNCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSavePrint;
    }
}