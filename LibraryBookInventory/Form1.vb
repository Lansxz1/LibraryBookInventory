Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database= library_inventory"

        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim query As String = "INSERT INTO library_tbl (id, title, author) VALUES (@id, @title, @author)"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database= library_inventory")
                conn.Open()
            End Using
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", tbID.Text)
                cmd.Parameters.AddWithValue("@title", tbTitle.Text)
                cmd.Parameters.AddWithValue("@author", tbAuthor.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record insert successful", "Record Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub


End Class
