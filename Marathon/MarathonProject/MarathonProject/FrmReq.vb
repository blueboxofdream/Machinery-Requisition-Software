Public Class FrmReq

    Private Sub CMDCLEAR_Click(sender As Object, e As EventArgs) Handles CMDCLEAR.Click
        TXTREQNO.Text = ""
        DTPREQDATE.Value = Today
        CMBDEPTNAME.Text = "---Select Dept---"

        CMBREQ.Text = "---Select Client---"
        CMBPUR.Text = "---Select Purchaser---"
        CMBLOC.Text = "---Select Location---"

        CMBDEPTAPP.Text = "---Select Dept Head---"
        DTPAPPDATE1.Value = Today
        TXTREM1.Text = ""

        CMBPLANTAPP.Text = "---Select Plant Head---"
        DTPAPPDATE2.Value = Today
        TXTREM2.Text = ""

        CMBPURCHHEAD.Text = "---Select Purch Head---"
        DTPAPPDATE3.Value = Today
        TXTREM3.Text = ""

        TXTREM4.Text = ""

        CMBEMAIL.Text = "---Select Your Email---"
        CMBDEPTHEAD.Text = "---Select Dept Head---"

        CMBPLANTHEAD.Text = "---Select Plant Head---"
        CMBPURHEAD.Text = "---Select Purch head---"

        TXTPONO.Text = ""
        DTPPODATE.Value = Today

        CMBITEMCODE.Text = "---Select Item---"
        TXTDES.Text = ""
        TXTQTY.Text = ""
        TXTPRICE.Text = ""
        CMBUNITS.Text = "---Select Unit---"
    End Sub

    Private Sub CMDSAVE_Click(sender As Object, e As EventArgs) Handles CMDSAVE.Click
        Dim RS As New ADODB.Recordset
        Dim RS1 As New ADODB.Recordset
        If Trim(TXTREQNO.Text) = "" Then
            MsgBox("ENTRY JOB NO ", MsgBoxStyle.Information)
            TXTREQNO.Focus()
            Exit Sub
        Else
        End If
        'if new project then
        RS1.Open("SELECT *FROM REQ_DATA_DETAILS where REQ_NO='" & Trim(TXTREQNO.Text) & "'", cnMainData, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If RS1.RecordCount = 0 Then
            RS.Open("SELECT *FROM REQ_DATA_DETAILS", cnMainData, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockBatchOptimistic)
            With RS
                .AddNew()
                'RS.Fields("ID_NO").value = Val(TXTIDNO.Text)
                RS.Fields("REQ_NO").Value = Trim(TXTREQNO.Text)
                RS.Fields("REQ_DATE").Value = Trim(DTPREQDATE.Value)
                RS.Fields("DEPT_NAME").Value = Trim(CMBDEPTNAME.Text)

                RS.Fields("REQUIRE_BY").Value = Trim(CMBREQ.Text)
                RS.Fields("PURCHER_NAME").Value = Trim(CMBPUR.Text)
                RS.Fields("LOC").Value = Trim(CMBLOC.Text)

                RS.Fields("DEPT_HEAD").Value = Trim(CMBDEPTAPP.Text)
                RS.Fields("DEPT_APP").Value = Trim(DTPAPPDATE1.Value)
                RS.Fields("DEPT_REM").Value = Trim(TXTREM1.Text)

                RS.Fields("PLANT_HEAD").Value = Trim(CMBPLANTAPP.Text)
                RS.Fields("PLANT_APP").Value = Trim(DTPAPPDATE2.Value)
                RS.Fields("PLANT_REM").Value = Trim(TXTREM2.Text)

                RS.Fields("PURCH_HEAD").Value = Trim(CMBPURCHHEAD.Text)
                RS.Fields("PURCH_APP").Value = Trim(DTPAPPDATE3.Value)
                RS.Fields("PURCH_REM").Value = Trim(TXTREM3.Text)

                RS.Fields("REMARKS").Value = Trim(TXTREM4.Text)

                RS.Fields("EMAIL").Value = Trim(CMBEMAIL.Text)
                RS.Fields("EMAIL_DEPT_HEAD").Value = Trim(CMBDEPTHEAD.Text)

                RS.Fields("EMAIL_PLANT_HEAD").Value = Trim(CMBPLANTHEAD.Text)
                RS.Fields("EMAIL_PURCH_HEAD").Value = Trim(CMBPURHEAD.Text)

                RS.Fields("PO_NO").Value = Trim(TXTPONO.Text)
                RS.Fields("PO_DATE").Value = Trim(DTPPODATE.Value)

                RS.Fields("ITEM_CODE").Value = Trim(CMBITEMCODE.Text)
                RS.Fields("DESCRIBTION").Value = Trim(TXTDES.Text)
                RS.Fields("QTY").Value = Val(TXTQTY.Text)
                RS.Fields("PRICE").Value = Val(TXTPRICE.Text)
                RS.Fields("UNITS").Value = Trim(CMBUNITS.Text)
                .UpdateBatch()
            End With
            RS.Close()
            MsgBox("DATA IS SAVED", MsgBoxStyle.Information)

        Else


        End If
        RS1.Close()


    End Sub

    Private Sub FrmReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cnMainData.State = 0 Then Module1.connect()

    End Sub

    Private Sub CMDOPEN_Click(sender As Object, e As EventArgs) Handles CMDOPEN.Click
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT *FROM REQ_DATA_DETAILS where REQ_NO='" & Trim(TXTREQNO.Text) & "'", cnMainData, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount = 0 Then
            rs.Close()
            MsgBox("Record Not Found", MsgBoxStyle.Information)
        Else
            DTPREQDATE.Value = rs.Fields("REQ_DATE").Value
            CMBDEPTNAME.Text = Trim(rs.Fields("DEPT_NAME").Value)

            CMBREQ.Text = Trim(rs.Fields("REQUIRE_BY").Value)
            CMBPUR.Text = Trim(rs.Fields("PURCHER_NAME").Value)
            CMBLOC.Text = Trim(rs.Fields("LOC").Value)

            CMBDEPTAPP.Text = Trim(rs.Fields("DEPT_HEAD").Value)
            DTPAPPDATE1.Value = rs.Fields("DEPT_APP").Value
            TXTREM1.Text = Trim(rs.Fields("DEPT_REM").Value)

            CMBPLANTAPP.Text = Trim(rs.Fields("PLANT_HEAD").Value)
            DTPAPPDATE2.Value = rs.Fields("PLANT_APP").Value
            TXTREM2.Text = Trim(rs.Fields("PLANT_REM").Value)

            CMBPURCHHEAD.Text = Trim(rs.Fields("PURCH_HEAD").Value)
            DTPAPPDATE3.Value = rs.Fields("PURCH_APP").Value
            TXTREM3.Text = Trim(rs.Fields("PURCH_REM").Value)

            TXTREM4.Text = Trim(rs.Fields("REMARKS").Value)

            CMBEMAIL.Text = Trim(rs.Fields("EMAIL").Value)
            CMBDEPTHEAD.Text = Trim(rs.Fields("EMAIL_DEPT_HEAD").Value)

            CMBPLANTHEAD.Text = Trim(rs.Fields("EMAIL_PLANT_HEAD").Value)
            CMBPURHEAD.Text = Trim(rs.Fields("EMAIL_PURCH_HEAD").Value)

            TXTPONO.Text = Trim(rs.Fields("PO_NO").Value)
            DTPPODATE.Value = rs.Fields("PO_DATE").Value

            CMBITEMCODE.Text = Trim(rs.Fields("ITEM_CODE").Value)
            TXTDES.Text = Trim(rs.Fields("DESCRIBTION").Value)

            TXTQTY.Text = Val(rs.Fields("QTY").Value)
            TXTPRICE.Text = Val(rs.Fields("PRICE").Value)
            CMBUNITS.Text = Trim(rs.Fields("UNITS").Value)
            rs.Close()
        End If

    End Sub

    Private Sub CMDMAIN_Click(sender As Object, e As EventArgs) Handles CMDMAIN.Click
        FrmWelcome.Show()
        Me.Close()

    End Sub

    Private Sub CMDLOGOUT_Click(sender As Object, e As EventArgs) Handles CMDLOGOUT.Click
        End
    End Sub

    Private Sub CMDEDIT_Click(sender As Object, e As EventArgs) Handles CMDEDIT.Click
        Dim RS As New ADODB.Recordset
        Dim RS1 As New ADODB.Recordset
        RS1.Open("SELECT *FROM REQ_DATA_DETAILS where REQ_NO='" & Trim(TXTREQNO.Text) & "'", cnMainData, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If RS1.RecordCount = 0 Then

        Else
            RS.Open("SELECT *FROM REQ_DATA_DETAILS where REQ_NO='" & Trim(TXTREQNO.Text) & "'", cnMainData, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockBatchOptimistic)
            With RS
                .Update()
                'RS.Fields("ID_NO").value = Val(TXTIDNO.Text)
                RS.Fields("REQ_NO").Value = Trim(TXTREQNO.Text)
                RS.Fields("REQ_DATE").Value = Trim(DTPREQDATE.Value)
                RS.Fields("DEPT_NAME").Value = Trim(CMBDEPTNAME.Text)

                RS.Fields("REQUIRE_BY").Value = Trim(CMBREQ.Text)
                RS.Fields("PURCHER_NAME").Value = Trim(CMBPUR.Text)
                RS.Fields("LOC").Value = Trim(CMBLOC.Text)

                RS.Fields("DEPT_HEAD").Value = Trim(CMBDEPTAPP.Text)
                RS.Fields("DEPT_APP").Value = Trim(DTPAPPDATE1.Value)
                RS.Fields("DEPT_REM").Value = Trim(TXTREM1.Text)

                RS.Fields("PLANT_HEAD").Value = Trim(CMBPLANTAPP.Text)
                RS.Fields("PLANT_APP").Value = Trim(DTPAPPDATE2.Value)
                RS.Fields("PLANT_REM").Value = Trim(TXTREM2.Text)

                RS.Fields("PURCH_HEAD").Value = Trim(CMBPURCHHEAD.Text)
                RS.Fields("PURCH_APP").Value = Trim(DTPAPPDATE3.Value)
                RS.Fields("PURCH_REM").Value = Trim(TXTREM3.Text)

                RS.Fields("REMARKS").Value = Trim(TXTREM4.Text)

                RS.Fields("EMAIL").Value = Trim(CMBEMAIL.Text)
                RS.Fields("EMAIL_DEPT_HEAD").Value = Trim(CMBDEPTHEAD.Text)

                RS.Fields("EMAIL_PLANT_HEAD").Value = Trim(CMBPLANTHEAD.Text)
                RS.Fields("EMAIL_PURCH_HEAD").Value = Trim(CMBPURHEAD.Text)

                RS.Fields("PO_NO").Value = Trim(TXTPONO.Text)
                RS.Fields("PO_DATE").Value = Trim(DTPPODATE.Value)

                RS.Fields("ITEM_CODE").Value = Trim(CMBITEMCODE.Text)
                RS.Fields("DESCRIBTION").Value = Trim(TXTDES.Text)
                RS.Fields("QTY").Value = Val(TXTQTY.Text)
                RS.Fields("PRICE").Value = Val(TXTPRICE.Text)
                RS.Fields("UNITS").Value = Trim(CMBUNITS.Text)
                .UpdateBatch()
            End With
            RS.Close()
            MsgBox("DATA IS UPDATED", MsgBoxStyle.Information)
        End If
        RS1.CLOSE

    End Sub

    Private Sub CMDDEL_Click(sender As Object, e As EventArgs) Handles CMDDEL.Click
        Dim ANS As String
        Dim rs As New ADODB.Recordset
        ANS = MsgBox("DO YOU WANT TO DELETE THIS DATA?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        rs.Open("SELECT *FROM REQ_DATA_DETAILS where REQ_NO='" & Trim(TXTREQNO.Text) & "'", cnMainData, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount = 0 Then
            rs.Close()
            MsgBox("Record Not Found", MsgBoxStyle.Information)

        Else
            cnMainData.Execute("DELETE * FROM REQ_DATA_DETAILS WHERE REQ_NO='" & Trim(TXTREQNO.Text) & "'")
            rs.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class