using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Dexterity.Bridge;
using Microsoft.Dexterity.Applications;
using Microsoft.Dexterity.Applications.DynamicsDictionary;

namespace Lookups
{
    [SupportedDexPlatforms(DexPlatforms.DesktopClient | DexPlatforms.WebClient)]
    public class GPAddIn : IDexterityAddIn
    {
        // Keep a reference to the Lookups WinForm.
        static Lookups LookupsWindow;

        // Reference to the About Box
        static AboutBoxForm AboutBox = Dynamics.Forms.AboutBox;

        // Flag to track that a lookup was opened
        public static Boolean ReturnToLookup = false;

        public void Initialize()
        {
            // Menu to open Lookups form
            Dynamics.Forms.AboutBox.AddMenuHandler(OpenLookupWindow, "Lookups", "");

            // Select button on the Customers lookup window
            Microsoft.Dexterity.Applications.SmartListDictionary.CustomerLookupForm customerLookupForm = SmartList.Forms.CustomerLookup;
            customerLookupForm.CustomerLookup.SelectButton.ClickBeforeOriginal += new System.ComponentModel.CancelEventHandler(CustomerSelectButton_ClickBeforeOriginal);

            // Select button on the Vendors lookup window
            Microsoft.Dexterity.Applications.SmartListDictionary.VendorLookupForm vendorLookupForm = SmartList.Forms.VendorLookup;
            vendorLookupForm.VendorLookup.SelectButton.ClickBeforeOriginal += new System.ComponentModel.CancelEventHandler(VendorSelectButton_ClickBeforeOriginal);

            // Select button on the Items lookup window
            Microsoft.Dexterity.Applications.SmartListDictionary.IvItemNumberLookupForm itemNumberLookupForm = SmartList.Forms.IvItemNumberLookup;
            itemNumberLookupForm.IvItemNumberLookup.SelectButton.ClickBeforeOriginal += new System.ComponentModel.CancelEventHandler(ItemSelectButton_ClickBeforeOriginal);

            // Select button on the GL Account lookup window
            Microsoft.Dexterity.Applications.SmartListDictionary.AccountLookupForm accountLookupForm = SmartList.Forms.AccountLookup;
            accountLookupForm.AccountLookup.SelectButton.ClickBeforeOriginal += new System.ComponentModel.CancelEventHandler(AccountSelectButton_ClickBeforeOriginal);

            // Select button on the SOP Document lookup window
            Microsoft.Dexterity.Applications.SmartListDictionary.SopDocumentLookupForm sopLookupForm = SmartList.Forms.SopDocumentLookup;
            sopLookupForm.SopDocumentLookup.SelectButton.ClickBeforeOriginal += new System.ComponentModel.CancelEventHandler(SOPDocumentSelectButton_ClickBeforeOriginal);

            // Select button on the POP Document lookup window
            Microsoft.Dexterity.Applications.SmartListDictionary.PopDocumentLookupForm popLookupForm = SmartList.Forms.PopDocumentLookup;
            popLookupForm.PopDocumentLookup.SelectButton.ClickBeforeOriginal += new System.ComponentModel.CancelEventHandler(POPDocumentSelectButton_ClickBeforeOriginal);

            // Validate script that prevents the POP Document lookup window from being displayed
            popLookupForm.PopDocumentLookup.PopPoLookup.ValidateBeforeOriginal += new System.ComponentModel.CancelEventHandler(PopPoLookup_ValidateBeforeOriginal);
        }


        static void OpenLookupWindow(object sender, EventArgs e)
        {
            // Open the window that shows the sample lookups
            LookupsWindow = new Lookups();
            LookupsWindow.Show();
        }


        void CustomerSelectButton_ClickBeforeOriginal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Run this code only if the Visual Studio Tools add-in opened the lookup.
            if (GPAddIn.ReturnToLookup == true)
            {
                // Retrieve the customer number of the row selected in the scrolling window
                // of the Customers lookup.
                Microsoft.Dexterity.Applications.SmartListDictionary.CustomerLookupForm customerLookupForm = SmartList.Forms.CustomerLookup;
                string customerNumber = customerLookupForm.CustomerLookup.CustomerLookupScroll.CustomerNumber.Value;

                // Display the value retrieved
                LookupsWindow.CustomerNumber.Text = customerNumber;

                // Clear the flag that indicates a value is to be retrieved from the lookup.
                GPAddIn.ReturnToLookup = false;
            }
        }


