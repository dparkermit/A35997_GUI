<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TextBoxLinearFactor = New System.Windows.Forms.TextBox()
        Me.TextBoxConstantFactor = New System.Windows.Forms.TextBox()
        Me.TextBoxSquaredFactor = New System.Windows.Forms.TextBox()
        Me.ButtonReadControlCal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonWriteControlCal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxLinearFactor
        '
        Me.TextBoxLinearFactor.Location = New System.Drawing.Point(47, 44)
        Me.TextBoxLinearFactor.Name = "TextBoxLinearFactor"
        Me.TextBoxLinearFactor.Size = New System.Drawing.Size(65, 20)
        Me.TextBoxLinearFactor.TabIndex = 1
        '
        'TextBoxConstantFactor
        '
        Me.TextBoxConstantFactor.Location = New System.Drawing.Point(47, 73)
        Me.TextBoxConstantFactor.Name = "TextBoxConstantFactor"
        Me.TextBoxConstantFactor.Size = New System.Drawing.Size(65, 20)
        Me.TextBoxConstantFactor.TabIndex = 3
        '
        'TextBoxSquaredFactor
        '
        Me.TextBoxSquaredFactor.Location = New System.Drawing.Point(47, 15)
        Me.TextBoxSquaredFactor.Name = "TextBoxSquaredFactor"
        Me.TextBoxSquaredFactor.Size = New System.Drawing.Size(65, 20)
        Me.TextBoxSquaredFactor.TabIndex = 5
        '
        'ButtonReadControlCal
        '
        Me.ButtonReadControlCal.Location = New System.Drawing.Point(12, 110)
        Me.ButtonReadControlCal.Name = "ButtonReadControlCal"
        Me.ButtonReadControlCal.Size = New System.Drawing.Size(211, 23)
        Me.ButtonReadControlCal.TabIndex = 6
        Me.ButtonReadControlCal.Text = "Read Magnet Supply Cal  Data"
        Me.ButtonReadControlCal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Squared Factor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Linear Factor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Constant Factor"
        '
        'ButtonWriteControlCal
        '
        Me.ButtonWriteControlCal.Location = New System.Drawing.Point(12, 149)
        Me.ButtonWriteControlCal.Name = "ButtonWriteControlCal"
        Me.ButtonWriteControlCal.Size = New System.Drawing.Size(211, 23)
        Me.ButtonWriteControlCal.TabIndex = 10
        Me.ButtonWriteControlCal.Text = "Write Magnet Supply Cal  Data"
        Me.ButtonWriteControlCal.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 384)
        Me.Controls.Add(Me.ButtonWriteControlCal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReadControlCal)
        Me.Controls.Add(Me.TextBoxSquaredFactor)
        Me.Controls.Add(Me.TextBoxConstantFactor)
        Me.Controls.Add(Me.TextBoxLinearFactor)
        Me.Name = "Form2"
        Me.Text = "Calibration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxLinearFactor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxConstantFactor As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSquaredFactor As System.Windows.Forms.TextBox
    Friend WithEvents ButtonReadControlCal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonWriteControlCal As System.Windows.Forms.Button
End Class
