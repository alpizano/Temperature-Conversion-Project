Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim fromVal As Double = 0 'Value inside From textbox
        Dim answer As Double = 0.0 'Result displayed inside To textbox

        'Get values from both Drop-down boxes and store inside variables
        Dim drpDownSelect1 = drpDown1.SelectedItem.ToString()
        Dim drpDownSelect2 = drpDown2.SelectedItem.ToString()

        Console.WriteLine("Drop down 1 selected item is: " & drpDownSelect1)
        Console.WriteLine("Drop down 2 selected item is: " & drpDownSelect2)


        Select Case drpDownSelect1
                'Fahrenheit case
            Case Is = "FAHRENHEIT"
                If drpDownSelect2 = "CELSIUS" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal - 32) * 5 / 9 'Converting to Celsius
                    txtTo.Text = answer
                ElseIf drpDownSelect2 = "KELVIN" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal - 32) * 5 / 9 + 273.15 'Converting to Kelvin
                    txtTo.Text = answer
                Else
                    txtTo.Text = txtFrom.Text 'Same value
                End If

                'Celsius case   
            Case Is = "CELSIUS"
                If drpDownSelect2 = "FAHRENHEIT" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal * 9 / 5) + 32 'Converting to Celsius
                    txtTo.Text = answer
                ElseIf drpDownSelect2 = "KELVIN" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = fromVal + 273.15 'Converting to Kelvin
                    txtTo.Text = answer
                Else
                    txtTo.Text = txtFrom.Text 'Same value           
                End If

                'Kelvin case 
            Case Else
                If drpDownSelect2 = "FAHRENHEIT" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = (fromVal - 273.15) * 9 / 5 + 32
                    txtTo.Text = answer
                ElseIf drpDownSelect2 = "CELSIUS" Then
                    fromVal = txtFrom.Text
                    Console.WriteLine("From value text box is: " & fromVal)
                    answer = fromVal - 273.15
                    txtTo.Text = answer
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
End Class
