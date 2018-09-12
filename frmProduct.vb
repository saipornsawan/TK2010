Imports System.Data.OleDb
Imports System.Data
Imports System.Text

Public Class frmProduct
    Dim Conn As New OleDbConnection
    Dim DA As OleDbDataAdapter
    Dim com As New OleDbCommand

    Dim dt As New DataTable
    Dim sql As String = ""
    Dim sb As New StringBuilder("")

    Private Sub bttFind_Click(sender As Object, e As EventArgs) Handles bttFind.Click
        If txtFind.Text.Trim = "" Then
            err.SetError(T_noTextBox, "กรุณาระบุ!!")
            Exit Sub
        Else
            err.SetError(T_noTextBox, "")
        End If

        sql = "SELECT * FROM Product WHERE (Pro_no = ?) "
        DA = New OleDbDataAdapter(sql, Conn)
        DA.SelectCommand.Parameters.Clear()
        DA.SelectCommand.Parameters.AddWithValue("?", txtFind.Text)
        Dim dt As New DataTable
        DA.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.Pro_noTextBox.Text = dt.Rows(0).Item("Pro_no")
            Me.Pro_nameTextBox.Text = dt.Rows(0).Item("Pro_name")
        Else
            MsgBox("ไม่พบข้อมูล")
        End If

    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With
        GetData()
        Conn.Close()
    End Sub

    Private Sub bttUpdate_Click(sender As System.Object, e As System.EventArgs) Handles bttUpdate.Click
        If (MessageBox.Show("ต้องการแก้ไขใช่ หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes) Then
            Try
                sql = "UPDATE Product SET pro_name=?"
                sql &= " WHERE (pro_no=?)"

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
                    .Parameters.Add("?", OleDbType.VarChar).Value = Pro_nameTextBox.Text
                    .Parameters.Add("?", OleDbType.VarChar).Value = Pro_noTextBox.Text
                    .ExecuteNonQuery()
                End With

                MsgBox("OK")

                GetData()

            Catch ex As Exception
                MsgBox("ไม่สามารถ ดำเนินการได้เนื่องจาก: " & ex.Message)
            Finally

            End Try
        End If
    End Sub

    Private Sub GetData()
        sql = "SELECT * FROM product "
        DA = New OleDbDataAdapter(sql, Conn)
        Dim dt As New DataTable
        DA.Fill(dt)
        If dt.Rows.Count > 0 Then
            dgvList.DataSource = dt

        Else
            dgvList.DataSource = Nothing
        End If
    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            bttFind.PerformClick()
        End If
    End Sub

    Private Sub txtFind_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub bttDel_Click(sender As System.Object, e As System.EventArgs) Handles bttDel.Click
        If (MessageBox.Show("ต้องการ ลบใช่ หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes) Then
            Try
                sql = "DELETE FROM Product"
                sql &= " WHERE (pro_no=?)"

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
                    .Parameters.Add("?", OleDbType.VarChar).Value = Pro_noTextBox.Text
                    .ExecuteNonQuery()
                End With

                MsgBox("OK")

                GetData()

            Catch ex As Exception
                MsgBox("ไม่สามารถ ดำเนินการได้เนื่องจาก: " & ex.Message)
            Finally

            End Try
        End If
    End Sub
End Class
