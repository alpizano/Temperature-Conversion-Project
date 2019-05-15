Public Class Form1
    Private Sub txtFrom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrom.KeyPress
        'Only numeric 0-9, backspace, dash for negative sign (-), and decimal point (.) allowed in textbox
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True
        End If
        'Makes sure only one decimal point allowed
        If (txtFrom.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then e.Handled = True


    End Sub



    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Initialize variables
        Dim fromVal As Double = 0 'Value inside From textbox
        Dim answer As Double = 0.0 'Result displayed inside To textbox
        Dim drpDownSelect1 = Nothing
        Dim drpDownSelect2 = Nothing
        Dim rounded_ans As Double = 0

        'Error Handling
        'Get values from both Drop-down boxes and store inside variables IF NOT NULL (else null object reference and throws Error 10001)
        If Not drpDown1.SelectedIndex = -1 And Not drpDown2.SelectedIndex = -1 Then
            drpDownSelect1 = drpDown1.SelectedItem.ToString()
            drpDownSelect2 = drpDown2.SelectedItem.ToString()
        Else
            MessageBox.Show("Please select temperature units to convert from and to.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Console.WriteLine("Drop down 1 selected item is: " & drpDownSelect1)
        Console.WriteLine("Drop down 2 selected item is: " & drpDownSelect2)

        Select Case drpDownSelect1
                'Fahrenheit case
            Case Is = "FAHRENHEIT"
                If drpDownSelect2 = "CELSIUS" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal - 32) * 5 / 9 'Converting to Celsius
                    rounded_ans = Math.Round(answer, 2)
                    txtTo.Text = rounded_ans
                ElseIf drpDownSelect2 = "KELVIN" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal - 32) * 5 / 9 + 273.15 'Converting to Kelvin
                    rounded_ans = Math.Round(answer, 2)
                    txtTo.Text = rounded_ans
                Else
                    txtTo.Text = txtFrom.Text 'Same value
                End If

                'Celsius case   
            Case Is = "CELSIUS"
                If drpDownSelect2 = "FAHRENHEIT" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal * 9 / 5) + 32 'Converting to Celsius
                    rounded_ans = Math.Round(answer, 2)
                    txtTo.Text = rounded_ans
                ElseIf drpDownSelect2 = "KELVIN" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = fromVal + 273.15 'Converting to Kelvin
                    rounded_ans = Math.Round(answer, 2)
                    txtTo.Text = rounded_ans
                Else
                    txtTo.Text = txtFrom.Text 'Same value           
                End If

                'Kelvin case 
            Case Is = "KELVIN"
                If drpDownSelect2 = "FAHRENHEIT" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal - 273.15) * 9 / 5 + 32
                    rounded_ans = Math.Round(answer, 2)
                    txtTo.Text = rounded_ans
                ElseIf drpDownSelect2 = "CELSIUS" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = fromVal - 273.15
                    rounded_ans = Math.Round(answer, 2)
                    txtTo.Text = rounded_ans
                Else
                    txtTo.Text = txtFrom.Text 'Same value
                End If
        End Select



    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'To clear all textbox and drop-down fields
        txtFrom.Text = Nothing
        txtTo.Text = Nothing
        drpDown1.SelectedIndex = -1
        drpDown2.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
End Class
