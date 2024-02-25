<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogin
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
        Me.TXTpassword = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbusername = New System.Windows.Forms.ComboBox()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTpassword
        '
        Me.TXTpassword.Location = New System.Drawing.Point(147, 54)
        Me.TXTpassword.Name = "TXTpassword"
        Me.TXTpassword.Size = New System.Drawing.Size(181, 22)
        Me.TXTpassword.TabIndex = 112
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(42, 54)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 17)
        Me.Label26.TabIndex = 111
        Me.Label26.Text = "PASSWORD"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(42, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 17)
        Me.Label24.TabIndex = 109
        Me.Label24.Text = "USER ID"
        '
        'cmbusername
        '
        Me.cmbusername.FormattingEnabled = True
        Me.cmbusername.Location = New System.Drawing.Point(147, 18)
        Me.cmbusername.Name = "cmbusername"
        Me.cmbusername.Size = New System.Drawing.Size(192, 24)
        Me.cmbusername.TabIndex = 113
        '
        'CMDOK
        '
        Me.CMDOK.BackColor = System.Drawing.Color.LimeGreen
        Me.CMDOK.Location = New System.Drawing.Point(125, 105)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(85, 30)
        Me.CMDOK.TabIndex = 114
        Me.CMDOK.Text = "OK"
        Me.CMDOK.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Red
        Me.CMDEXIT.Location = New System.Drawing.Point(241, 105)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(87, 30)
        Me.CMDEXIT.TabIndex = 115
        Me.CMDEXIT.Text = "EXIT"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'Frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(473, 167)
        Me.Controls.Add(Me.CMDEXIT)
        Me.Controls.Add(Me.CMDOK)
        Me.Controls.Add(Me.cmbusername)
        Me.Controls.Add(Me.TXTpassword)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label24)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Frmlogin"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTpassword As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cmbusername As ComboBox
    Friend WithEvents CMDOK As Button
    Friend WithEvents CMDEXIT As Button
End Class
