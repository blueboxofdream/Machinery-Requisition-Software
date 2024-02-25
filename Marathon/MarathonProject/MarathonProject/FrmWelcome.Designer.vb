<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWelcome
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
        Me.CMDREQ = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMDREQ
        '
        Me.CMDREQ.BackColor = System.Drawing.Color.Gold
        Me.CMDREQ.Location = New System.Drawing.Point(322, 301)
        Me.CMDREQ.Name = "CMDREQ"
        Me.CMDREQ.Size = New System.Drawing.Size(152, 36)
        Me.CMDREQ.TabIndex = 0
        Me.CMDREQ.Text = "Requisition Form"
        Me.CMDREQ.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(621, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(119, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMDREQ)
        Me.Name = "FrmWelcome"
        Me.Text = "FrmWelcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CMDREQ As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
