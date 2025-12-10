Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=library_inventory")
                conn.Open()

                If tbID.Text <> String.Empty And
                   tbTitle.Text <> String.Empty And
                   tbAuthor.Text <> String.Empty And
                   cmbCategory.Text <> String.Empty Then

                    Dim checkQuery As String = "SELECT COUNT(*) FROM library_tbl WHERE id = @id"
                    Using checkCmd As New MySqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@id", tbID.Text)
                        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                        If count > 0 Then
                            MessageBox.Show("ID already exists. Please enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            tbID.Focus()
                            Return
                        End If
                    End Using

                    Dim availability As String = ""
                    If cbxAvailable.Checked Then
                        availability = "Available"
                    ElseIf cbxNA.Checked Then
                        availability = "Not Available"
                    Else
                        MessageBox.Show("Please select if Available/Not Available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim query As String = "INSERT INTO library_tbl (id, title, author, category, availability, is_deleted) VALUES (@id, @title, @author, @category, @availability, 0)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", tbID.Text)
                        cmd.Parameters.AddWithValue("@title", tbTitle.Text)
                        cmd.Parameters.AddWithValue("@author", tbAuthor.Text)
                        cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
                        cmd.Parameters.AddWithValue("@availability", availability)

                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Book added to your inventory.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        tbID.Clear()
                        tbTitle.Clear()
                        tbAuthor.Clear()
                        cmbCategory.SelectedIndex = -1
                        cbxAvailable.Checked = False
                        cbxNA.Checked = False
                        RefreshGrid()
                    End Using

                Else
                    MessageBox.Show("Please fill out all the needed information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim query As String = "SELECT id, title, author, category, availability FROM library_tbl WHERE is_deleted = 0"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=library_inventory")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table

                tbID.Clear()
                tbTitle.Clear()
                tbAuthor.Clear()
                cmbCategory.SelectedIndex = -1
                cbxAvailable.Checked = False
                cbxNA.Checked = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If tbID.Text = "" Then
            MessageBox.Show("Double click a book info to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE library_tbl SET title = @title, author = @author, category = @category, availability = @availability WHERE id = @id"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=library_inventory")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)

                    Dim availability As String = ""
                    If cbxAvailable.Checked Then
                        availability = "Available"
                    Else
                        availability = "Not Available"
                    End If

                    cmd.Parameters.AddWithValue("@id", CInt(tbID.Text))
                    cmd.Parameters.AddWithValue("@title", tbTitle.Text)
                    cmd.Parameters.AddWithValue("@author", tbAuthor.Text)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.Text)
                    cmd.Parameters.AddWithValue("@availability", availability)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Book info updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    RefreshGrid()
                    tbID.Clear()
                    tbTitle.Clear()
                    tbAuthor.Clear()
                    cmbCategory.SelectedIndex = -1
                    cbxAvailable.Checked = False
                    cbxNA.Checked = False
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As Integer = CInt(DataGridView1.CurrentRow.Cells("id").Value)

        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then
            Return
        End If

        Dim query As String = "UPDATE library_tbl SET is_deleted = 1 WHERE id = @id"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=library_inventory")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", selectedID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Book deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            RefreshGrid()
            tbID.Clear()
            tbTitle.Clear()
            tbAuthor.Clear()
            cmbCategory.SelectedIndex = -1
            cbxAvailable.Checked = False
            cbxNA.Checked = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshGrid()
        Dim query As String = "SELECT id, title, author, category, availability FROM library_tbl WHERE is_deleted = 0"

        Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=library_inventory")
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            tbID.Text = selectedRow.Cells("id").Value.ToString()
            tbTitle.Text = selectedRow.Cells("title").Value.ToString()
            tbAuthor.Text = selectedRow.Cells("author").Value.ToString()
            cmbCategory.Text = selectedRow.Cells("category").Value.ToString()

            Dim availability As String = selectedRow.Cells("availability").Value.ToString()
            If availability = "Available" Then
                cbxAvailable.Checked = True
                cbxNA.Checked = False
            Else
                cbxAvailable.Checked = False
                cbxNA.Checked = True
            End If
        End If
    End Sub

End Class