        void VendorSelectButton_ClickBeforeOriginal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Run this code only if the Visual Studio Tools add-in opened the lookup.
            if (GPAddIn.ReturnToLookup == true)
            {
                // Retrieve the vendor ID of the row selected in the scrolling window
                // of the Vendors lookup.
                Microsoft.Dexterity.Applications.SmartListDictionary.VendorLookupForm vendorLookupForm = SmartList.Forms.VendorLookup;
                string vendorID = vendorLookupForm.VendorLookup.VendorLookupScroll.VendorId;

                // Display the value retrieved
                LookupsWindow.VendorID.Text = vendorID;

                // Clear the flag that indicates a value is to be retrieved from the lookup.
                GPAddIn.ReturnToLookup = false;
            }
        }


        void ItemSelectButton_ClickBeforeOriginal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Run this code only if the Visual Studio Tools add-in opened the lookup.
            if (GPAddIn.ReturnToLookup == true)
            {
                // Retrieve the item number of the row selected in the scrolling window
                // of the Items lookup.
                Microsoft.Dexterity.Applications.SmartListDictionary.IvItemNumberLookupForm itemLookupForm = SmartList.Forms.IvItemNumberLookup;
                string itemNumber = itemLookupForm.IvItemNumberLookup.IvItemNumberScroll.ItemNumber;

                // Display the value retrieved
                LookupsWindow.ItemNumber.Text = itemNumber;
                
                // Clear the flag that indicates a value is to be retrieved from the lookup.
                GPAddIn.ReturnToLookup = false;
            }
        }


        void AccountSelectButton_ClickBeforeOriginal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Run this code only if the Visual Studio Tools add-in opened the lookup.
            if (GPAddIn.ReturnToLookup == true)
            {
                // Retrieve the account number of the row selected in the scrolling window
                // of the Accounts lookup. The Account Number in Dynamics GP is a composite, 
                // so an instance of that composite must be created. 
                Microsoft.Dexterity.Applications.SmartListDictionary.AccountLookupForm accountLookupForm = SmartList.Forms.AccountLookup;
                Microsoft.Dexterity.Applications.DynamicsDictionary.AccountNumberCompositeData accountNumber = new Microsoft.Dexterity.Applications.DynamicsDictionary.AccountNumberCompositeData();
                accountNumber = accountLookupForm.AccountLookup.AccountScroll.AccountNumber;

                // Now we have accountNumber, which is the Account Number composite, call a GP function
                // to return the string for the account number, so it can be displayed on the window.
                // This technique works for all account structures.  
                string accountNumberString = Dynamics.Forms.GlAcct.Functions.ConvertAcctToStr.Invoke(accountNumber);

                // Set the window field to the accountNumberString value
                LookupsWindow.GLAccountNumber.Text = accountNumberString;

                // Clear the flag that indicates a value is to be retrieved from the lookup.
                GPAddIn.ReturnToLookup = false;
            }
        }


        void SOPDocumentSelectButton_ClickBeforeOriginal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Run this code only if the Visual Studio Tools add-in opened the lookup.
            if (GPAddIn.ReturnToLookup == true)
            {
                // Retrieve the SOP Document number of the row selected in the scrolling window
                // of the SOP document lookup.
                Microsoft.Dexterity.Applications.SmartListDictionary.SopDocumentLookupForm sopLookupForm = SmartList.Forms.SopDocumentLookup;
                string sopNumber = sopLookupForm.SopDocumentLookup.DocumentScroll.SopNumber;

                // Display the value retrieved
                LookupsWindow.SOPDocumentNumber.Text = sopNumber;

                // Clear the flag that indicates a value is to be retrieved from the lookup.
                GPAddIn.ReturnToLookup = false;
            }
        }


        void POPDocumentSelectButton_ClickBeforeOriginal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Run this code only if the Visual Studio Tools add-in opened the lookup.
            if (GPAddIn.ReturnToLookup == true)
            {
                // Retrieve the POP document number of the row selected in the scrolling window
                // of the POP document lookup.
                Microsoft.Dexterity.Applications.SmartListDictionary.PopDocumentLookupForm popLookupForm = SmartList.Forms.PopDocumentLookup;
                string popNumber = popLookupForm.PopDocumentLookup.DocumentScroll.PoNumber;

                // Display the value retrieved  
                LookupsWindow.POPDocumentNumber.Text = popNumber;

                // Clear the flag that indicates a value is to be retrieved from the lookup.
                GPAddIn.ReturnToLookup = false;
            }
        }


        void PopPoLookup_ValidateBeforeOriginal(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Due to the way the POP Document Lookup is coded, the ValidateBeforeOriginal event
            // for the PopPoLookup field must be cancelled when the lookup is called from a Visual
            // Studio Tools form. If this event is not cancelled, the lookup window is closed 
            // immediately after opening, preventing the lookup from working properly.
            if (GPAddIn.ReturnToLookup == true)
            {
                e.Cancel = true;
            }
        }
    }
}
