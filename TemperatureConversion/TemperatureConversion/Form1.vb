Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim fromVal As Integer = txtFrom.Text 'Value inside From textbox
        Dim answer As Double = 0.0 'Result displayed inside To textbox

        'Get values from both Drop-down boxes and store inside variables
        Dim drpDownSelect1 = drpDown1.SelectedItem.ToString()
        Dim drpDownSelect2 = drpDown2.SelectedItem.ToString()

        Console.WriteLine("Drop down 1 selected item is: " & drpDownSelect1)
        Console.WriteLine("Drop down 2 selected item is: " & drpDownSelect2)



        'Fahrenheit conditions
        If drpDownSelect1 = "FAHRENHEIT" And drpDownSelect2 = "CELSIUS" Then
            Console.WriteLine("From value text box is: " & fromVal)
            answer = (fromVal - 32) * 5 / 9 'Converting to Celsius
            txtTo.Text = answer
        ElseIf drpDownSelect1 = "FAHRENHEIT" And drpDownSelect2 = "KELVIN" Then
            fromVal = txtFrom.Text
            Console.WriteLine("From value text box is: " & fromVal)
            answer = (fromVal - 32) * 5 / 9 + 273.15 'Converting to Kelvin
            txtTo.Text = answer
        ElseIf drpDownSelect1 = "FAHRENHEIT" And drpDownSelect2 = "FAHRENHEIT" Then
            txtTo.Text = txtFrom.Text 'Same value

            'Celsius conditions
        ElseIf drpDownSelect1 = "CELSIUS" And drpDownSelect2 = "FAHRENHEIT" Then
            Console.WriteLine("From value text box is: " & fromVal)
            answer = (fromVal * 9 / 5) + 32 'Converting to Celsius
            txtTo.Text = answer
        ElseIf drpDownSelect1 = "CELSIUS" And drpDownSelect2 = "KELVIN" Then
            fromVal = txtFrom.Text
            Console.WriteLine("From value text box is: " & fromVal)
            answer = fromVal + 273.15 'Converting to Kelvin
            txtTo.Text = answer
        ElseIf drpDownSelect1 = "CELSIUS" And drpDownSelect2 = "CELSIUS" Then
            txtTo.Text = txtFrom.Text 'Same value
            'Kelvin conditions
        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'To clear all textbox and drop-down fields
        txtFrom.Text = Nothing
        txtTo.Text = Nothing
        drpDown1.SelectedIndex = -1
        drpDown2.SelectedIndex = -1
    End Sub
End Class
