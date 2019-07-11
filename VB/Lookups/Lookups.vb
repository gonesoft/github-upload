Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.Dexterity.Bridge
Imports Microsoft.Dexterity.Applications
Imports Microsoft.Dexterity.Shell

<WCCompliantWindow(True)>
Public Class Lookups
    Inherits DexUIForm

    Private Sub CustomerLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerLookup.Click

        ' Create a reference to the CustomerLookup form
        Dim customerLookup As Microsoft.Dexterity.Applications.SmartListDictionary.CustomerLookupForm = SmartList.Forms.CustomerLookup

        ' Set the flag indicating that we opened the lookup
        GPAddIn.ReturnToLookup = True

        ' Open the CustomerLookup form
        customerLookup.Open()

        ' Call the Initialize procedure to configure the Customer Lookup
        customerLookup.Procedures.Initialize.Invoke(1, 0, CustomerNumber.Text, "", "", "", "", "")

    End Sub

    Private Sub VendorLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorLookup.Click

        ' Create a reference to the VendorLookup form
        Dim vendorLookup As Microsoft.Dexterity.Applications.SmartListDictionary.VendorLookupForm = SmartList.Forms.VendorLookup

        ' Set the flag indicating that we opened the lookup
        GPAddIn.ReturnToLookup = True

        ' Open the VendorLookup form 
        vendorLookup.Open()

        ' Set the field values on the lookup window
        vendorLookup.VendorLookup.VendorId.Value = VendorID.Text
        vendorLookup.VendorLookup.VendorName.Value = ""     'Vendor Name 
        vendorLookup.VendorLookup.VendorClassId.Value = ""  'Vendor Class
        vendorLookup.VendorLookup.UserDefined1.Value = ""   'User Defined 1
        vendorLookup.VendorLookup.VendorSortBy.Value = 1    'Sort by

        ' Run Validate on the Vendor Sort By to fill the lookup window
        vendorLookup.VendorLookup.VendorSortBy.RunValidate()

    End Sub

    Private Sub ItemLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemLookup.Click

        ' Create a reference to the IvItemNumberLookup form
        Dim itemNumberLookup As Microsoft.Dexterity.Applications.SmartListDictionary.IvItemNumberLookupForm = SmartList.Forms.IvItemNumberLookup

        ' Set the flag indicating that we opened the lookup
        GPAddIn.ReturnToLookup = True

        ' Open the lookup form.
        itemNumberLookup.Open()

        ' Set the field values on the lookup window 
        ' The options for the sort by value are:
        ' 1 = Item Number
        ' 2 = Item Description
        ' 3 = Item Class Code
        ' 4 = Item Short Name

        ' Sort by the item number
        itemNumberLookup.IvItemNumberLookup.SortByIvItems.Value = 1

        ' For the sort option chosen, set the corresponding field value
        Select Case itemNumberLookup.IvItemNumberLookup.SortByIvItems.Value
            Case 1
                'Item Number
                itemNumberLookup.IvItemNumberLookup.ItemNumber.Value = ItemNumber.Text
            Case 2
                ' If sorting based on Item Description, you will set that value here
                itemNumberLookup.IvItemNumberLookup.ItemDescription.Value = ItemNumber.Text
            Case 3
                ' If sorting based on Item Class Code, you will set that value here
                itemNumberLookup.IvItemNumberLookup.ItemClassCode.Value = ItemNumber.Text
            Case 4
                ' If sorting based on Item Short Name, you will set that value here
                itemNumberLookup.IvItemNumberLookup.ItemShortName.Value = ItemNumber.Text
        End Select

        'Run Validate on the Redisplay button to fill the lookup window
        itemNumberLookup.IvItemNumberLookup.RedisplayButton.RunValidate()

    End Sub

    Private Sub GLAccountLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLAccountLookup.Click

        ' Create a reference to the AccountLookup form
        Dim accountLookup As Microsoft.Dexterity.Applications.SmartListDictionary.AccountLookupForm = SmartList.Forms.AccountLookup

        ' Set the flag indicating that we opened the lookup
        GPAddIn.ReturnToLookup = True

        ' Open the lookup form 
        accountLookup.Open()

        ' Show Posting Accounts
        accountLookup.AccountLookup.LocalAccountType1.Value = 1

        ' The sort by options are:
        '  by Description = 1
        '	by Account Type = 2
        '	by Category = 3
        '	by Account = 4
        '	by Main Segment = 5
        '	by Alias = 6

        ' Sort by Main Segment
        accountLookup.AccountLookup.SortBy.Value = 5

        'Run Validate on the SortBy field to fill the lookup window
        accountLookup.AccountLookup.SortBy.RunValidate()

    End Sub

    Private Sub SOPDocumentLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOPDocumentLookup.Click

        ' Create an empty date value for Microsoft Dynamics GP
        Dim emptyDate As DateTime = New DateTime()
        emptyDate = Convert.ToDateTime("1/1/1900")

        ' Create a reference to the SopDocumentLookup form
        Dim sopLookup As Microsoft.Dexterity.Applications.SmartListDictionary.SopDocumentLookupForm = SmartList.Forms.SopDocumentLookup

        ' Set the flag indicating that we opened the lookup
        GPAddIn.ReturnToLookup = True

        'Open the lookup form 
        sopLookup.Open()

        ' The parameters for the Open procedure are:
        '  1 - Sort by 
        '      1 = SOP Number
        '      2 = Customer
        '      3 = Doc Date
        '      4 = Batch ID
        '      5 = Doc Type
        '  2 - What to show
        '      0 = SHOW_ALL
        '      1 = SHOW_SHIPDOC_EXCLUDED
        '      2 = SHOW_SHIPDOC_ONLY
        '      3 = SHOW_ORDERS_BACKORDERS
        '      4 = SHOW_ORDERS_FULFILLMENTORDERS
        '      5 = SHOW_BACKORDERS
        '  3 - Table type
        '      0 = Work
        '      1 = History
        '  4 - Lock status
        '      0 = Unlocked
        '      1 = Locked
        '  5 - Seed for Sop Type  
        '  6 - Seed for Sop Number
        '  7 - Seed for Customer Number
        '  8 - Seed for Batch Number - Empty for historical docs
        '  9 - Seed for Trx Source - Empty for work docs
        ' 10 - Seed value for Doc Date
        ' 11 - Seed value for master number
        ' 12 - Always pass in false
        ' 13 - Restrict by document type 
        '      1 = Quote
        '      2 = Order
        '      3 = Invoice
        '      4 = Return
        '      5 = Back Order
        '      6 = Fullfillment Order
        '      0 = All documents

        ' Sort by SOP Number, Showing all documents, from the History table 
        Dynamics.Forms.SopDocumentLookup.Procedures.Open.Invoke(1, 0, 1, 0, 0, SOPDocumentNumber.Text, "", "", "", emptyDate, 0, False, 0)

    End Sub

    Private Sub POPDocumentLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POPDocumentLookup.Click

        ' Create a reference to the PopDocumentLookup form
        Dim popLookup As Microsoft.Dexterity.Applications.SmartListDictionary.PopDocumentLookupForm = SmartList.Forms.PopDocumentLookup

        ' Set the flag indicating that we opened the lookup
        GPAddIn.ReturnToLookup = True

        'Open the lookup form 
        popLookup.Open()

        ' Set the field values on the lookup window
        popLookup.PopDocumentLookup.IncludeGb.Value = 0  ' 0 = Open docs, 1 = History
        popLookup.PopDocumentLookup.LocalSortBy.Value = 1
        popLookup.PopDocumentLookup.PopPoLookup.PoNumber.Value = POPDocumentNumber.Text

        'Run Validate on the SortBy field to fill the lookup window
        popLookup.PopDocumentLookup.LocalSortBy.RunValidate()

    End Sub
End Class