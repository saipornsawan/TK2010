Imports System.Data.OleDb
Imports System.Text

Public Class frmUsers
    Dim Conn As New OleDbConnection
    Dim DA As OleDbDataAdapter
    Dim com As New OleDbCommand

    Dim dt As New DataTable
    Dim sql As String = ""
    Dim sb As New StringBuilder("")

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With
        GetData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sb.Remove(0, sb.Length)
        sb.Append("INSERT INTO Users (uname,pw) VALUES(?,?)")
        sql = sb.ToString

        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

        With com
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = Conn
            .Parameters.Clear()
            .Parameters.Add("?", OleDbType.VarChar).Value = txtUser.Text
            .Parameters.Add("?", OleDbType.VarChar).Value = txtPwd.Text
            .ExecuteNonQuery()
        End With
        Me.GetData()

        MsgBox("OK")
        txtPwd.Text = ""
        txtUser.Text = ""
        txtUser.Focus()
        txtUser.Select()

    End Sub

    Private Sub GetData()
        sql = "SELECT * FROM Users "
        DA = New OleDbDataAdapter(sql, Conn)
        Dim dt As New DataTable
        DA.Fill(dt)
        If dt.Rows.Count > 0 Then
            dgvList.DataSource = dt
        Else
            dgvList.DataSource = Nothing
        End If
    End Sub
End Class