Public Class Frmlogin
    Private Sub CMDOK_Click(sender As Object, e As EventArgs) Handles CMDOK.Click
        Dim RS As New ADODB.Recordset
        RS.Open("SELECT * FROM LOGIN where USER_NAME='" & Trim(cmbusername.Text) & "'", cnMainData, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount = 0 Then
            rs.Close()
            MsgBox("Record Not Found", MsgBoxStyle.Information)
        Else
            If RS.Fields("PASSWORD").Value = TXTpassword.Text Then
                FrmWelcome.Show()
            Else
                MsgBox("Password Mismatch", MsgBoxStyle.Information)
            End If
            rs.Close()
        End If
    End Sub

    Private Sub CMDEXIT_Click(sender As Object, e As EventArgs) Handles CMDEXIT.Click
        End
    End Sub

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cnMainData.State = 0 Then Module1.connect()
    End Sub
End Class