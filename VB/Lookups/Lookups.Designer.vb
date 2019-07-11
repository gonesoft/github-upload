<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lookups
    Inherits Microsoft.Dexterity.Shell.DexUIForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lookups))
        Me.CustomerNumber = New System.Windows.Forms.TextBox
        Me.VendorID = New System.Windows.Forms.TextBox
        Me.ItemNumber = New System.Windows.Forms.TextBox
        Me.GLAccountNumber = New System.Windows.Forms.TextBox
        Me.SOPDocumentNumber = New System.Windows.Forms.TextBox
        Me.POPDocumentNumber = New System.Windows.Forms.TextBox
        Me.CustomerLookup = New System.Windows.Forms.Button
        Me.VendorLookup = New System.Windows.Forms.Button
        Me.ItemLookup = New System.Windows.Forms.Button
        Me.GLAccountLookup = New System.Windows.Forms.Button
        Me.SOPDocumentLookup = New System.Windows.Forms.Button
        Me.POPDocumentLookup = New System.Windows.Forms.Button
        Me.labelCustomerNumber = New System.Windows.Forms.Label
        Me.labelVendorID = New System.Windows.Forms.Label
        Me.LabelItemNumber = New System.Windows.Forms.Label
        Me.labelGLAccountNumber = New System.Windows.Forms.Label
        Me.labelSOPDocumentNumber = New System.Windows.Forms.Label
        Me.labelPOPDocumentNumber = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CustomerNumber
        '
        Me.CustomerNumber.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerNumber.Location = New System.Drawing.Point(153, 12)
        Me.CustomerNumber.Name = "CustomerNumber"
        Me.CustomerNumber.Size = New System.Drawing.Size(100, 13)
        Me.CustomerNumber.TabIndex = 0
        '
        'VendorID
        '
        Me.VendorID.BackColor = System.Drawing.SystemColors.Window
        Me.VendorID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorID.Location = New System.Drawing.Point(153, 41)
        Me.VendorID.Name = "VendorID"
        Me.VendorID.Size = New System.Drawing.Size(100, 13)
        Me.VendorID.TabIndex = 1
        '
        'ItemNumber
        '
        Me.ItemNumber.BackColor = System.Drawing.SystemColors.Window
        Me.ItemNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemNumber.Location = New System.Drawing.Point(153, 70)
        Me.ItemNumber.Name = "ItemNumber"
        Me.ItemNumber.Size = New System.Drawing.Size(100, 13)
        Me.ItemNumber.TabIndex = 2
        '
        'GLAccountNumber
        '
        Me.GLAccountNumber.BackColor = System.Drawing.SystemColors.Window
        Me.GLAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GLAccountNumber.Location = New System.Drawing.Point(153, 99)
        Me.GLAccountNumber.Name = "GLAccountNumber"
        Me.GLAccountNumber.Size = New System.Drawing.Size(100, 13)
        Me.GLAccountNumber.TabIndex = 3
        '
        'SOPDocumentNumber
        '
        Me.SOPDocumentNumber.BackColor = System.Drawing.SystemColors.Window
        Me.SOPDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SOPDocumentNumber.Location = New System.Drawing.Point(153, 128)
        Me.SOPDocumentNumber.Name = "SOPDocumentNumber"
        Me.SOPDocumentNumber.Size = New System.Drawing.Size(100, 13)
        Me.SOPDocumentNumber.TabIndex = 4
        '
        'POPDocumentNumber
        '
        Me.POPDocumentNumber.BackColor = System.Drawing.SystemColors.Window
        Me.POPDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.POPDocumentNumber.Location = New System.Drawing.Point(153, 157)
        Me.POPDocumentNumber.Name = "POPDocumentNumber"
        Me.POPDocumentNumber.Size = New System.Drawing.Size(100, 13)
        Me.POPDocumentNumber.TabIndex = 5
        '
        'CustomerLookup
        '
        Me.CustomerLookup.BackColor = System.Drawing.Color.Transparent
        Me.dexButtonProvider.SetButtonType(Me.CustomerLookup, Microsoft.Dexterity.Shell.DexButtonType.Field)
        Me.CustomerLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.CustomerLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CustomerLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CustomerLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerLookup.Image = Global.Lookups.My.Resources.Resources.Field_Lookup
        Me.CustomerLookup.Location = New System.Drawing.Point(255, 8)
        Me.CustomerLookup.Name = "CustomerLookup"
        Me.CustomerLookup.Size = New System.Drawing.Size(20, 20)
        Me.CustomerLookup.TabIndex = 6
        Me.CustomerLookup.TabStop = False
        Me.CustomerLookup.UseVisualStyleBackColor = False
        '
        'VendorLookup
        '
        Me.VendorLookup.BackColor = System.Drawing.Color.Transparent
        Me.dexButtonProvider.SetButtonType(Me.VendorLookup, Microsoft.Dexterity.Shell.DexButtonType.Field)
        Me.VendorLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.VendorLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.VendorLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.VendorLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VendorLookup.Image = CType(resources.GetObject("VendorLookup.Image"), System.Drawing.Image)
        Me.VendorLookup.Location = New System.Drawing.Point(255, 37)
        Me.VendorLookup.Name = "VendorLookup"
        Me.VendorLookup.Size = New System.Drawing.Size(20, 20)
        Me.VendorLookup.TabIndex = 7
        Me.VendorLookup.TabStop = False
        Me.VendorLookup.UseVisualStyleBackColor = False
        '
        'ItemLookup
        '
        Me.ItemLookup.BackColor = System.Drawing.Color.Transparent
        Me.dexButtonProvider.SetButtonType(Me.ItemLookup, Microsoft.Dexterity.Shell.DexButtonType.Field)
        Me.ItemLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.ItemLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ItemLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ItemLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemLookup.Image = CType(resources.GetObject("ItemLookup.Image"), System.Drawing.Image)
        Me.ItemLookup.Location = New System.Drawing.Point(255, 66)
        Me.ItemLookup.Name = "ItemLookup"
        Me.ItemLookup.Size = New System.Drawing.Size(20, 20)
        Me.ItemLookup.TabIndex = 8
        Me.ItemLookup.TabStop = False
        Me.ItemLookup.UseVisualStyleBackColor = False
        '
        'GLAccountLookup
        '
        Me.GLAccountLookup.BackColor = System.Drawing.Color.Transparent
        Me.dexButtonProvider.SetButtonType(Me.GLAccountLookup, Microsoft.Dexterity.Shell.DexButtonType.Field)
        Me.GLAccountLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GLAccountLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.GLAccountLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.GLAccountLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GLAccountLookup.Image = CType(resources.GetObject("GLAccountLookup.Image"), System.Drawing.Image)
        Me.GLAccountLookup.Location = New System.Drawing.Point(255, 95)
        Me.GLAccountLookup.Name = "GLAccountLookup"
        Me.GLAccountLookup.Size = New System.Drawing.Size(20, 20)
        Me.GLAccountLookup.TabIndex = 9
        Me.GLAccountLookup.TabStop = False
        Me.GLAccountLookup.UseVisualStyleBackColor = False
        '
        'SOPDocumentLookup
        '
        Me.SOPDocumentLookup.BackColor = System.Drawing.Color.Transparent
        Me.dexButtonProvider.SetButtonType(Me.SOPDocumentLookup, Microsoft.Dexterity.Shell.DexButtonType.Field)
        Me.SOPDocumentLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.SOPDocumentLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SOPDocumentLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SOPDocumentLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SOPDocumentLookup.Image = CType(resources.GetObject("SOPDocumentLookup.Image"), System.Drawing.Image)
        Me.SOPDocumentLookup.Location = New System.Drawing.Point(255, 124)
        Me.SOPDocumentLookup.Name = "SOPDocumentLookup"
        Me.SOPDocumentLookup.Size = New System.Drawing.Size(20, 20)
        Me.SOPDocumentLookup.TabIndex = 10
        Me.SOPDocumentLookup.TabStop = False
        Me.SOPDocumentLookup.UseVisualStyleBackColor = False
        '
        'POPDocumentLookup
        '
        Me.POPDocumentLookup.BackColor = System.Drawing.Color.Transparent
        Me.dexButtonProvider.SetButtonType(Me.POPDocumentLookup, Microsoft.Dexterity.Shell.DexButtonType.Field)
        Me.POPDocumentLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.POPDocumentLookup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.POPDocumentLookup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.POPDocumentLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.POPDocumentLookup.Image = CType(resources.GetObject("POPDocumentLookup.Image"), System.Drawing.Image)
        Me.POPDocumentLookup.Location = New System.Drawing.Point(255, 153)
        Me.POPDocumentLookup.Name = "POPDocumentLookup"
        Me.POPDocumentLookup.Size = New System.Drawing.Size(20, 20)
        Me.POPDocumentLookup.TabIndex = 11
        Me.POPDocumentLookup.TabStop = False
        Me.POPDocumentLookup.UseVisualStyleBackColor = False
        '
        'labelCustomerNumber
        '
        Me.dexLabelProvider.SetLinkField(Me.labelCustomerNumber, "CustomerNumber")
        Me.labelCustomerNumber.Location = New System.Drawing.Point(13, 12)
        Me.labelCustomerNumber.Name = "labelCustomerNumber"
        Me.labelCustomerNumber.Size = New System.Drawing.Size(100, 13)
        Me.labelCustomerNumber.TabIndex = 12
        Me.labelCustomerNumber.Text = "Customer Number"
        '
        'labelVendorID
        '
        Me.dexLabelProvider.SetLinkField(Me.labelVendorID, "VendorID")
        Me.labelVendorID.Location = New System.Drawing.Point(13, 41)
        Me.labelVendorID.Name = "labelVendorID"
        Me.labelVendorID.Size = New System.Drawing.Size(124, 13)
        Me.labelVendorID.TabIndex = 13
        Me.labelVendorID.Text = "Vendor ID"
        '
        'LabelItemNumber
        '
        Me.dexLabelProvider.SetLinkField(Me.LabelItemNumber, "ItemNumber")
        Me.LabelItemNumber.Location = New System.Drawing.Point(13, 70)
        Me.LabelItemNumber.Name = "LabelItemNumber"
        Me.LabelItemNumber.Size = New System.Drawing.Size(134, 13)
        Me.LabelItemNumber.TabIndex = 14
        Me.LabelItemNumber.Text = "Item Number"
        '
        'labelGLAccountNumber
        '
        Me.dexLabelProvider.SetLinkField(Me.labelGLAccountNumber, "GLAccountNumber")
        Me.labelGLAccountNumber.Location = New System.Drawing.Point(13, 99)
        Me.labelGLAccountNumber.Name = "labelGLAccountNumber"
        Me.labelGLAccountNumber.Size = New System.Drawing.Size(121, 13)
        Me.labelGLAccountNumber.TabIndex = 15
        Me.labelGLAccountNumber.Text = "GL Account Number"
        '
        'labelSOPDocumentNumber
        '
        Me.dexLabelProvider.SetLinkField(Me.labelSOPDocumentNumber, "SOPDocumentNumber")
        Me.labelSOPDocumentNumber.Location = New System.Drawing.Point(13, 128)
        Me.labelSOPDocumentNumber.Name = "labelSOPDocumentNumber"
        Me.labelSOPDocumentNumber.Size = New System.Drawing.Size(128, 13)
        Me.labelSOPDocumentNumber.TabIndex = 16
        Me.labelSOPDocumentNumber.Text = "SOP Document Number"
        '
        'labelPOPDocumentNumber
        '
        Me.dexLabelProvider.SetLinkField(Me.labelPOPDocumentNumber, "POPDocumentNumber")
        Me.labelPOPDocumentNumber.Location = New System.Drawing.Point(13, 157)
        Me.labelPOPDocumentNumber.Name = "labelPOPDocumentNumber"
        Me.labelPOPDocumentNumber.Size = New System.Drawing.Size(131, 13)
        Me.labelPOPDocumentNumber.TabIndex = 17
        Me.labelPOPDocumentNumber.Text = "POP Document Number"
        '
        'Lookups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 193)
        Me.ControlArea = False
        Me.Controls.Add(Me.labelPOPDocumentNumber)
        Me.Controls.Add(Me.labelSOPDocumentNumber)
        Me.Controls.Add(Me.labelGLAccountNumber)
        Me.Controls.Add(Me.LabelItemNumber)
        Me.Controls.Add(Me.labelVendorID)
        Me.Controls.Add(Me.labelCustomerNumber)
        Me.Controls.Add(Me.POPDocumentLookup)
        Me.Controls.Add(Me.SOPDocumentLookup)
        Me.Controls.Add(Me.GLAccountLookup)
        Me.Controls.Add(Me.ItemLookup)
        Me.Controls.Add(Me.VendorLookup)
        Me.Controls.Add(Me.CustomerLookup)
        Me.Controls.Add(Me.POPDocumentNumber)
        Me.Controls.Add(Me.SOPDocumentNumber)
        Me.Controls.Add(Me.GLAccountNumber)
        Me.Controls.Add(Me.ItemNumber)
        Me.Controls.Add(Me.VendorID)
        Me.Controls.Add(Me.CustomerNumber)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "Lookups"
        Me.StatusArea = False
        Me.Text = "Lookups"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerNumber As System.Windows.Forms.TextBox
    Friend WithEvents VendorID As System.Windows.Forms.TextBox
    Friend WithEvents ItemNumber As System.Windows.Forms.TextBox
    Friend WithEvents GLAccountNumber As System.Windows.Forms.TextBox
    Friend WithEvents SOPDocumentNumber As System.Windows.Forms.TextBox
    Friend WithEvents POPDocumentNumber As System.Windows.Forms.TextBox
    Friend WithEvents CustomerLookup As System.Windows.Forms.Button
    Friend WithEvents VendorLookup As System.Windows.Forms.Button
    Friend WithEvents ItemLookup As System.Windows.Forms.Button
    Friend WithEvents GLAccountLookup As System.Windows.Forms.Button
    Friend WithEvents SOPDocumentLookup As System.Windows.Forms.Button
    Friend WithEvents POPDocumentLookup As System.Windows.Forms.Button
    Friend WithEvents labelCustomerNumber As System.Windows.Forms.Label
    Friend WithEvents labelVendorID As System.Windows.Forms.Label
    Friend WithEvents LabelItemNumber As System.Windows.Forms.Label
    Friend WithEvents labelGLAccountNumber As System.Windows.Forms.Label
    Friend WithEvents labelSOPDocumentNumber As System.Windows.Forms.Label
    Friend WithEvents labelPOPDocumentNumber As System.Windows.Forms.Label
End Class
