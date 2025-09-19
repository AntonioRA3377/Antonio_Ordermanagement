<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtName = New TextBox()
        cmbMenu = New ComboBox()
        NumericUpDown1 = New NumericUpDown()
        cbDiscount = New CheckBox()
        btnOrder = New Button()
        lblName = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblSubtotal = New Label()
        lblDiscount = New Label()
        lblFinal = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(147, 25)
        txtName.Name = "txtName"
        txtName.Size = New Size(137, 23)
        txtName.TabIndex = 0
        ' 
        ' cmbMenu
        ' 
        cmbMenu.FormattingEnabled = True
        cmbMenu.Items.AddRange(New Object() {"Espresso: 120 PHP", "Latte: 150 PHP", "Cappuccino: 160 PHP", "Americano: 130 PHP", "Mocha: 170 PHP"})
        cmbMenu.Location = New Point(301, 25)
        cmbMenu.Name = "cmbMenu"
        cmbMenu.Size = New Size(118, 23)
        cmbMenu.TabIndex = 1
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(425, 26)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(118, 23)
        NumericUpDown1.TabIndex = 2
        ' 
        ' cbDiscount
        ' 
        cbDiscount.AutoSize = True
        cbDiscount.Location = New Point(156, 85)
        cbDiscount.Name = "cbDiscount"
        cbDiscount.Size = New Size(148, 19)
        cbDiscount.TabIndex = 3
        cbDiscount.Text = "Apply Loyalty Discount"
        cbDiscount.UseVisualStyleBackColor = True
        ' 
        ' btnOrder
        ' 
        btnOrder.Location = New Point(156, 155)
        btnOrder.Name = "btnOrder"
        btnOrder.Size = New Size(118, 29)
        btnOrder.TabIndex = 4
        btnOrder.Text = "PLACE ORDER"
        btnOrder.UseVisualStyleBackColor = True
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(147, 9)
        lblName.Name = "lblName"
        lblName.Size = New Size(105, 15)
        lblName.TabIndex = 5
        lblName.Text = "Customer's Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(301, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 15)
        Label2.TabIndex = 6
        Label2.Text = "Select a Beverage:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(425, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 7
        Label3.Text = "Quantity:"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(156, 107)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(54, 15)
        lblSubtotal.TabIndex = 8
        lblSubtotal.Text = "Subtotal:"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Location = New Point(156, 122)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(57, 15)
        lblDiscount.TabIndex = 9
        lblDiscount.Text = "Discount:"
        ' 
        ' lblFinal
        ' 
        lblFinal.AutoSize = True
        lblFinal.Location = New Point(156, 137)
        lblFinal.Name = "lblFinal"
        lblFinal.Size = New Size(63, 15)
        lblFinal.TabIndex = 10
        lblFinal.Text = "Final Total:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblFinal)
        Controls.Add(lblDiscount)
        Controls.Add(lblSubtotal)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblName)
        Controls.Add(btnOrder)
        Controls.Add(cbDiscount)
        Controls.Add(NumericUpDown1)
        Controls.Add(cmbMenu)
        Controls.Add(txtName)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents cbDiscount As CheckBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblFinal As Label

End Class
