<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.drpDown1 = New System.Windows.Forms.ComboBox()
        Me.drpDown2 = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'drpDown1
        '
        Me.drpDown1.FormattingEnabled = True
        Me.drpDown1.Items.AddRange(New Object() {"FAHRENHEIT", "CELSIUS", "KELVIN"})
        Me.drpDown1.Location = New System.Drawing.Point(164, 24)
        Me.drpDown1.Name = "drpDown1"
        Me.drpDown1.Size = New System.Drawing.Size(121, 21)
        Me.drpDown1.TabIndex = 0
        '
        'drpDown2
        '
        Me.drpDown2.FormattingEnabled = True
        Me.drpDown2.Items.AddRange(New Object() {"FAHRENHEIT", "CELSIUS", "KELVIN"})
        Me.drpDown2.Location = New System.Drawing.Point(164, 49)
        Me.drpDown2.Name = "drpDown2"
        Me.drpDown2.Size = New System.Drawing.Size(121, 21)
        Me.drpDown2.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(16, 87)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(114, 87)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(210, 86)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(12, 27)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 5
        Me.lblFrom.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(12, 53)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "To:"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(59, 24)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtFrom.TabIndex = 7
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(58, 50)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(100, 20)
        Me.txtTo.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 122)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.drpDown2)
        Me.Controls.Add(Me.drpDown1)
        Me.Name = "Form1"
        Me.Text = "TemperatureConversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents drpDown1 As ComboBox
    Friend WithEvents drpDown2 As ComboBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox
End Class
