<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReq
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DTPPODATE = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TXTPONO = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CMBPLANTHEAD = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GRPREQDATA = New System.Windows.Forms.GroupBox()
        Me.CMBUNITS = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.TXTQTY = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXTDES = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CMBITEMCODE = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CMBPURHEAD = New System.Windows.Forms.ComboBox()
        Me.CMDUNCHECK = New System.Windows.Forms.Button()
        Me.CMDCHECK = New System.Windows.Forms.Button()
        Me.CMDAPPR = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.CMDLOGOUT = New System.Windows.Forms.Button()
        Me.CMDMAIN = New System.Windows.Forms.Button()
        Me.CMDCLEAR = New System.Windows.Forms.Button()
        Me.CMDDEL = New System.Windows.Forms.Button()
        Me.CMDSAVE = New System.Windows.Forms.Button()
        Me.CMDOPEN = New System.Windows.Forms.Button()
        Me.CMBDEPTHEAD = New System.Windows.Forms.ComboBox()
        Me.GRPREQDET = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CMBEMAIL = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXTREM4 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXTREM2 = New System.Windows.Forms.TextBox()
        Me.TXTREM3 = New System.Windows.Forms.TextBox()
        Me.TXTREM1 = New System.Windows.Forms.TextBox()
        Me.CMBPURCHHEAD = New System.Windows.Forms.ComboBox()
        Me.CMBPLANTAPP = New System.Windows.Forms.ComboBox()
        Me.CMBDEPTAPP = New System.Windows.Forms.ComboBox()
        Me.CMBPUR = New System.Windows.Forms.ComboBox()
        Me.CMBREQ = New System.Windows.Forms.ComboBox()
        Me.DTPAPPDATE3 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DTPAPPDATE2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTPAPPDATE1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CMBLOC = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMBDEPTNAME = New System.Windows.Forms.ComboBox()
        Me.DTPREQDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTREQNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMDOUTPUT = New System.Windows.Forms.Button()
        Me.CMDEDIT = New System.Windows.Forms.Button()
        Me.GRPREQDATA.SuspendLayout()
        Me.GRPREQDET.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(8, 676)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1276, 155)
        Me.ListView1.TabIndex = 144
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'DTPPODATE
        '
        Me.DTPPODATE.Location = New System.Drawing.Point(490, 433)
        Me.DTPPODATE.Name = "DTPPODATE"
        Me.DTPPODATE.Size = New System.Drawing.Size(200, 22)
        Me.DTPPODATE.TabIndex = 104
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(387, 433)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 17)
        Me.Label22.TabIndex = 103
        Me.Label22.Text = "PO DATE"
        '
        'TXTPONO
        '
        Me.TXTPONO.Location = New System.Drawing.Point(177, 433)
        Me.TXTPONO.Name = "TXTPONO"
        Me.TXTPONO.Size = New System.Drawing.Size(146, 22)
        Me.TXTPONO.TabIndex = 102
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 433)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 17)
        Me.Label23.TabIndex = 101
        Me.Label23.Text = "PO NO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(640, 387)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(166, 17)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "EMAIL TO PURCH HEAD"
        '
        'CMBPLANTHEAD
        '
        Me.CMBPLANTHEAD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBPLANTHEAD.FormattingEnabled = True
        Me.CMBPLANTHEAD.Location = New System.Drawing.Point(173, 383)
        Me.CMBPLANTHEAD.Name = "CMBPLANTHEAD"
        Me.CMBPLANTHEAD.Size = New System.Drawing.Size(372, 24)
        Me.CMBPLANTHEAD.TabIndex = 98
        Me.CMBPLANTHEAD.Text = "---Select Plant Head---"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(4, 383)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(163, 17)
        Me.Label21.TabIndex = 97
        Me.Label21.Text = "EMAIL TO PLANT HEAD"
        '
        'GRPREQDATA
        '
        Me.GRPREQDATA.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GRPREQDATA.Controls.Add(Me.CMBUNITS)
        Me.GRPREQDATA.Controls.Add(Me.Label28)
        Me.GRPREQDATA.Controls.Add(Me.Label27)
        Me.GRPREQDATA.Controls.Add(Me.TXTPRICE)
        Me.GRPREQDATA.Controls.Add(Me.TXTQTY)
        Me.GRPREQDATA.Controls.Add(Me.Label26)
        Me.GRPREQDATA.Controls.Add(Me.TXTDES)
        Me.GRPREQDATA.Controls.Add(Me.Label25)
        Me.GRPREQDATA.Controls.Add(Me.CMBITEMCODE)
        Me.GRPREQDATA.Controls.Add(Me.Label24)
        Me.GRPREQDATA.Location = New System.Drawing.Point(8, 852)
        Me.GRPREQDATA.Name = "GRPREQDATA"
        Me.GRPREQDATA.Size = New System.Drawing.Size(1859, 120)
        Me.GRPREQDATA.TabIndex = 131
        Me.GRPREQDATA.TabStop = False
        Me.GRPREQDATA.Text = "REQUISTION ITEM ENTRY"
        '
        'CMBUNITS
        '
        Me.CMBUNITS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBUNITS.FormattingEnabled = True
        Me.CMBUNITS.Location = New System.Drawing.Point(1607, 37)
        Me.CMBUNITS.Name = "CMBUNITS"
        Me.CMBUNITS.Size = New System.Drawing.Size(171, 24)
        Me.CMBUNITS.TabIndex = 112
        Me.CMBUNITS.Text = "---Select Unit---"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(1539, 42)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 17)
        Me.Label28.TabIndex = 111
        Me.Label28.Text = "UNITS"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(1237, 42)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 17)
        Me.Label27.TabIndex = 110
        Me.Label27.Text = "PRICE"
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Location = New System.Drawing.Point(1312, 37)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(181, 22)
        Me.TXTPRICE.TabIndex = 109
        '
        'TXTQTY
        '
        Me.TXTQTY.Location = New System.Drawing.Point(1043, 37)
        Me.TXTQTY.Name = "TXTQTY"
        Me.TXTQTY.Size = New System.Drawing.Size(157, 22)
        Me.TXTQTY.TabIndex = 108
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(976, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 17)
        Me.Label26.TabIndex = 107
        Me.Label26.Text = "QTY"
        '
        'TXTDES
        '
        Me.TXTDES.Location = New System.Drawing.Point(476, 39)
        Me.TXTDES.Name = "TXTDES"
        Me.TXTDES.Size = New System.Drawing.Size(448, 22)
        Me.TXTDES.TabIndex = 105
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(352, 42)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 17)
        Me.Label25.TabIndex = 106
        Me.Label25.Text = "DESCRIBTION"
        '
        'CMBITEMCODE
        '
        Me.CMBITEMCODE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBITEMCODE.FormattingEnabled = True
        Me.CMBITEMCODE.Location = New System.Drawing.Point(113, 39)
        Me.CMBITEMCODE.Name = "CMBITEMCODE"
        Me.CMBITEMCODE.Size = New System.Drawing.Size(181, 24)
        Me.CMBITEMCODE.TabIndex = 105
        Me.CMBITEMCODE.Text = "---Select Item---"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 17)
        Me.Label24.TabIndex = 94
        Me.Label24.Text = "ITEM CODE"
        '
        'CMBPURHEAD
        '
        Me.CMBPURHEAD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBPURHEAD.FormattingEnabled = True
        Me.CMBPURHEAD.Location = New System.Drawing.Point(828, 383)
        Me.CMBPURHEAD.Name = "CMBPURHEAD"
        Me.CMBPURHEAD.Size = New System.Drawing.Size(376, 24)
        Me.CMBPURHEAD.TabIndex = 100
        Me.CMBPURHEAD.Text = "---Select Purch head---"
        '
        'CMDUNCHECK
        '
        Me.CMDUNCHECK.BackColor = System.Drawing.Color.Firebrick
        Me.CMDUNCHECK.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDUNCHECK.Location = New System.Drawing.Point(1656, 661)
        Me.CMDUNCHECK.Name = "CMDUNCHECK"
        Me.CMDUNCHECK.Size = New System.Drawing.Size(124, 40)
        Me.CMDUNCHECK.TabIndex = 143
        Me.CMDUNCHECK.Text = "UNCHECKED"
        Me.CMDUNCHECK.UseVisualStyleBackColor = False
        '
        'CMDCHECK
        '
        Me.CMDCHECK.BackColor = System.Drawing.Color.SteelBlue
        Me.CMDCHECK.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDCHECK.Location = New System.Drawing.Point(1533, 661)
        Me.CMDCHECK.Name = "CMDCHECK"
        Me.CMDCHECK.Size = New System.Drawing.Size(117, 40)
        Me.CMDCHECK.TabIndex = 142
        Me.CMDCHECK.Text = "CHECKED"
        Me.CMDCHECK.UseVisualStyleBackColor = False
        '
        'CMDAPPR
        '
        Me.CMDAPPR.BackColor = System.Drawing.Color.Green
        Me.CMDAPPR.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDAPPR.Location = New System.Drawing.Point(1399, 661)
        Me.CMDAPPR.Name = "CMDAPPR"
        Me.CMDAPPR.Size = New System.Drawing.Size(128, 40)
        Me.CMDAPPR.TabIndex = 141
        Me.CMDAPPR.Text = "APPROVED"
        Me.CMDAPPR.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Teal
        Me.Label29.Location = New System.Drawing.Point(1384, 91)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(424, 33)
        Me.Label29.TabIndex = 140
        Me.Label29.Text = "WAITING TO BE APPROVED"
        '
        'ListView2
        '
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(1311, 142)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(556, 496)
        Me.ListView2.TabIndex = 139
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'CMDLOGOUT
        '
        Me.CMDLOGOUT.BackColor = System.Drawing.Color.Firebrick
        Me.CMDLOGOUT.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDLOGOUT.Location = New System.Drawing.Point(1239, 1002)
        Me.CMDLOGOUT.Name = "CMDLOGOUT"
        Me.CMDLOGOUT.Size = New System.Drawing.Size(106, 40)
        Me.CMDLOGOUT.TabIndex = 132
        Me.CMDLOGOUT.Text = "LOGOUT"
        Me.CMDLOGOUT.UseVisualStyleBackColor = False
        '
        'CMDMAIN
        '
        Me.CMDMAIN.BackColor = System.Drawing.SystemColors.InfoText
        Me.CMDMAIN.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDMAIN.Location = New System.Drawing.Point(1117, 1002)
        Me.CMDMAIN.Name = "CMDMAIN"
        Me.CMDMAIN.Size = New System.Drawing.Size(116, 40)
        Me.CMDMAIN.TabIndex = 133
        Me.CMDMAIN.Text = "MAIN"
        Me.CMDMAIN.UseVisualStyleBackColor = False
        '
        'CMDCLEAR
        '
        Me.CMDCLEAR.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CMDCLEAR.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDCLEAR.Location = New System.Drawing.Point(866, 1002)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.Size = New System.Drawing.Size(122, 40)
        Me.CMDCLEAR.TabIndex = 135
        Me.CMDCLEAR.Text = "CLEAR"
        Me.CMDCLEAR.UseVisualStyleBackColor = False
        '
        'CMDDEL
        '
        Me.CMDDEL.BackColor = System.Drawing.Color.Firebrick
        Me.CMDDEL.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDDEL.Location = New System.Drawing.Point(735, 1002)
        Me.CMDDEL.Name = "CMDDEL"
        Me.CMDDEL.Size = New System.Drawing.Size(125, 40)
        Me.CMDDEL.TabIndex = 136
        Me.CMDDEL.Text = "DELETE"
        Me.CMDDEL.UseVisualStyleBackColor = False
        '
        'CMDSAVE
        '
        Me.CMDSAVE.BackColor = System.Drawing.Color.Green
        Me.CMDSAVE.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDSAVE.Location = New System.Drawing.Point(609, 1002)
        Me.CMDSAVE.Name = "CMDSAVE"
        Me.CMDSAVE.Size = New System.Drawing.Size(125, 40)
        Me.CMDSAVE.TabIndex = 137
        Me.CMDSAVE.Text = "SAVE"
        Me.CMDSAVE.UseVisualStyleBackColor = False
        '
        'CMDOPEN
        '
        Me.CMDOPEN.BackColor = System.Drawing.Color.Green
        Me.CMDOPEN.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDOPEN.Location = New System.Drawing.Point(475, 1002)
        Me.CMDOPEN.Name = "CMDOPEN"
        Me.CMDOPEN.Size = New System.Drawing.Size(128, 40)
        Me.CMDOPEN.TabIndex = 138
        Me.CMDOPEN.Text = "OPEN"
        Me.CMDOPEN.UseVisualStyleBackColor = False
        '
        'CMBDEPTHEAD
        '
        Me.CMBDEPTHEAD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBDEPTHEAD.FormattingEnabled = True
        Me.CMBDEPTHEAD.Location = New System.Drawing.Point(828, 331)
        Me.CMBDEPTHEAD.Name = "CMBDEPTHEAD"
        Me.CMBDEPTHEAD.Size = New System.Drawing.Size(376, 24)
        Me.CMBDEPTHEAD.TabIndex = 96
        Me.CMBDEPTHEAD.Text = "---Select Dept Head---"
        '
        'GRPREQDET
        '
        Me.GRPREQDET.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GRPREQDET.Controls.Add(Me.DTPPODATE)
        Me.GRPREQDET.Controls.Add(Me.Label22)
        Me.GRPREQDET.Controls.Add(Me.TXTPONO)
        Me.GRPREQDET.Controls.Add(Me.Label23)
        Me.GRPREQDET.Controls.Add(Me.CMBPURHEAD)
        Me.GRPREQDET.Controls.Add(Me.Label20)
        Me.GRPREQDET.Controls.Add(Me.CMBPLANTHEAD)
        Me.GRPREQDET.Controls.Add(Me.Label21)
        Me.GRPREQDET.Controls.Add(Me.CMBDEPTHEAD)
        Me.GRPREQDET.Controls.Add(Me.Label19)
        Me.GRPREQDET.Controls.Add(Me.CMBEMAIL)
        Me.GRPREQDET.Controls.Add(Me.Label18)
        Me.GRPREQDET.Controls.Add(Me.TXTREM4)
        Me.GRPREQDET.Controls.Add(Me.Label17)
        Me.GRPREQDET.Controls.Add(Me.TXTREM2)
        Me.GRPREQDET.Controls.Add(Me.TXTREM3)
        Me.GRPREQDET.Controls.Add(Me.TXTREM1)
        Me.GRPREQDET.Controls.Add(Me.CMBPURCHHEAD)
        Me.GRPREQDET.Controls.Add(Me.CMBPLANTAPP)
        Me.GRPREQDET.Controls.Add(Me.CMBDEPTAPP)
        Me.GRPREQDET.Controls.Add(Me.CMBPUR)
        Me.GRPREQDET.Controls.Add(Me.CMBREQ)
        Me.GRPREQDET.Controls.Add(Me.DTPAPPDATE3)
        Me.GRPREQDET.Controls.Add(Me.Label14)
        Me.GRPREQDET.Controls.Add(Me.Label15)
        Me.GRPREQDET.Controls.Add(Me.Label16)
        Me.GRPREQDET.Controls.Add(Me.DTPAPPDATE2)
        Me.GRPREQDET.Controls.Add(Me.Label11)
        Me.GRPREQDET.Controls.Add(Me.Label12)
        Me.GRPREQDET.Controls.Add(Me.Label13)
        Me.GRPREQDET.Controls.Add(Me.DTPAPPDATE1)
        Me.GRPREQDET.Controls.Add(Me.Label8)
        Me.GRPREQDET.Controls.Add(Me.Label9)
        Me.GRPREQDET.Controls.Add(Me.Label10)
        Me.GRPREQDET.Controls.Add(Me.CMBLOC)
        Me.GRPREQDET.Controls.Add(Me.Label5)
        Me.GRPREQDET.Controls.Add(Me.Label6)
        Me.GRPREQDET.Controls.Add(Me.Label7)
        Me.GRPREQDET.Controls.Add(Me.CMBDEPTNAME)
        Me.GRPREQDET.Controls.Add(Me.DTPREQDATE)
        Me.GRPREQDET.Controls.Add(Me.Label4)
        Me.GRPREQDET.Controls.Add(Me.Label2)
        Me.GRPREQDET.Controls.Add(Me.TXTREQNO)
        Me.GRPREQDET.Controls.Add(Me.Label3)
        Me.GRPREQDET.Location = New System.Drawing.Point(8, 91)
        Me.GRPREQDET.Name = "GRPREQDET"
        Me.GRPREQDET.Size = New System.Drawing.Size(1276, 565)
        Me.GRPREQDET.TabIndex = 129
        Me.GRPREQDET.TabStop = False
        Me.GRPREQDET.Text = "REQUISITION DETAILS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(640, 331)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(155, 17)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "EMAIL TO DEPT HEAD"
        '
        'CMBEMAIL
        '
        Me.CMBEMAIL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBEMAIL.FormattingEnabled = True
        Me.CMBEMAIL.Location = New System.Drawing.Point(173, 331)
        Me.CMBEMAIL.Name = "CMBEMAIL"
        Me.CMBEMAIL.Size = New System.Drawing.Size(372, 24)
        Me.CMBEMAIL.TabIndex = 94
        Me.CMBEMAIL.Text = "---Select Your Email---"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 331)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 17)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "EMAIL FROM"
        '
        'TXTREM4
        '
        Me.TXTREM4.Location = New System.Drawing.Point(173, 285)
        Me.TXTREM4.Name = "TXTREM4"
        Me.TXTREM4.Size = New System.Drawing.Size(1031, 22)
        Me.TXTREM4.TabIndex = 92
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 288)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 17)
        Me.Label17.TabIndex = 91
        Me.Label17.Text = "REMARKS"
        '
        'TXTREM2
        '
        Me.TXTREM2.Location = New System.Drawing.Point(1004, 173)
        Me.TXTREM2.Name = "TXTREM2"
        Me.TXTREM2.Size = New System.Drawing.Size(200, 22)
        Me.TXTREM2.TabIndex = 90
        '
        'TXTREM3
        '
        Me.TXTREM3.Location = New System.Drawing.Point(1004, 225)
        Me.TXTREM3.Name = "TXTREM3"
        Me.TXTREM3.Size = New System.Drawing.Size(200, 22)
        Me.TXTREM3.TabIndex = 89
        '
        'TXTREM1
        '
        Me.TXTREM1.Location = New System.Drawing.Point(1004, 128)
        Me.TXTREM1.Name = "TXTREM1"
        Me.TXTREM1.Size = New System.Drawing.Size(200, 22)
        Me.TXTREM1.TabIndex = 88
        '
        'CMBPURCHHEAD
        '
        Me.CMBPURCHHEAD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBPURCHHEAD.FormattingEnabled = True
        Me.CMBPURCHHEAD.Location = New System.Drawing.Point(173, 233)
        Me.CMBPURCHHEAD.Name = "CMBPURCHHEAD"
        Me.CMBPURCHHEAD.Size = New System.Drawing.Size(146, 24)
        Me.CMBPURCHHEAD.TabIndex = 87
        Me.CMBPURCHHEAD.Text = "---Select Purch Head---"
        '
        'CMBPLANTAPP
        '
        Me.CMBPLANTAPP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBPLANTAPP.FormattingEnabled = True
        Me.CMBPLANTAPP.Location = New System.Drawing.Point(173, 178)
        Me.CMBPLANTAPP.Name = "CMBPLANTAPP"
        Me.CMBPLANTAPP.Size = New System.Drawing.Size(146, 24)
        Me.CMBPLANTAPP.TabIndex = 86
        Me.CMBPLANTAPP.Text = "---Select Plant Head---"
        '
        'CMBDEPTAPP
        '
        Me.CMBDEPTAPP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBDEPTAPP.FormattingEnabled = True
        Me.CMBDEPTAPP.Location = New System.Drawing.Point(173, 131)
        Me.CMBDEPTAPP.Name = "CMBDEPTAPP"
        Me.CMBDEPTAPP.Size = New System.Drawing.Size(146, 24)
        Me.CMBDEPTAPP.TabIndex = 85
        Me.CMBDEPTAPP.Text = "---Select Dept Head---"
        '
        'CMBPUR
        '
        Me.CMBPUR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBPUR.FormattingEnabled = True
        Me.CMBPUR.Location = New System.Drawing.Point(577, 83)
        Me.CMBPUR.Name = "CMBPUR"
        Me.CMBPUR.Size = New System.Drawing.Size(200, 24)
        Me.CMBPUR.TabIndex = 84
        Me.CMBPUR.Text = "---Select Purchaser---"
        '
        'CMBREQ
        '
        Me.CMBREQ.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBREQ.FormattingEnabled = True
        Me.CMBREQ.Location = New System.Drawing.Point(173, 82)
        Me.CMBREQ.Name = "CMBREQ"
        Me.CMBREQ.Size = New System.Drawing.Size(146, 24)
        Me.CMBREQ.TabIndex = 83
        Me.CMBREQ.Text = "---Select Client---"
        '
        'DTPAPPDATE3
        '
        Me.DTPAPPDATE3.Location = New System.Drawing.Point(577, 227)
        Me.DTPAPPDATE3.Name = "DTPAPPDATE3"
        Me.DTPAPPDATE3.Size = New System.Drawing.Size(200, 22)
        Me.DTPAPPDATE3.TabIndex = 81
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(889, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 17)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "REMARKS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(412, 230)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 17)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "APP DATE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 226)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 17)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "PURCH HEAD"
        '
        'DTPAPPDATE2
        '
        Me.DTPAPPDATE2.Location = New System.Drawing.Point(577, 175)
        Me.DTPAPPDATE2.Name = "DTPAPPDATE2"
        Me.DTPAPPDATE2.Size = New System.Drawing.Size(200, 22)
        Me.DTPAPPDATE2.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(889, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "REMARKS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(412, 178)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 17)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "APP DATE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 17)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "PLANT HEAD APP"
        '
        'DTPAPPDATE1
        '
        Me.DTPAPPDATE1.Location = New System.Drawing.Point(577, 125)
        Me.DTPAPPDATE1.Name = "DTPAPPDATE1"
        Me.DTPAPPDATE1.Size = New System.Drawing.Size(200, 22)
        Me.DTPAPPDATE1.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(889, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "REMARKS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(412, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "APP DATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 17)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "DEPT HEAD APP"
        '
        'CMBLOC
        '
        Me.CMBLOC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CMBLOC.FormattingEnabled = True
        Me.CMBLOC.Location = New System.Drawing.Point(1004, 83)
        Me.CMBLOC.Name = "CMBLOC"
        Me.CMBLOC.Size = New System.Drawing.Size(200, 24)
        Me.CMBLOC.TabIndex = 64
        Me.CMBLOC.Text = "---Select Location---"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(889, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "LOCATION"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(412, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "PURCHASER NAME"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "REQUIRED BY"
        '
        'CMBDEPTNAME
        '
        Me.CMBDEPTNAME.FormattingEnabled = True
        Me.CMBDEPTNAME.Location = New System.Drawing.Point(1004, 37)
        Me.CMBDEPTNAME.Name = "CMBDEPTNAME"
        Me.CMBDEPTNAME.Size = New System.Drawing.Size(200, 24)
        Me.CMBDEPTNAME.TabIndex = 58
        Me.CMBDEPTNAME.Text = "---Select Dept---"
        '
        'DTPREQDATE
        '
        Me.DTPREQDATE.Location = New System.Drawing.Point(577, 40)
        Me.DTPREQDATE.Name = "DTPREQDATE"
        Me.DTPREQDATE.Size = New System.Drawing.Size(200, 22)
        Me.DTPREQDATE.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(889, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "DEPT NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "REQUISITION DATE"
        '
        'TXTREQNO
        '
        Me.TXTREQNO.Location = New System.Drawing.Point(173, 43)
        Me.TXTREQNO.Name = "TXTREQNO"
        Me.TXTREQNO.Size = New System.Drawing.Size(146, 22)
        Me.TXTREQNO.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "REQUISITION NO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(437, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 39)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "REQUISITION FORM"
        '
        'CMDOUTPUT
        '
        Me.CMDOUTPUT.BackColor = System.Drawing.Color.SteelBlue
        Me.CMDOUTPUT.ForeColor = System.Drawing.SystemColors.Info
        Me.CMDOUTPUT.Location = New System.Drawing.Point(994, 1002)
        Me.CMDOUTPUT.Name = "CMDOUTPUT"
        Me.CMDOUTPUT.Size = New System.Drawing.Size(117, 40)
        Me.CMDOUTPUT.TabIndex = 134
        Me.CMDOUTPUT.Text = "OUTPUT"
        Me.CMDOUTPUT.UseVisualStyleBackColor = False
        '
        'CMDEDIT
        '
        Me.CMDEDIT.BackColor = System.Drawing.Color.Orange
        Me.CMDEDIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CMDEDIT.Location = New System.Drawing.Point(344, 1002)
        Me.CMDEDIT.Name = "CMDEDIT"
        Me.CMDEDIT.Size = New System.Drawing.Size(125, 40)
        Me.CMDEDIT.TabIndex = 145
        Me.CMDEDIT.Text = "EDIT"
        Me.CMDEDIT.UseVisualStyleBackColor = False
        '
        'FrmReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1891, 1055)
        Me.Controls.Add(Me.CMDEDIT)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GRPREQDATA)
        Me.Controls.Add(Me.CMDUNCHECK)
        Me.Controls.Add(Me.CMDCHECK)
        Me.Controls.Add(Me.CMDAPPR)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.CMDLOGOUT)
        Me.Controls.Add(Me.CMDMAIN)
        Me.Controls.Add(Me.CMDOUTPUT)
        Me.Controls.Add(Me.CMDCLEAR)
        Me.Controls.Add(Me.CMDDEL)
        Me.Controls.Add(Me.CMDSAVE)
        Me.Controls.Add(Me.CMDOPEN)
        Me.Controls.Add(Me.GRPREQDET)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmReq"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GRPREQDATA.ResumeLayout(False)
        Me.GRPREQDATA.PerformLayout()
        Me.GRPREQDET.ResumeLayout(False)
        Me.GRPREQDET.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents DTPPODATE As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents TXTPONO As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents CMBPLANTHEAD As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GRPREQDATA As GroupBox
    Friend WithEvents CMBUNITS As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents TXTQTY As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TXTDES As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents CMBITEMCODE As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CMBPURHEAD As ComboBox
    Friend WithEvents CMDUNCHECK As Button
    Friend WithEvents CMDCHECK As Button
    Friend WithEvents CMDAPPR As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents ListView2 As ListView
    Friend WithEvents CMDLOGOUT As Button
    Friend WithEvents CMDMAIN As Button
    Friend WithEvents CMDCLEAR As Button
    Friend WithEvents CMDDEL As Button
    Friend WithEvents CMDSAVE As Button
    Friend WithEvents CMDOPEN As Button
    Friend WithEvents CMBDEPTHEAD As ComboBox
    Friend WithEvents GRPREQDET As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents CMBEMAIL As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TXTREM4 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TXTREM2 As TextBox
    Friend WithEvents TXTREM3 As TextBox
    Friend WithEvents TXTREM1 As TextBox
    Friend WithEvents CMBPURCHHEAD As ComboBox
    Friend WithEvents CMBPLANTAPP As ComboBox
    Friend WithEvents CMBDEPTAPP As ComboBox
    Friend WithEvents CMBPUR As ComboBox
    Friend WithEvents CMBREQ As ComboBox
    Friend WithEvents DTPAPPDATE3 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DTPAPPDATE2 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DTPAPPDATE1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CMBLOC As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CMBDEPTNAME As ComboBox
    Friend WithEvents DTPREQDATE As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTREQNO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMDOUTPUT As Button
    Friend WithEvents CMDEDIT As Button
End Class
