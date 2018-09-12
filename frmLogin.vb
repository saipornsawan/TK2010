Imports System.Data.OleDb
Imports System.Data
Imports System.Text

Public Class frmLogin
    Dim Conn As New OleDbConnection
    Dim DA As OleDbDataAdapter

    Dim dt As New DataTable
    Dim sql As String = ""
    Dim sb As New StringBuilder("")

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

        Conn.Close()
    End Sub

    Private Sub bttOK_Click(sender As Object, e As EventArgs) Handles bttOK.Click
        sb.Remove(0, sb.Length)
        sb.Append("SELECT Uname, pw FROM users WHERE (uname=?) AND (pw=?)")
        sql = sb.ToString

        DA = New OleDbDataAdapter(sql, Conn)
        DA.SelectCommand.Parameters.Clear()
        DA.SelectCommand.Parameters.Add("?", OleDbType.VarChar).Value = txtUser.Text
        DA.SelectCommand.Parameters.Add("?", OleDbType.VarChar).Value = txtPwd.Text
        dt = New DataTable
        DA.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim f As New frmMaster
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("User Invalid, pls. check again.!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class