<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureConversion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.cboFrom = New System.Windows.Forms.ComboBox()
    Me.cboTo = New System.Windows.Forms.ComboBox()
    Me.btnConvert = New System.Windows.Forms.Button()
    Me.btnReset = New System.Windows.Forms.Button()
    Me.btnExit = New System.Windows.Forms.Button()
    Me.lblFrom = New System.Windows.Forms.Label()
    Me.lblTo = New System.Windows.Forms.Label()
    Me.txtFrom = New System.Windows.Forms.TextBox()
    Me.lblOutput = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'cboFrom
    '
    Me.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFrom.FormattingEnabled = True
    Me.cboFrom.Items.AddRange(New Object() {"FAHRENHEIT", "CELSIUS", "KELVIN"})
    Me.cboFrom.Location = New System.Drawing.Point(164, 24)
    Me.cboFrom.Name = "cboFrom"
    Me.cboFrom.Size = New System.Drawing.Size(121, 21)
    Me.cboFrom.TabIndex = 2
    '
    'cboTo
    '
    Me.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTo.FormattingEnabled = True
    Me.cboTo.Items.AddRange(New Object() {"FAHRENHEIT", "CELSIUS", "KELVIN"})
    Me.cboTo.Location = New System.Drawing.Point(164, 49)
    Me.cboTo.Name = "cboTo"
    Me.cboTo.Size = New System.Drawing.Size(121, 21)
    Me.cboTo.TabIndex = 5
    '
    'btnConvert
    '
    Me.btnConvert.Location = New System.Drawing.Point(16, 87)
    Me.btnConvert.Name = "btnConvert"
    Me.btnConvert.Size = New System.Drawing.Size(75, 23)
    Me.btnConvert.TabIndex = 6
    Me.btnConvert.Text = "&Convert"
    Me.btnConvert.UseVisualStyleBackColor = True
    '
    'btnReset
    '
    Me.btnReset.Location = New System.Drawing.Point(114, 87)
    Me.btnReset.Name = "btnReset"
    Me.btnReset.Size = New System.Drawing.Size(75, 23)
    Me.btnReset.TabIndex = 7
    Me.btnReset.Text = "&Reset"
    Me.btnReset.UseVisualStyleBackColor = True
    '
    'btnExit
    '
    Me.btnExit.Location = New System.Drawing.Point(210, 86)
    Me.btnExit.Name = "btnExit"
    Me.btnExit.Size = New System.Drawing.Size(75, 23)
    Me.btnExit.TabIndex = 8
    Me.btnExit.Text = "&Exit"
    Me.btnExit.UseVisualStyleBackColor = True
    '
    'lblFrom
    '
    Me.lblFrom.AutoSize = True
    Me.lblFrom.Location = New System.Drawing.Point(12, 27)
    Me.lblFrom.Name = "lblFrom"
    Me.lblFrom.Size = New System.Drawing.Size(33, 13)
    Me.lblFrom.TabIndex = 0
    Me.lblFrom.Text = "From:"
    '
    'lblTo
    '
    Me.lblTo.AutoSize = True
    Me.lblTo.Location = New System.Drawing.Point(12, 53)
    Me.lblTo.Name = "lblTo"
    Me.lblTo.Size = New System.Drawing.Size(23, 13)
    Me.lblTo.TabIndex = 3
    Me.lblTo.Text = "To:"
    '
    'txtFrom
    '
    Me.txtFrom.Location = New System.Drawing.Point(59, 24)
    Me.txtFrom.Name = "txtFrom"
    Me.txtFrom.ShortcutsEnabled = False
    Me.txtFrom.Size = New System.Drawing.Size(100, 20)
    Me.txtFrom.TabIndex = 1
    '
    'lblOutput
    '
    Me.lblOutput.AutoSize = True
    Me.lblOutput.BackColor = System.Drawing.SystemColors.Window
    Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.lblOutput.Location = New System.Drawing.Point(59, 49)
    Me.lblOutput.MaximumSize = New System.Drawing.Size(100, 15)
    Me.lblOutput.MinimumSize = New System.Drawing.Size(100, 20)
    Me.lblOutput.Name = "lblOutput"
    Me.lblOutput.Size = New System.Drawing.Size(100, 20)
    Me.lblOutput.TabIndex = 4
    '
    'TemperatureConversion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(297, 122)
    Me.Controls.Add(Me.lblOutput)
    Me.Controls.Add(Me.txtFrom)
    Me.Controls.Add(Me.lblTo)
    Me.Controls.Add(Me.lblFrom)
    Me.Controls.Add(Me.btnExit)
    Me.Controls.Add(Me.btnReset)
    Me.Controls.Add(Me.btnConvert)
    Me.Controls.Add(Me.cboTo)
    Me.Controls.Add(Me.cboFrom)
    Me.MaximumSize = New System.Drawing.Size(313, 161)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(313, 161)
    Me.Name = "TemperatureConversion"
    Me.Text = "Temperature Conversion"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cboFrom As ComboBox
  Friend WithEvents cboTo As ComboBox
  Friend WithEvents btnConvert As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents txtFrom As TextBox
  Friend WithEvents lblOutput As Label
End Class
