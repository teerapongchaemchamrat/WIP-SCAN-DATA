Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports OfficeOpenXml
Imports System.Globalization

Public Class Form1

    Dim connection As New SqlConnection("Data Source=192.168.10.114\APPSERVER;Initial Catalog=App_PUR;User ID=sa;Password=XXXXXXXXXX")
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True ' Cancel the closing event
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'App_PURDataSet.Scan_WIP' table. You can move, or remove it, as needed.
        ''Me.Scan_WIPTableAdapter.Fill(Me.App_PURDataSet.Scan_WIP)
        'Dim command As New SqlCommand("SELECT DISTINCT Item FROM Scan_WIP", connection)
        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()
        'adapter.Fill(table)

        ''Dim emptyRow As DataRow = table.NewRow()
        ''emptyRow("Item") = ""
        ''table.Rows.InsertAt(emptyRow, 0)
        'ComboBox1.Items.Clear()

        'ComboBox1.DataSource = table
        'ComboBox1.DisplayMember = "Item"
        'ComboBox1.ValueMember = "Item"

    End Sub

    Public Sub FilterData(valueToSearch As String)
        'Dim searchQuery As String = "exec WIP_searchDate '" & valueToSearch & "'"

        'Dim command As New SqlCommand(searchQuery, connection)
        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()

        'adapter.Fill(table)
        'DataGridView1.DataSource = table

        Dim searchQuery As String = "exec WIP_searchDate '" & valueToSearch & "'"
        Dim command As New SqlCommand(searchQuery, connection)

        adapter.Fill(table)
        DataGridView1.DataSource = table

        'DataGridView1.RowTemplate.Height = 50

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedDate As DateTime = DateTimePicker1.Value
        Dim dateString As String = selectedDate.ToString("yyyy-MM-dd")
        FilterData(dateString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExportToExcel()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Query As String = "SELECT * FROM Scan_WIP"
        Dim command As New SqlCommand(Query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table

        'DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'DataGridView1.RowTemplate.Height = 150
    End Sub

    Private Sub ExportToExcel()
        Dim pictureColumnIndex As Integer = -1
        Dim cameraColumnIndex As Integer = -1

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        ' Find the index of the "Picture" column
        For columnIndex As Integer = 0 To DataGridView1.Columns.Count - 1
            If DataGridView1.Columns(columnIndex).HeaderText = "Picture" Then
                pictureColumnIndex = columnIndex
                Exit For
            End If
        Next

        For columnIndex As Integer = 0 To DataGridView1.Columns.Count - 1
            If DataGridView1.Columns(columnIndex).HeaderText = "Camera" Then
                cameraColumnIndex = columnIndex
                Exit For
            End If
        Next

        If pictureColumnIndex >= 0 AndAlso cameraColumnIndex >= 0 Then
            ' Create a new Excel package
            Using package As New ExcelPackage()
                ' Add a new worksheet to the Excel package
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Data")

                ' Set the column headers in Excel
                For columnIndex As Integer = 0 To DataGridView1.Columns.Count - 1
                    worksheet.Cells(1, columnIndex + 1).Value = DataGridView1.Columns(columnIndex).HeaderText
                Next

                ' Fix row 1 height
                worksheet.Row(1).Height = 20
                worksheet.Column(6).Width = 50
                worksheet.Column(7).Width = 50

                ' Define image width and height
                Dim imageWidth As Integer = 40      '80
                Dim imageHeight As Integer = 40     '80

                Dim imageWidth2 As Integer = 80     '180
                Dim imageHeight2 As Integer = 50    '100

                ' Export data from DataGridView to Excel
                For rowIndex As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
                    For columnIndex As Integer = 0 To DataGridView1.Columns.Count - 1
                        If columnIndex = pictureColumnIndex Then ' Handle the picture column
                            Dim cellValue As Object = row.Cells(columnIndex).Value
                            If cellValue IsNot Nothing AndAlso TypeOf cellValue Is Byte() Then
                                Dim imageBytes As Byte() = DirectCast(cellValue, Byte())
                                Using imageStream As New MemoryStream(imageBytes)
                                    ' Add the image to the Excel worksheet
                                    Dim picture = worksheet.Drawings.AddPicture("picture" & rowIndex, imageStream)
                                    ' Set the position of the image to the Picture column
                                    picture.SetPosition(rowIndex + 1, 0, pictureColumnIndex, 0)
                                    picture.SetSize(imageWidth, imageHeight)
                                End Using
                            End If
                        ElseIf columnIndex = cameraColumnIndex Then
                            Dim cellValue As Object = row.Cells(columnIndex).Value
                            If cellValue IsNot Nothing AndAlso TypeOf cellValue Is Byte() Then
                                Dim imageBytes As Byte() = DirectCast(cellValue, Byte())
                                Using imageStream As New MemoryStream(imageBytes)
                                    ' Add the image to the Excel worksheet
                                    Dim camera = worksheet.Drawings.AddPicture("camera" & rowIndex, imageStream)
                                    ' Set the position of the image to the Picture column
                                    camera.SetPosition(rowIndex + 1, 0, cameraColumnIndex, 0)
                                    camera.SetSize(imageWidth2, imageHeight2)
                                End Using
                            End If

                        Else ' Handle other columns
                            Dim cellValue As Object = row.Cells(columnIndex).Value
                            worksheet.Cells(rowIndex + 2, columnIndex + 1).Value = If(cellValue IsNot Nothing, cellValue.ToString(), String.Empty)
                        End If
                    Next

                    ' Fix row height
                    worksheet.Row(rowIndex + 2).Height = 80
                Next

                ' Save the Excel package to a file
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Files (*.xls)|*.xls"
                saveFileDialog.FileName = "ExportedData.xls"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = saveFileDialog.FileName
                    Dim file As New FileInfo(filePath)
                    ' Auto-fit columns before saving the Excel package
                    worksheet.Cells.AutoFitColumns()
                    package.SaveAs(file)
                    MessageBox.Show("Data exported to Excel successfully.")
                End If
            End Using
        Else
            MessageBox.Show("Picture column not found.")
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Add.Show()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'Delete.Show()
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1

            Dim originalDateString As String = DataGridView1.SelectedRows(i).Cells(4).Value.ToString()
            Dim originalDate As DateTime = DateTime.ParseExact(originalDateString, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture)
            Dim formattedDateString As String = originalDate.ToString("yyyy-MM-dd HH:mm:ss")

            Dim cmd As New SqlCommand("DELETE FROM Scan_WIP WHERE DATEADD(ms, -DATEPART(ms, [Date]), [Date]) = @date", connection)

            Try
                connection.Open()
                cmd.Parameters.AddWithValue("@date", formattedDateString)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data deleted successfully")

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

        Next

        'FilterData(DateString)

    End Sub

End Class
