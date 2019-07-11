using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Dexterity.Bridge;
using Microsoft.Dexterity.Applications;
using Microsoft.Dexterity.Shell;
using Microsoft.Dexterity.Applications.DynamicsDictionary;

namespace Lookups
{
    [WCCompliantWindow(true)]
    public partial class Lookups : DexUIForm
    {
        public Lookups()
        {
            InitializeComponent();
        }

        private void CustomerLookup_Click(object sender, EventArgs e)
        {
            // Create a reference to the CustomerLookup form
            Microsoft.Dexterity.Applications.SmartListDictionary.CustomerLookupForm customerLookup = SmartList.Forms.CustomerLookup;

            // Set the flag indicating that we opened the lookup
            GPAddIn.ReturnToLookup = true;

            // Open the CustomerLookup form
            customerLookup.Open();

            // Call the Initialize procedure to configure the Customer Lookup
            customerLookup.Procedures.Initialize.Invoke(1, 0, CustomerNumber.Text, "", "", "", "", "");
        }

        private void VendorLookup_Click(object sender, EventArgs e)
        {
            // Create a reference to the VendorLookup form
            Microsoft.Dexterity.Applications.SmartListDictionary.VendorLookupForm vendorLookup = SmartList.Forms.VendorLookup;

            // Set the flag indicating that we opened the lookup
            GPAddIn.ReturnToLookup = true;

            // Open the VendorLookup form 
            vendorLookup.Open();

            // Set the field values on the lookup window
            vendorLookup.VendorLookup.VendorId.Value = VendorID.Text;
            vendorLookup.VendorLookup.VendorName.Value = "";     //Vendor Name 
            vendorLookup.VendorLookup.VendorClassId.Value = "";  //Vendor Class
            vendorLookup.VendorLookup.UserDefined1.Value = "";   //User Defined 1
            vendorLookup.VendorLookup.VendorSortBy.Value = 1;    //Sort by

            // Run Validate on the Vendor Sort By to fill the lookup window
            vendorLookup.VendorLookup.VendorSortBy.RunValidate();
        }

        private void ItemLookup_Click(object sender, EventArgs e)
        {
            // Create a reference to the IvItemNumberLookup form
            Microsoft.Dexterity.Applications.SmartListDictionary.IvItemNumberLookupForm itemNumberLookup = SmartList.Forms.IvItemNumberLookup;

            // Set the flag indicating that we opened the lookup
            GPAddIn.ReturnToLookup = true;

            // Open the lookup form.
            itemNumberLookup.Open();

            // Set the field values on the lookup window 
            // The options for the sort by value are:
            // 1 = Item Number
            // 2 = Item Description
            // 3 = Item Class Code
            // 4 = Item Short Name
            //itemNumberLookup.IvItemNumberLookup.AsiLuViewButton.Value = 1;
            //itemNumberLookup.IvItemNumberLookup.AsiEndDdl1.Value = 2;
            //itemNumberLookup.IvItemNumberLookup.AsiLuColumnButtonDropList.Value = 3;
            // Value = "string";
            //itemNumberLookup.IvItemNumberLookup.LocalCheckedView.Value = 2;

            
            //itemNumberLookup.IvItemNumberLookup.
            
            
            // Sort by the item number
            //itemNumberLookup.IvItemNumberLookup.SortByIvItems.Value = 3;

            // For the sort option chosen, set the corresponding field value
            /*switch (itemNumberLookup.IvItemNumberLookup.SortByIvItems.Value)
            {
                case 1:
                    //Item Number
                    itemNumberLookup.IvItemNumberLookup.ItemNumber.Value = ItemNumber.Text;  
                    break;

                case 2:
                    // If sorting based on Item Description, you will set that value here
                    itemNumberLookup.IvItemNumberLookup.ItemDescription.Value = ItemNumber.Text;
                    break;

                case 3:
                    // If sorting based on Item Class Code, you will set that value here
                    itemNumberLookup.IvItemNumberLookup.ItemClassCode.Value = ItemNumber.Text;
                    break;

                case 4:
                    // If sorting based on Item Short Name, you will set that value here
                    itemNumberLookup.IvItemNumberLookup.ItemShortName.Value = ItemNumber.Text;
                    break;
            }*/

            //Run Validate on the Redisplay button to fill the lookup window
            //itemNumberLookup.Tables.AsiLuDefaultViews.FormName.Value =    //AsiAdditionalSort.Value = 4;
            itemNumberLookup.Tables.AsiLuDefaultViews.DefaultView.Value = 4;
            itemNumberLookup.IvItemNumberLookup.IvItemNumberScroll. LocationCode.Value = "IQ27";
            itemNumberLookup.Tables.AsiLuDefaultViews.AsiFavoriteType.Value = 4;
            itemNumberLookup.IvItemNumberLookup.AsiLuViewButton.Value = 4;
            itemNumberLookup.IvItemNumberLookup.AsiLuViewButton.Hide();
            //itemNumberLookup.IvItemNumberLookup.scroll
                //((Microsoft.Dexterity.Bridge.FieldReadWrite<string>)(itemNumberLookup.IvItemNumberLookup.AsiLuCurrentView)).Value
            

            //itemNumberLookup.IvItemNumberLookup.AsiLuCurrentView.Show();
            itemNumberLookup.IvItemNumberLookup.RedisplayButton.RunValidate();
            itemNumberLookup.IvItemNumberLookup.AsiLuFindString.Value = "Hello";
            itemNumberLookup.IvItemNumberLookup.AsiLuFindString.Focus();
            
        }

