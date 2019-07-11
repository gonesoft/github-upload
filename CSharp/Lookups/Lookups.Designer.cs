namespace Lookups
{
    partial class Lookups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lookups));
            this.CustomerLookup = new System.Windows.Forms.Button();
            this.CustomerNumber = new System.Windows.Forms.TextBox();
            this.labelCustomerNumber = new System.Windows.Forms.Label();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.labelVendorID = new System.Windows.Forms.Label();
            this.ItemNumber = new System.Windows.Forms.TextBox();
            this.labelItemNumber = new System.Windows.Forms.Label();
            this.GLAccountNumber = new System.Windows.Forms.TextBox();
            this.labelGLAccountNumber = new System.Windows.Forms.Label();
            this.SOPDocumentNumber = new System.Windows.Forms.TextBox();
            this.labelSOPDocumentNumber = new System.Windows.Forms.Label();
            this.POPDocumentNumber = new System.Windows.Forms.TextBox();
            this.labelPOPDocumentNumber = new System.Windows.Forms.Label();
            this.VendorLookup = new System.Windows.Forms.Button();
            this.ItemLookup = new System.Windows.Forms.Button();
            this.GLAccountLookup = new System.Windows.Forms.Button();
            this.SOPDocumentLookup = new System.Windows.Forms.Button();
            this.POPDocumentLookup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerLookup
            // 
            this.CustomerLookup.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.CustomerLookup, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.CustomerLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.CustomerLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CustomerLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CustomerLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerLookup.Image = global::Lookups.Properties.Resources.Field_Lookup;
            this.CustomerLookup.Location = new System.Drawing.Point(255, 8);
            this.CustomerLookup.Name = "CustomerLookup";
            this.CustomerLookup.Size = new System.Drawing.Size(20, 20);
            this.CustomerLookup.TabIndex = 0;
            this.CustomerLookup.TabStop = false;
            this.CustomerLookup.UseVisualStyleBackColor = false;
            this.CustomerLookup.Click += new System.EventHandler(this.CustomerLookup_Click);
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.BackColor = System.Drawing.SystemColors.Window;
            this.CustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNumber.Location = new System.Drawing.Point(153, 12);
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.Size = new System.Drawing.Size(100, 13);
            this.CustomerNumber.TabIndex = 1;
            // 
            // labelCustomerNumber
            // 
            this.dexLabelProvider.SetLinkField(this.labelCustomerNumber, "CustomerNumber");
            this.labelCustomerNumber.Location = new System.Drawing.Point(13, 12);
            this.labelCustomerNumber.Name = "labelCustomerNumber";
            this.labelCustomerNumber.Size = new System.Drawing.Size(100, 13);
            this.labelCustomerNumber.TabIndex = 2;
            this.labelCustomerNumber.Text = "Customer Number";
            // 
            // VendorID
            // 
            this.VendorID.BackColor = System.Drawing.SystemColors.Window;
            this.VendorID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VendorID.Location = new System.Drawing.Point(153, 41);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(100, 13);
            this.VendorID.TabIndex = 3;
            // 
            // labelVendorID
            // 
            this.dexLabelProvider.SetLinkField(this.labelVendorID, "VendorID");
            this.labelVendorID.Location = new System.Drawing.Point(13, 41);
            this.labelVendorID.Name = "labelVendorID";
            this.labelVendorID.Size = new System.Drawing.Size(118, 13);
            this.labelVendorID.TabIndex = 4;
            this.labelVendorID.Text = "Vendor ID";
            // 
            // ItemNumber
            // 
            this.ItemNumber.BackColor = System.Drawing.SystemColors.Window;
            this.ItemNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemNumber.Location = new System.Drawing.Point(153, 71);
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Size = new System.Drawing.Size(100, 13);
            this.ItemNumber.TabIndex = 5;
            // 
            // labelItemNumber
            // 
            this.dexLabelProvider.SetLinkField(this.labelItemNumber, "ItemNumber");
            this.labelItemNumber.Location = new System.Drawing.Point(16, 71);
            this.labelItemNumber.Name = "labelItemNumber";
            this.labelItemNumber.Size = new System.Drawing.Size(97, 13);
            this.labelItemNumber.TabIndex = 6;
            this.labelItemNumber.Text = "Item Number";
            // 
            // GLAccountNumber
            // 
            this.GLAccountNumber.BackColor = System.Drawing.SystemColors.Window;
            this.GLAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GLAccountNumber.Location = new System.Drawing.Point(153, 100);
            this.GLAccountNumber.Name = "GLAccountNumber";
            this.GLAccountNumber.Size = new System.Drawing.Size(100, 13);
            this.GLAccountNumber.TabIndex = 7;
            // 
            // labelGLAccountNumber
            // 
            this.dexLabelProvider.SetLinkField(this.labelGLAccountNumber, "GLAccountNumber");
            this.labelGLAccountNumber.Location = new System.Drawing.Point(16, 100);
            this.labelGLAccountNumber.Name = "labelGLAccountNumber";
            this.labelGLAccountNumber.Size = new System.Drawing.Size(115, 13);
            this.labelGLAccountNumber.TabIndex = 8;
            this.labelGLAccountNumber.Text = "GL Account Number";
            // 
            // SOPDocumentNumber
            // 
            this.SOPDocumentNumber.BackColor = System.Drawing.SystemColors.Window;
            this.SOPDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SOPDocumentNumber.Location = new System.Drawing.Point(153, 130);
            this.SOPDocumentNumber.Name = "SOPDocumentNumber";
            this.SOPDocumentNumber.Size = new System.Drawing.Size(100, 13);
            this.SOPDocumentNumber.TabIndex = 9;
            // 
            // labelSOPDocumentNumber
            // 
            this.dexLabelProvider.SetLinkField(this.labelSOPDocumentNumber, "SOPDocumentNumber");
            this.labelSOPDocumentNumber.Location = new System.Drawing.Point(16, 130);
            this.labelSOPDocumentNumber.Name = "labelSOPDocumentNumber";
            this.labelSOPDocumentNumber.Size = new System.Drawing.Size(131, 13);
            this.labelSOPDocumentNumber.TabIndex = 10;
            this.labelSOPDocumentNumber.Text = "SOP Document Number";
            // 
            // POPDocumentNumber
            // 
            this.POPDocumentNumber.BackColor = System.Drawing.SystemColors.Window;
            this.POPDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.POPDocumentNumber.Location = new System.Drawing.Point(153, 159);
            this.POPDocumentNumber.Name = "POPDocumentNumber";
            this.POPDocumentNumber.Size = new System.Drawing.Size(100, 13);
            this.POPDocumentNumber.TabIndex = 11;
            // 
            // labelPOPDocumentNumber
            // 
            this.dexLabelProvider.SetLinkField(this.labelPOPDocumentNumber, "POPDocumentNumber");
            this.labelPOPDocumentNumber.Location = new System.Drawing.Point(16, 159);
            this.labelPOPDocumentNumber.Name = "labelPOPDocumentNumber";
            this.labelPOPDocumentNumber.Size = new System.Drawing.Size(131, 13);
            this.labelPOPDocumentNumber.TabIndex = 12;
            this.labelPOPDocumentNumber.Text = "POP Document Number";
            // 
            // VendorLookup
            // 
            this.VendorLookup.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.VendorLookup, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.VendorLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.VendorLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VendorLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VendorLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VendorLookup.Image = global::Lookups.Properties.Resources.Field_Lookup;
            this.VendorLookup.Location = new System.Drawing.Point(255, 37);
            this.VendorLookup.Name = "VendorLookup";
            this.VendorLookup.Size = new System.Drawing.Size(20, 20);
            this.VendorLookup.TabIndex = 13;
            this.VendorLookup.TabStop = false;
            this.VendorLookup.UseVisualStyleBackColor = false;
            this.VendorLookup.Click += new System.EventHandler(this.VendorLookup_Click);
            // 
            // ItemLookup
            // 
            this.ItemLookup.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.ItemLookup, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.ItemLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.ItemLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ItemLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ItemLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemLookup.Image = ((System.Drawing.Image)(resources.GetObject("ItemLookup.Image")));
            this.ItemLookup.Location = new System.Drawing.Point(255, 67);
            this.ItemLookup.Name = "ItemLookup";
            this.ItemLookup.Size = new System.Drawing.Size(20, 20);
            this.ItemLookup.TabIndex = 14;
            this.ItemLookup.TabStop = false;
            this.ItemLookup.UseVisualStyleBackColor = false;
            this.ItemLookup.Click += new System.EventHandler(this.ItemLookup_Click);
            // 
            // GLAccountLookup
            // 
            this.GLAccountLookup.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.GLAccountLookup, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.GLAccountLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.GLAccountLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GLAccountLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GLAccountLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GLAccountLookup.Image = ((System.Drawing.Image)(resources.GetObject("GLAccountLookup.Image")));
            this.GLAccountLookup.Location = new System.Drawing.Point(255, 96);
            this.GLAccountLookup.Name = "GLAccountLookup";
            this.GLAccountLookup.Size = new System.Drawing.Size(20, 20);
            this.GLAccountLookup.TabIndex = 15;
            this.GLAccountLookup.TabStop = false;
            this.GLAccountLookup.UseVisualStyleBackColor = false;
            this.GLAccountLookup.Click += new System.EventHandler(this.GLAccountLookup_Click);
            // 
            // SOPDocumentLookup
            // 
            this.SOPDocumentLookup.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.SOPDocumentLookup, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.SOPDocumentLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.SOPDocumentLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SOPDocumentLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SOPDocumentLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SOPDocumentLookup.Image = ((System.Drawing.Image)(resources.GetObject("SOPDocumentLookup.Image")));
            this.SOPDocumentLookup.Location = new System.Drawing.Point(255, 126);
            this.SOPDocumentLookup.Name = "SOPDocumentLookup";
            this.SOPDocumentLookup.Size = new System.Drawing.Size(20, 20);
            this.SOPDocumentLookup.TabIndex = 16;
            this.SOPDocumentLookup.TabStop = false;
            this.SOPDocumentLookup.UseVisualStyleBackColor = false;
            this.SOPDocumentLookup.Click += new System.EventHandler(this.SOPDocumentLookup_Click);
            // 
            // POPDocumentLookup
            // 
            this.POPDocumentLookup.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.POPDocumentLookup, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.POPDocumentLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.POPDocumentLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.POPDocumentLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.POPDocumentLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POPDocumentLookup.Image = ((System.Drawing.Image)(resources.GetObject("POPDocumentLookup.Image")));
            this.POPDocumentLookup.Location = new System.Drawing.Point(255, 155);
            this.POPDocumentLookup.Name = "POPDocumentLookup";
            this.POPDocumentLookup.Size = new System.Drawing.Size(20, 20);
            this.POPDocumentLookup.TabIndex = 17;
            this.POPDocumentLookup.TabStop = false;
            this.POPDocumentLookup.UseVisualStyleBackColor = false;
            this.POPDocumentLookup.Click += new System.EventHandler(this.POPDocumentLookup_Click);
            // 
            // Lookups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 193);
            this.ControlArea = false;
            this.Controls.Add(this.POPDocumentLookup);
            this.Controls.Add(this.SOPDocumentLookup);
            this.Controls.Add(this.GLAccountLookup);
            this.Controls.Add(this.ItemLookup);
            this.Controls.Add(this.VendorLookup);
            this.Controls.Add(this.labelPOPDocumentNumber);
            this.Controls.Add(this.POPDocumentNumber);
            this.Controls.Add(this.labelSOPDocumentNumber);
            this.Controls.Add(this.SOPDocumentNumber);
            this.Controls.Add(this.labelGLAccountNumber);
            this.Controls.Add(this.GLAccountNumber);
            this.Controls.Add(this.labelItemNumber);
            this.Controls.Add(this.ItemNumber);
            this.Controls.Add(this.labelVendorID);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.labelCustomerNumber);
            this.Controls.Add(this.CustomerNumber);
            this.Controls.Add(this.CustomerLookup);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Lookups";
            this.StatusArea = false;
            this.Text = "Lookups";
            this.Load += new System.EventHandler(this.Lookups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerLookup;
        public System.Windows.Forms.TextBox CustomerNumber;
        private System.Windows.Forms.Label labelCustomerNumber;
        private System.Windows.Forms.Label labelVendorID;
        private System.Windows.Forms.Label labelItemNumber;
        private System.Windows.Forms.Label labelGLAccountNumber;
        private System.Windows.Forms.Label labelSOPDocumentNumber;
        private System.Windows.Forms.Label labelPOPDocumentNumber;
        private System.Windows.Forms.Button VendorLookup;
        private System.Windows.Forms.Button ItemLookup;
        private System.Windows.Forms.Button GLAccountLookup;
        private System.Windows.Forms.Button SOPDocumentLookup;
        private System.Windows.Forms.Button POPDocumentLookup;
        public System.Windows.Forms.TextBox VendorID;
        public System.Windows.Forms.TextBox ItemNumber;
        public System.Windows.Forms.TextBox GLAccountNumber;
        public System.Windows.Forms.TextBox SOPDocumentNumber;
        public System.Windows.Forms.TextBox POPDocumentNumber;
    }
}

