Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Dim prices As New Dictionary(Of String, Integer) From {
        {"Espresso", 120},
        {"Latte", 150},
        {"Cappuccino", 160},
        {"Americano", 130},
        {"Mocha", 170}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbMenu.Items.Clear()
        For Each drink In prices.Keys
            cmbMenu.Items.Add(drink)
        Next


        NumericUpDown1.Minimum = 1
        NumericUpDown1.Value = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        If txtName.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If cmbMenu.SelectedIndex = -1 Then
            MessageBox.Show("Please select a beverage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim selectedDrink As String = cmbMenu.SelectedItem.ToString()
        Dim qty As Integer = NumericUpDown1.Value
        Dim price As Integer = prices(selectedDrink)


        Dim subtotal As Integer = price * qty


        Dim discount As Integer = 0
        If cbDiscount.Checked Then
            discount = subtotal * 0.2
        End If


        Dim finalTotal As Integer = subtotal - discount


        lblSubtotal.Text = "Subtotal: " & subtotal.ToString() & " PHP"
        lblDiscount.Text = "Discount: " & discount.ToString() & " PHP"
        lblFinal.Text = "Final Total: " & finalTotal.ToString() & " PHP"


        Dim receipt As String =
            "====== ORDER RECEIPT =====" & vbCrLf &
            "Customer: " & txtName.Text & vbCrLf &
            "Beverage: " & selectedDrink & vbCrLf &
            "Quantity: " & qty.ToString() & vbCrLf &
            "Price: " & price.ToString() & " PHP" & vbCrLf &
            "-------------------------" & vbCrLf &
            "Subtotal: " & subtotal.ToString() & " PHP" & vbCrLf &
            "Discount: " & discount.ToString() & " PHP" & vbCrLf &
            "Final Total: " & finalTotal.ToString() & " PHP" & vbCrLf &
            "-------------------------" & vbCrLf &
            "Thank you for your order!"

        MessageBox.Show(receipt, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