        private void GLAccountLookup_Click(object sender, EventArgs e)
        {
            // Create a reference to the AccountLookup form
            Microsoft.Dexterity.Applications.SmartListDictionary.AccountLookupForm accountLookup = SmartList.Forms.AccountLookup;

            // Set the flag indicating that we opened the lookup
            GPAddIn.ReturnToLookup = true;

            // Open the lookup form 
            accountLookup.Open();

            // Show Posting Accounts
            accountLookup.AccountLookup.LocalAccountType1.Value = 1;

            // The sort by options are:
            //  by Description = 1
            //	by Account Type = 2
            //	by Category = 3
            //	by Account = 4
            //	by Main Segment = 5
            //	by Alias = 6

            // Sort by Main Segment
            accountLookup.AccountLookup.SortBy.Value = 5;

            //Run Validate on the SortBy field to fill the lookup window
            accountLookup.AccountLookup.SortBy.RunValidate();
        }

        private void SOPDocumentLookup_Click(object sender, EventArgs e)
        {
            // Create an empty date value for Microsoft Dynamics GP
            DateTime emptyDate = new DateTime();
            emptyDate = Convert.ToDateTime("1/1/1900");

            // Create a reference to the SopDocumentLookup form
            Microsoft.Dexterity.Applications.SmartListDictionary.SopDocumentLookupForm sopLookup = SmartList.Forms.SopDocumentLookup;

            // Set the flag indicating that we opened the lookup
            GPAddIn.ReturnToLookup = true;

            //Open the lookup form 
            sopLookup.Open();

            // The parameters for the Open procedure are:
            //  1 - Sort by 
            //      1 = SOP Number
            //      2 = Customer
            //      3 = Doc Date
            //      4 = Batch ID
            //      5 = Doc Type
            //  2 - What to show
            //      0 = SHOW_ALL
            //      1 = SHOW_SHIPDOC_EXCLUDED
            //      2 = SHOW_SHIPDOC_ONLY
            //      3 = SHOW_ORDERS_BACKORDERS
            //      4 = SHOW_ORDERS_FULFILLMENTORDERS
            //      5 = SHOW_BACKORDERS
            //  3 - Table type
            //      0 = Work
            //      1 = History
            //  4 - Lock status
            //      0 = Unlocked
            //      1 = Locked
            //  5 - Seed for Sop Type  
            //  6 - Seed for Sop Number
            //  7 - Seed for Customer Number
            //  8 - Seed for Batch Number - Empty for historical docs
            //  9 - Seed for Trx Source - Empty for work docs
            // 10 - Seed value for Doc Date
            // 11 - Seed value for master number
            // 12 - Always pass in false
            // 13 - Restrict by document type 
            //      1 = Quote
            //      2 = Order
            //      3 = Invoice
            //      4 = Return
            //      5 = Back Order
            //      6 = Fullfillment Order
            //      0 = All documents
  
            // Sort by SOP Number, Showing all documents, from the History table 
            Dynamics.Forms.SopDocumentLookup.Procedures.Open.Invoke(1, 0, 1, 0, 0, SOPDocumentNumber.Text, "",
                "", "", emptyDate, 0, false, 0);
        }

        private void POPDocumentLookup_Click(object sender, EventArgs e)
        {
            // Create a reference to the PopDocumentLookup form
            Microsoft.Dexterity.Applications.SmartListDictionary.PopDocumentLookupForm popLookup = SmartList.Forms.PopDocumentLookup;

            // Set the flag indicating that we opened the lookup
            GPAddIn.ReturnToLookup = true;

            //Open the lookup form 
            popLookup.Open();

            // Set the field values on the lookup window
            popLookup.PopDocumentLookup.IncludeGb.Value = 0;  // 0 = Open docs, 1 = History
            popLookup.PopDocumentLookup.LocalSortBy.Value = 1;
            popLookup.PopDocumentLookup.PopPoLookup.PoNumber.Value = POPDocumentNumber.Text;

            //Run Validate on the SortBy field to fill the lookup window
            popLookup.PopDocumentLookup.LocalSortBy.RunValidate();
        }

        private void Lookups_Load(object sender, EventArgs e)
        {

        }
    }
}