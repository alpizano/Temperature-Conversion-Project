Public Class Form1
    Private Sub txtFrom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrom.KeyPress
        'Makes sure only numeric 0-9, backspace, dash for negative sign (-), and decimal point (.) allowed in TextBox
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
            e.Handled = True
        End If

        'Makes sure only one decimal point (.) allowed in TextBox
        If (txtFrom.Text.IndexOf(".") >= 0 And e.KeyChar = ".") Then
            e.Handled = True
        End If

        'Makes sure dash (-) only allowed at index 0 of TextBox
        If txtFrom.SelectionStart <> 0 And e.KeyChar = "-" And txtFrom.Text.IndexOf("-") >= 0 Then
            e.Handled = True
        End If
    End Sub



    'EventHandler for Convert button
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Initialize variables
        Dim dValueOfTxtBoxFrom As Double = 0
        Dim sDrpDownSelect1 = Nothing
        Dim sDrpDownSelect2 = Nothing

        'Error Handling
        'Get values from both Drop-down boxes and store inside variables If Not NULL (Else NULL object reference throws Error 10001)
        If Not drpDown1.SelectedIndex = -1 And Not drpDown2.SelectedIndex = -1 Then

            sDrpDownSelect1 = drpDown1.SelectedItem.ToString()
            sDrpDownSelect2 = drpDown2.SelectedItem.ToString()
        Else
            MessageBox.Show("Please select temperature units to convert from and to.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Select Case sDrpDownSelect1
                'Fahrenheit case
            Case Is = "FAHRENHEIT"
                If sDrpDownSelect2 = "CELSIUS" Then
                    dValueOfTxtBoxFrom = txtFrom.Text
                    txtTo.Text = FahrToCel(dValueOfTxtBoxFrom)
                ElseIf sDrpDownSelect2 = "KELVIN" Then
                    dValueOfTxtBoxFrom = txtFrom.Text
                    txtTo.Text = FahrToKelv(dValueOfTxtBoxFrom)
                Else
                    txtTo.Text = txtFrom.Text
                End If

                'Celsius case  
            Case Is = "CELSIUS"
                If sDrpDownSelect2 = "FAHRENHEIT" Then
                    dValueOfTxtBoxFrom = txtFrom.Text
                    txtTo.Text = CelToFahr(dValueOfTxtBoxFrom)
                ElseIf sDrpDownSelect2 = "KELVIN" Then
                    dValueOfTxtBoxFrom = txtFrom.Text
                    txtTo.Text = CelToKelv(dValueOfTxtBoxFrom)
                Else
                    txtTo.Text = txtFrom.Text
                End If

                'Kelvin case
            Case Is = "KELVIN"
                If sDrpDownSelect2 = "FAHRENHEIT" Then
                    dValueOfTxtBoxFrom = txtFrom.Text
                    txtTo.Text = KelvToFahr(dValueOfTxtBoxFrom)
                ElseIf sDrpDownSelect2 = "CELSIUS" Then
                    dValueOfTxtBoxFrom = txtFrom.Text
                    txtTo.Text = KelvToCel(dValueOfTxtBoxFrom)
                Else
                    txtTo.Text = txtFrom.Text
                End If
        End Select
    End Sub



    'EventHandler for Reset button. Clears all TextBoxes and Drop-down fields
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFrom.Text = Nothing
        txtTo.Text = Nothing
        drpDown1.SelectedIndex = -1
        drpDown2.SelectedIndex = -1
    End Sub



    'EventHandler for Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub



    'Functions for mathematical conversions
    Function FahrToCel(dNum As Double) As Double
        Dim dAns = (dNum - 32) * 5 / 9
        dAns = Math.Round(dAns, 2)

        Return dAns
    End Function

    Function FahrToKelv(dNum As Double) As Double
        Dim dAns = (dNum - 32) * 5 / 9 + 273.15
        dAns = Math.Round(dAns, 2)

        Return dAns
    End Function

    Function CelToFahr(dNum As Double) As Double
        Dim dAns = (dNum * 9 / 5) + 32
        dAns = Math.Round(dAns, 2)

        Return dAns
    End Function

    Function CelToKelv(dNum As Double) As Double
        Dim dAns = dNum + 273.15
        dAns = Math.Round(dAns, 2)

        Return dAns
    End Function

    Function KelvToFahr(dNum As Double) As Double
        Dim dAns = (dNum - 273.15) * 9 / 5 + 32
        dAns = Math.Round(dAns, 2)

        Return dAns
    End Function

    Function KelvToCel(dNum As Double) As Double
        Dim dAns = dNum - 273.15
        dAns = Math.Round(dAns, 2)

        Return dAns
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
