namespace AccountsApp
{
    partial class frmItemDetails
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
            this.pnlAddItemDetails = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddItemClose = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtAddItemCode = new System.Windows.Forms.TextBox();
            this.txtAddItemDetails = new System.Windows.Forms.TextBox();
            this.txtAddItemName = new System.Windows.Forms.TextBox();
            this.lblAddItemCode = new System.Windows.Forms.Label();
            this.lblAddItemDescription = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlEditItemDetails = new System.Windows.Forms.Panel();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditItemClose = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.txtEditItemCode = new System.Windows.Forms.TextBox();
            this.txtEditItemDetails = new System.Windows.Forms.TextBox();
            this.txtEditItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAddItemDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlEditItemDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddItemDetails
            // 
            this.pnlAddItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddItemDetails.Controls.Add(this.panel2);
            this.pnlAddItemDetails.Controls.Add(this.txtAddItemCode);
            this.pnlAddItemDetails.Controls.Add(this.txtAddItemDetails);
            this.pnlAddItemDetails.Controls.Add(this.txtAddItemName);
            this.pnlAddItemDetails.Controls.Add(this.lblAddItemCode);
            this.pnlAddItemDetails.Controls.Add(this.lblAddItemDescription);
            this.pnlAddItemDetails.Controls.Add(this.label11);
            this.pnlAddItemDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlAddItemDetails.Name = "pnlAddItemDetails";
            this.pnlAddItemDetails.Size = new System.Drawing.Size(1097, 170);
            this.pnlAddItemDetails.TabIndex = 26;
            this.pnlAddItemDetails.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddItemClose);
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Location = new System.Drawing.Point(928, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 136);
            this.panel2.TabIndex = 24;
            // 
            // btnAddItemClose
            // 
            this.btnAddItemClose.Location = new System.Drawing.Point(15, 80);
            this.btnAddItemClose.Name = "btnAddItemClose";
            this.btnAddItemClose.Size = new System.Drawing.Size(123, 38);
            this.btnAddItemClose.TabIndex = 2;
            this.btnAddItemClose.Text = "Close";
            this.btnAddItemClose.UseVisualStyleBackColor = true;
            this.btnAddItemClose.Click += new System.EventHandler(this.btnAddItemClose_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(15, 19);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(123, 38);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtAddItemCode
            // 
            this.txtAddItemCode.Location = new System.Drawing.Point(574, 31);
            this.txtAddItemCode.Name = "txtAddItemCode";
            this.txtAddItemCode.Size = new System.Drawing.Size(195, 26);
            this.txtAddItemCode.TabIndex = 15;
            // 
            // txtAddItemDetails
            // 
            this.txtAddItemDetails.Location = new System.Drawing.Point(157, 96);
            this.txtAddItemDetails.Name = "txtAddItemDetails";
            this.txtAddItemDetails.Size = new System.Drawing.Size(612, 26);
            this.txtAddItemDetails.TabIndex = 14;
            // 
            // txtAddItemName
            // 
            this.txtAddItemName.Location = new System.Drawing.Point(157, 31);
            this.txtAddItemName.Name = "txtAddItemName";
            this.txtAddItemName.Size = new System.Drawing.Size(314, 26);
            this.txtAddItemName.TabIndex = 13;
            // 
            // lblAddItemCode
            // 
            this.lblAddItemCode.AutoSize = true;
            this.lblAddItemCode.Location = new System.Drawing.Point(485, 34);
            this.lblAddItemCode.Name = "lblAddItemCode";
            this.lblAddItemCode.Size = new System.Drawing.Size(83, 20);
            this.lblAddItemCode.TabIndex = 3;
            this.lblAddItemCode.Text = "Item Code";
            // 
            // lblAddItemDescription
            // 
            this.lblAddItemDescription.AutoSize = true;
            this.lblAddItemDescription.Location = new System.Drawing.Point(37, 99);
            this.lblAddItemDescription.Name = "lblAddItemDescription";
            this.lblAddItemDescription.Size = new System.Drawing.Size(89, 20);
            this.lblAddItemDescription.TabIndex = 1;
            this.lblAddItemDescription.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name";
            // 
            // pnlEditItemDetails
            // 
            this.pnlEditItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditItemDetails.Controls.Add(this.cboItemName);
            this.pnlEditItemDetails.Controls.Add(this.lblNewName);
            this.pnlEditItemDetails.Controls.Add(this.panel3);
            this.pnlEditItemDetails.Controls.Add(this.txtEditItemCode);
            this.pnlEditItemDetails.Controls.Add(this.txtEditItemDetails);
            this.pnlEditItemDetails.Controls.Add(this.txtEditItemName);
            this.pnlEditItemDetails.Controls.Add(this.label1);
            this.pnlEditItemDetails.Controls.Add(this.label2);
            this.pnlEditItemDetails.Controls.Add(this.label3);
            this.pnlEditItemDetails.Location = new System.Drawing.Point(12, 188);
            this.pnlEditItemDetails.Name = "pnlEditItemDetails";
            this.pnlEditItemDetails.Size = new System.Drawing.Size(1097, 170);
            this.pnlEditItemDetails.TabIndex = 27;
            this.pnlEditItemDetails.Visible = false;
            // 
            // cboItemName
            // 
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(157, 19);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(314, 28);
            this.cboItemName.TabIndex = 26;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(37, 72);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(86, 20);
            this.lblNewName.TabIndex = 25;
            this.lblNewName.Text = "New Name";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEditItemClose);
            this.panel3.Controls.Add(this.btnUpdateItem);
            this.panel3.Location = new System.Drawing.Point(928, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 136);
            this.panel3.TabIndex = 24;
            // 
            // btnEditItemClose
            // 
            this.btnEditItemClose.Location = new System.Drawing.Point(15, 80);
            this.btnEditItemClose.Name = "btnEditItemClose";
            this.btnEditItemClose.Size = new System.Drawing.Size(123, 38);
            this.btnEditItemClose.TabIndex = 2;
            this.btnEditItemClose.Text = "Close";
            this.btnEditItemClose.UseVisualStyleBackColor = true;
            this.btnEditItemClose.Click += new System.EventHandler(this.btnEditItemClose_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(15, 19);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(123, 38);
            this.btnUpdateItem.TabIndex = 0;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // txtEditItemCode
            // 
            this.txtEditItemCode.Location = new System.Drawing.Point(574, 24);
            this.txtEditItemCode.Name = "txtEditItemCode";
            this.txtEditItemCode.Size = new System.Drawing.Size(195, 26);
            this.txtEditItemCode.TabIndex = 15;
            // 
            // txtEditItemDetails
            // 
            this.txtEditItemDetails.Location = new System.Drawing.Point(157, 119);
            this.txtEditItemDetails.Name = "txtEditItemDetails";
            this.txtEditItemDetails.Size = new System.Drawing.Size(612, 26);
            this.txtEditItemDetails.TabIndex = 14;
            // 
            // txtEditItemName
            // 
            this.txtEditItemName.Location = new System.Drawing.Point(157, 72);
            this.txtEditItemName.Name = "txtEditItemName";
            this.txtEditItemName.Size = new System.Drawing.Size(314, 26);
            this.txtEditItemName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // frmItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 598);
            this.Controls.Add(this.pnlEditItemDetails);
            this.Controls.Add(this.pnlAddItemDetails);
            this.Name = "frmItemDetails";
            this.Text = "Items";
            this.pnlAddItemDetails.ResumeLayout(false);
            this.pnlAddItemDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlEditItemDetails.ResumeLayout(false);
            this.pnlEditItemDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddItemDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddItemClose;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtAddItemCode;
        private System.Windows.Forms.TextBox txtAddItemDetails;
        private System.Windows.Forms.TextBox txtAddItemName;
        private System.Windows.Forms.Label lblAddItemCode;
        private System.Windows.Forms.Label lblAddItemDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlEditItemDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditItemClose;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.TextBox txtEditItemCode;
        private System.Windows.Forms.TextBox txtEditItemDetails;
        private System.Windows.Forms.TextBox txtEditItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.Label lblNewName;
    }
}