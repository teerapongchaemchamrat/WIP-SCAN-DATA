Imports System.Data.SqlClient

Public Class Add
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim connectionString As String = "Data Source=192.168.10.114\APPSERVER;Initial Catalog=App_PUR;User ID=sa;Password=Cyf027065055"
        Dim query As String = "INSERT INTO Scan_WIP (Job, Item, Quantity, Recipient) VALUES (@job, @item, @qty, @name)"

        If String.IsNullOrEmpty(TextBox1.Text) OrElse
           String.IsNullOrEmpty(TextBox2.Text) OrElse
           NumericUpDown1.Value = 0 OrElse
           String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@job", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@item", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@qty", NumericUpDown1.Value)
                    cmd.Parameters.AddWithValue("@name", TextBox4.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Add Successfully")
                    TextBox1.Clear()
                    TextBox2.Clear()
                    NumericUpDown1.Value = NumericUpDown1.Minimum
                    TextBox4.Clear()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub

End Class