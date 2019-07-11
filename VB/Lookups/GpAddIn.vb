Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports Microsoft.Dexterity.Bridge
Imports Microsoft.Dexterity.Applications
Imports Microsoft.Dexterity.Applications.DynamicsDictionary
Imports Microsoft.Dexterity.Applications.SmartListDictionary

<SupportedDexPlatforms(DexPlatforms.DesktopClient Or DexPlatforms.WebClient)>
Public Class GPAddIn
    Implements IDexterityAddIn

    ' Keep a reference to the Lookups WinForm.
    Shared LookupsWindow As Lookups

    ' Reference to the About Box
    Shared AboutBox As AboutBoxForm = Dynamics.Forms.AboutBox

    ' Flag to track that a lookup was opened
    Public Shared ReturnToLookup As Boolean = False

    Sub Initialize() Implements IDexterityAddIn.Initialize

        Dim LookupHandler As System.EventHandler

        LookupHandler = New System.EventHandler(AddressOf OpenLookupWindow)
        AboutBox.AddMenuHandler(LookupHandler, "Lookups", "")

        ' Select button on the Customers lookup window
        Dim customerLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.CustomerLookupForm = SmartList.Forms.CustomerLookup
        AddHandler customerLookupForm.CustomerLookup.SelectButton.ClickBeforeOriginal, AddressOf CustomerSelectButton_ClickBeforeOriginal

        ' Select button on the Vendors lookup window
        Dim vendorLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.VendorLookupForm = SmartList.Forms.VendorLookup
        AddHandler vendorLookupForm.VendorLookup.SelectButton.ClickBeforeOriginal, AddressOf VendorSelectButton_ClickBeforeOriginal

        ' Select button on the Items lookup window
        Dim itemNumberLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.IvItemNumberLookupForm = SmartList.Forms.IvItemNumberLookup
        AddHandler itemNumberLookupForm.IvItemNumberLookup.SelectButton.ClickBeforeOriginal, AddressOf ItemSelectButton_ClickBeforeOriginal

        ' Select button on the GL Account lookup window
        Dim accountLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.AccountLookupForm = SmartList.Forms.AccountLookup
        AddHandler accountLookupForm.AccountLookup.SelectButton.ClickBeforeOriginal, AddressOf AccountSelectButton_ClickBeforeOriginal

        ' Select button on the SOP Document lookup window
        Dim sopLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.SopDocumentLookupForm = SmartList.Forms.SopDocumentLookup
        AddHandler sopLookupForm.SopDocumentLookup.SelectButton.ClickBeforeOriginal, AddressOf SOPDocumentSelectButton_ClickBeforeOriginal

        ' Select button on the POP Document lookup window
        Dim popLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.PopDocumentLookupForm = SmartList.Forms.PopDocumentLookup
        AddHandler popLookupForm.PopDocumentLookup.SelectButton.ClickBeforeOriginal, AddressOf POPDocumentSelectButton_ClickBeforeOriginal

        ' Validate script that prevents the POP Document lookup window from being displayed
        AddHandler popLookupForm.PopDocumentLookup.PopPoLookup.ValidateBeforeOriginal, AddressOf PopPoLookup_ValidateBeforeOriginal

    End Sub

    Shared Sub OpenLookupWindow(ByVal sender As Object, ByVal e As EventArgs)
        'Open the window that shows the sample lookups
        LookupsWindow = New Lookups()
        LookupsWindow.Show()
    End Sub


    Private Sub CustomerSelectButton_ClickBeforeOriginal(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' Run this code only if the Visual Studio Tools add-in opened the lookup.
        If GPAddIn.ReturnToLookup = True Then
            ' Retrieve the customer number of the row selected in the scrolling window
            ' of the Customers lookup.
            Dim customerLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.CustomerLookupForm = SmartList.Forms.CustomerLookup
            Dim customerNumber As String = customerLookupForm.CustomerLookup.CustomerLookupScroll.CustomerNumber.Value

            ' Display the value retrieved
            LookupsWindow.CustomerNumber.Text = customerNumber

            ' Clear the flag that indicates a value is to be retrieved from the lookup.
            GPAddIn.ReturnToLookup = False
        End If
    End Sub


    Private Sub VendorSelectButton_ClickBeforeOriginal(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' Run this code only if the Visual Studio Tools add-in opened the lookup.
        If GPAddIn.ReturnToLookup = True Then
            ' Retrieve the vendor ID of the row selected in the scrolling window
            ' of the Vendors lookup.
            Dim vendorLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.VendorLookupForm = SmartList.Forms.VendorLookup
            Dim vendorID As String = vendorLookupForm.VendorLookup.VendorLookupScroll.VendorId

            ' Display the value retrieved
            LookupsWindow.VendorID.Text = vendorID

            ' Clear the flag that indicates a value is to be retrieved from the lookup.
            GPAddIn.ReturnToLookup = False
        End If
    End Sub


    Private Sub ItemSelectButton_ClickBeforeOriginal(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' Run this code only if the Visual Studio Tools add-in opened the lookup.
        If GPAddIn.ReturnToLookup = True Then
            ' Retrieve the item number of the row selected in the scrolling window
            ' of the Items lookup.
            Dim itemLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.IvItemNumberLookupForm = SmartList.Forms.IvItemNumberLookup
            Dim itemNumber As String = itemLookupForm.IvItemNumberLookup.IvItemNumberScroll.ItemNumber

            ' Display the value retrieved
            LookupsWindow.ItemNumber.Text = itemNumber

            ' Clear the flag that indicates a value is to be retrieved from the lookup.
            GPAddIn.ReturnToLookup = False
        End If
    End Sub


    Private Sub AccountSelectButton_ClickBeforeOriginal(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' Run this code only if the Visual Studio Tools add-in opened the lookup.
        If GPAddIn.ReturnToLookup = True Then
            ' Retrieve the account number of the row selected in the scrolling window
            ' of the Accounts lookup. The Account Number in Dynamics GP is a composite, 
            ' so an instance of that composite must be created. 
            Dim accountLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.AccountLookupForm = SmartList.Forms.AccountLookup
            Dim accountNumber As Microsoft.Dexterity.Applications.DynamicsDictionary.AccountNumberCompositeData = New Microsoft.Dexterity.Applications.DynamicsDictionary.AccountNumberCompositeData()
            accountNumber = accountLookupForm.AccountLookup.AccountScroll.AccountNumber

            ' Now we have accountNumber, which is the Account Number composite, call a GP function
            ' to return the string for the account number, so it can be displayed on the window.
            ' This technique works for all account structures.  
            Dim accountNumberString As String = Dynamics.Forms.GlAcct.Functions.ConvertAcctToStr.Invoke(accountNumber)

            ' Set the window field to the accountNumberString value
            LookupsWindow.GLAccountNumber.Text = accountNumberString

            ' Clear the flag that indicates a value is to be retrieved from the lookup.
            GPAddIn.ReturnToLookup = False
        End If
    End Sub


    Private Sub SOPDocumentSelectButton_ClickBeforeOriginal(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' Run this code only if the Visual Studio Tools add-in opened the lookup.
        If GPAddIn.ReturnToLookup = True Then
            ' Retrieve the SOP Document number of the row selected in the scrolling window
            ' of the SOP document lookup.
            Dim sopLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.SopDocumentLookupForm = SmartList.Forms.SopDocumentLookup
            Dim sopNumber As String = sopLookupForm.SopDocumentLookup.DocumentScroll.SopNumber

            ' Display the value retrieved
            LookupsWindow.SOPDocumentNumber.Text = sopNumber

            ' Clear the flag that indicates a value is to be retrieved from the lookup.
            GPAddIn.ReturnToLookup = False
        End If
    End Sub


    Private Sub POPDocumentSelectButton_ClickBeforeOriginal(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' Run this code only if the Visual Studio Tools add-in opened the lookup.
        If GPAddIn.ReturnToLookup = True Then
            ' Retrieve the POP document number of the row selected in the scrolling window
            ' of the POP document lookup.
            Dim popLookupForm As Microsoft.Dexterity.Applications.SmartListDictionary.PopDocumentLookupForm = SmartList.Forms.PopDocumentLookup
            Dim popNumber As String = popLookupForm.PopDocumentLookup.DocumentScroll.PoNumber

            ' Display the value retrieved  
            LookupsWindow.POPDocumentNumber.Text = popNumber

            ' Clear the flag that indicates a value is to be retrieved from the lookup.
            GPAddIn.ReturnToLookup = False
        End If
    End Sub


    Private Sub PopPoLookup_ValidateBeforeOriginal(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        ' Due to the way the POP Document Lookup is coded, the ValidateBeforeOriginal event
        ' for the PopPoLookup field must be cancelled when the lookup is called from a Visual
        ' Studio Tools form. If this event is not cancelled, the lookup window is closed 
        ' immediately after opening, preventing the lookup from working properly.
        If GPAddIn.ReturnToLookup = True Then
            e.Cancel = True
        End If
    End Sub


End Class
