'Title:         Close The Program
'Date:          12-22-14
'Author:        Terry Holmes

'Description:   This will close the program

Option Strict On

Public Class CloseTheProgram

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click

        'Returns to the program
        Me.Close()

    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click

        'Closes the program
        Logon.Close()
        Me.Close()

    End Sub
End Class