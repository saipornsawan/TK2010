Public Class frmMaster
    Dim f As Form

    Private Sub frmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ขอมลพนกงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลพนกงานToolStripMenuItem.Click
     

    End Sub

    Private Sub ขอมลสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลสนคาToolStripMenuItem.Click
    
    End Sub

    Private Sub munUser_Click(sender As Object, e As EventArgs) Handles munUser.Click
        f = New frmUsers
        f.MdiParent = Me
        f.Show()

    End Sub
End Class