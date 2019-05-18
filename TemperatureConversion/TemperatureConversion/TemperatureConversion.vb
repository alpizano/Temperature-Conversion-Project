' Copyright (c) 2019 Applied Systems, Inc.
'

''' -----------------------------------------------------------------------------
''' Project     : TemperatureConversion
''' Class       : TemperatureConversion
'''
''' This project is for intern Alberto Pizano's code review.
'''
''' -----------------------------------------------------------------------------
''' <summary>
'''   First project from BusProd Developer Training/Temp Conversion on appliedwiki.
''' </summary>
''' <remarks>
''' </remarks>
''' <history>
'''     [apizano]       5/17/2019       Fixed all errors presented at code review.
'''     [apizano]       5/16/2019       Reformated comments.
'''     [apizano]       5/15/2019       Checked-in code to TFS source control.
''' </history>
''' -----------------------------------------------------------------------------

Public Class TemperatureConversion

  Enum Temp
    F
    C
    K
  End Enum

  Private Sub txtFrom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrom.KeyPress
    'If statement Makes sure only numeric 0-9, backspace, dash for negative sign (-), and decimal point (.) characters allowed in TextBox.
    If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-" Then
      e.Handled = True
    End If

    'If statement makes sure total of one decimal point (.) is allowed in TextBox.
    If txtFrom.Text.IndexOf(".") >= 0 And e.KeyChar = "." Then
      e.Handled = True
    End If

    'If statement to make sure dash (-) only allowed at index 0 of TextBox.
    If Not String.IsNullOrEmpty(txtFrom.Text) And e.KeyChar = "-" Then
      e.Handled = True
    End If
  End Sub

  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    txtFrom.Text = String.Empty
    lblOutput.Text = String.Empty
    cboFrom.SelectedIndex = -1
    cboTo.SelectedIndex = -1
  End Sub

  Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel) = DialogResult.OK Then
      Application.Exit()
    End If
  End Sub

  Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
    'Initializes temperature input to "From:" TextBox to Double variable type.
    Dim dValueOfTxtBoxFrom As Double = 0

    'Error Handling for Drop-down boxes.
    'Get values from both Drop-down boxes and store inside variables if not NULL. Else throws NULL object reference Error 10001.
    If cboFrom.SelectedIndex = -1 AndAlso cboTo.SelectedIndex = -1 And Not String.IsNullOrEmpty(txtFrom.Text) Then
      MessageBox.Show("Please select temperature units to convert from and to.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      cboFrom.Select()
    ElseIf cboFrom.SelectedIndex = -1 AndAlso cboTo.SelectedIndex <> -1 And Not String.IsNullOrEmpty(txtFrom.Text) Then
      MessageBox.Show("Please select temperature units to convert from and to.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      cboFrom.Select()
    ElseIf cboTo.SelectedIndex = -1 AndAlso cboFrom.SelectedIndex <> -1 And Not String.IsNullOrEmpty(txtFrom.Text) Then
      MessageBox.Show("Please select temperature units to convert from and to.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      cboTo.Select()
    ElseIf cboFrom.SelectedIndex = -1 AndAlso cboTo.SelectedIndex = -1 And String.IsNullOrEmpty(txtFrom.Text) Then
      MessageBox.Show("Please select temperature units to convert from and to and input a temperature for conversion.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      txtFrom.Select()
    ElseIf cboFrom.SelectedIndex = -1 AndAlso cboTo.SelectedIndex <> -1 And String.IsNullOrEmpty(txtFrom.Text) Then
      MessageBox.Show("Please select temperature units to convert from and to and input a temperature for conversion.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      cboFrom.Select()
    ElseIf cboTo.SelectedIndex = -1 AndAlso cboFrom.SelectedIndex <> -1 And String.IsNullOrEmpty(txtFrom.Text) Then
      MessageBox.Show("Please select temperature units to convert from and to and input a temperature for conversion.", "Error: 10001", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      cboTo.Select()
    End If

    'Main logic temperature conversion program. Selects which operation to perform depending on which sDrpDownSelect1 value (FAHRENHEIT, CELSIUS, KELVIN) is selected.
    'Performs appropriate mathematical conversion depending on which sDrpDownSelect2 value (FAHRENHEIT, CELSIUS, KELVIN) is selected.
    'If cboFrom.SelectedIndex <> -1 And cboTo.SelectedIndex <> -1 And cboFrom.SelectedIndex <> cboTo.SelectedIndex Then
    If cboFrom.SelectedIndex = cboTo.SelectedIndex AndAlso cboFrom.SelectedIndex <> -1 AndAlso cboTo.SelectedIndex <> -1 Then
      lblOutput.Text = txtFrom.Text

      'ElseIf cboFrom.SelectedIndex = cboTo.SelectedIndex And cboFrom.SelectedIndex <> -1 And cboTo.SelectedIndex <> -1 Then
    ElseIf cboFrom.SelectedIndex <> -1 AndAlso cboTo.SelectedIndex <> -1 AndAlso cboFrom.SelectedIndex <> cboTo.SelectedIndex Then
      Select Case cboFrom.SelectedIndex
        Case Temp.F
          If cboTo.SelectedIndex = Temp.C Then
            dValueOfTxtBoxFrom = CType(txtFrom.Text, Double)
            Try
              lblOutput.Text = CType(FahrToCel(dValueOfTxtBoxFrom), String)
            Catch ex1 As ArithmeticException
              Console.WriteLine(ex1.Message)
            End Try
          Else
            dValueOfTxtBoxFrom = CType(txtFrom.Text, Double)
            Try
              lblOutput.Text = CType(FahrToKelv(dValueOfTxtBoxFrom), String)
            Catch ex2 As ArithmeticException
              Console.WriteLine(ex2.Message)
            End Try
          End If
        Case Temp.C
          If cboTo.SelectedIndex = Temp.F Then
            dValueOfTxtBoxFrom = CType(txtFrom.Text, Double)
            Try
              lblOutput.Text = CType(CelToFahr(dValueOfTxtBoxFrom), String)
            Catch ex3 As ArithmeticException
              Console.WriteLine(ex3.Message)
            End Try
          Else
            dValueOfTxtBoxFrom = CType(txtFrom.Text, Double)
            Try
              lblOutput.Text = CType(CelToKelv(dValueOfTxtBoxFrom), String)
            Catch ex4 As ArithmeticException
              Console.WriteLine(ex4.Message)
            End Try
          End If
        Case Temp.K
          If cboTo.SelectedIndex = Temp.F Then
            dValueOfTxtBoxFrom = CType(txtFrom.Text, Double)
            Try
              lblOutput.Text = CType(KelvToFahr(dValueOfTxtBoxFrom), String)
            Catch ex5 As ArithmeticException
              Console.WriteLine(ex5.Message)
            End Try
          Else
            dValueOfTxtBoxFrom = CType(txtFrom.Text, Double)
            Try
              lblOutput.Text = CType(KelvToCel(dValueOfTxtBoxFrom), String)
            Catch ex6 As ArithmeticException
              Console.WriteLine(ex6.Message)
            End Try
          End If
      End Select
    End If
  End Sub


  ''' <summary>
  '''   Mathematical conversion formula to convert FAHRENHEIT to CELSIUS that is called within main logic above Select...Case statements.
  ''' </summary>
  ''' <param name="dNum">The double temperature value from the "From:" TextBox that will be used for conversion.</param>
  ''' <remarks>
  ''' </remarks>
  Dim dAns As Double = 0
  Function FahrToCel(dNum As Double) As Double
    dAns = (dNum - 32) * 5 / 9
    dAns = Math.Round(dAns, 2)
    Return dAns
  End Function

  ''' <summary>
  '''   Mathematical conversion formula to convert FAHRENHEIT to KELVIN that is called within main logic above Select...Case statements.
  ''' </summary>
  ''' <param name="dNum">The double temperature value from the "From:" TextBox that will be used for conversion.</param>
  ''' <remarks>
  ''' </remarks>
  Function FahrToKelv(dNum As Double) As Double
    dAns = (dNum - 32) * 5 / 9 + 273.15
    dAns = Math.Round(dAns, 2)
    Return dAns
  End Function

  ''' <summary>
  '''   Mathematical conversion formula to convert CELSIUS to FAHRENHEIT that is called within main logic above Select...Case statements.
  ''' </summary>
  ''' <param name="dNum">The double temperature value from the "From:" TextBox that will be used for conversion.</param>
  ''' <remarks>
  ''' </remarks>
  Function CelToFahr(dNum As Double) As Double
    dAns = (dNum * 9 / 5) + 32
    dAns = Math.Round(dAns, 2)
    Return dAns
  End Function

  ''' <summary>
  '''   Mathematical conversion formula to convert CELSIUS to KELVIN that is called within main logic above Select...Case statements.
  ''' </summary>
  ''' <param name="dNum">The double temperature value from the "From:" TextBox that will be used for conversion.</param>
  ''' <remarks>
  ''' </remarks>
  Function CelToKelv(dNum As Double) As Double
    dAns = dNum + 273.15
    dAns = Math.Round(dAns, 2)
    Return dAns
  End Function

  ''' <summary>
  '''   Mathematical conversion formula to convert KELVIN to FAHRENHEIT that is called within main logic above Select...Case statements.
  ''' </summary>
  ''' <param name="dNum">The double temperature value from the "From:" TextBox that will be used for conversion.</param>
  ''' <remarks>
  ''' </remarks>
  Function KelvToFahr(dNum As Double) As Double
    dAns = (dNum - 273.15) * 9 / 5 + 32
    dAns = Math.Round(dAns, 2)
    Return dAns
  End Function

  ''' <summary>
  '''   Mathematical conversion formula to convert KELVIN to CELSIUS that is called within main logic above Select...Case statements.
  ''' </summary>
  ''' <param name="dNum">The double temperature value from the "From:" TextBox that will be used for conversion.</param>
  ''' <remarks>
  ''' </remarks>
  Function KelvToCel(dNum As Double) As Double
    dAns = dNum - 273.15
    dAns = Math.Round(dAns, 2)
    Return dAns
  End Function
End Class