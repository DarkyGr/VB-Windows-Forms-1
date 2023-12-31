﻿Imports System.Data.SqlClient

Public Class FormReader

    'Load Data to Form
    Private Sub FormReader_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConnection()
        Show()
        'MsgBox("The connection is successful", vbOKOnly + vbInformation, "Reader's System")
    End Sub

    'Variables to the position of the mouse and drag the window
    Dim ex, ey As Integer
    Dim drag As Boolean

    'Define the variables when click the mouse
    Private Sub PnlTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseDown
        ex = e.X
        ey = e.Y
        drag = True
    End Sub

    'Calculate and drag the position for the panel
    Private Sub PnlTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseMove
        If drag Then
            Me.Location = Me.PointToScreen(New Point(FormReader.MousePosition.X - Me.Location.X - ex,
                                                     FormReader.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    'When the drag is false the panel is stop
    Private Sub PnlTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseUp
        drag = False
    End Sub

    'Close Button
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    'Add Button
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        PnlData.Visible = True
        BtnSave.Enabled = True
        BtnSave.BackColor = Color.LimeGreen
        BtnEdit.Enabled = False
        BtnEdit.BackColor = Color.Gray
        BtnCancel.Enabled = True
        TxtRId.Enabled = True
        TxtRId.BackColor = Color.White
        TxtRId.Focus()
    End Sub

    'Save Button
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim cmd As New SqlCommand

        'If it's different to void
        If TxtRName.Text <> "" And TxtRId.Text <> "" Then
            Try
                OpenConnection()
                cmd = New SqlCommand("sp_CreateReader", connection)
                cmd.CommandType = 4

                cmd.Parameters.AddWithValue("@readerId", TxtRId.Text.ToString)
                cmd.Parameters.AddWithValue("@readerName", TxtRName.Text.ToString)
                cmd.Parameters.AddWithValue("@readerPhone", TxtRPhone.Text)
                cmd.Parameters.AddWithValue("@readerAddress", TxtRAddress.Text.ToString)
                cmd.Parameters.AddWithValue("@readerObservations", TxtRObservations.Text.ToString)
                cmd.ExecuteNonQuery()

                CloseConnection()
                PnlData.Visible = False
                Clean()
                Show()


            Catch ex As Exception

            End Try
        Else
            MsgBox("The Reader ID and Name fields are required", vbInformation + vbOKOnly, "Warning")

        End If
    End Sub

    'Cancel Button
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Clean()
        BtnSave.Enabled = True
        BtnEdit.Enabled = True
        BtnCancel.Enabled = True
        PnlData.Visible = False
    End Sub

    'Clean Method
    Private Sub Clean()
        TxtRId.Clear()
        TxtRName.Clear()
        TxtRPhone.Clear()
        TxtRAddress.Clear()
        TxtRObservations.Clear()
        TxtRId.Focus()
    End Sub

    'Show Readers Method
    Sub Show()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("sp_ShowReader", connection)

            da.Fill(dt)
            DGReaders.DataSource = dt
            CloseConnection()

            customizingDGReaders()

        Catch ex As Exception

        End Try
    End Sub

    'Text Search
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Search()
        PnlData.Visible = False
    End Sub

    'Search Method (Only reader ID and Name)
    Sub Search()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("sp_SearchReader", connection)

            'Adding commnad type and parameters
            da.SelectCommand.CommandType = 4 'The 4 is because variables are being used
            da.SelectCommand.Parameters.AddWithValue("@Search", TxtSearch.Text)

            da.Fill(dt)
            DGReaders.DataSource = dt
            CloseConnection()

            customizingDGReaders()

        Catch ex As Exception

        End Try
    End Sub

    'Update Button
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim cmd As New SqlCommand

        'If it's different to void
        If TxtRName.Text <> "" And TxtRId.Text <> "" Then
            Try
                OpenConnection()
                cmd = New SqlCommand("sp_UpdateReader", connection)
                cmd.CommandType = 4

                cmd.Parameters.AddWithValue("@readerId", TxtRId.Text.ToString)
                cmd.Parameters.AddWithValue("@readerName", TxtRName.Text.ToString)
                cmd.Parameters.AddWithValue("@readerPhone", TxtRPhone.Text)
                cmd.Parameters.AddWithValue("@readerAddress", TxtRAddress.Text.ToString)
                cmd.Parameters.AddWithValue("@readerObservations", TxtRObservations.Text.ToString)
                cmd.ExecuteNonQuery()

                CloseConnection()
                PnlData.Visible = False
                Clean()
                Show()

            Catch ex As Exception

            End Try
        Else
            MsgBox("The Reader Name field is required and the Phone field it only takes numbers", vbInformation + vbOKOnly, "Warning")

        End If
    End Sub

    'Update Reader - Double Click on the Data Grid View Readers
    Private Sub DGReaders_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReaders.CellContentDoubleClick
        PnlData.Visible = True

        Try
            TxtRId.Text = DGReaders.SelectedCells.Item(1).Value
            TxtRName.Text = DGReaders.SelectedCells.Item(2).Value
            TxtRPhone.Text = DGReaders.SelectedCells.Item(3).Value
            TxtRAddress.Text = DGReaders.SelectedCells.Item(4).Value
            TxtRObservations.Text = DGReaders.SelectedCells.Item(5).Value

            TxtRId.Enabled = False
            TxtRId.BackColor = Color.LightGray

            BtnSave.Enabled = False
            BtnSave.BackColor = Color.Gray
            BtnEdit.Enabled = True
            BtnEdit.BackColor = Color.Orange
        Catch ex As Exception

        End Try

    End Sub

    'Delete Reader - Once Click
    Private Sub DGReaders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReaders.CellContentClick
        If e.ColumnIndex = DGReaders.Columns.Item("Delete").Index Then
            Dim result As DialogResult
            result = MsgBox("Are you sure to delete this reader?", vbQuestion + vbOKCancel, "Delete Reader")

            If result = DialogResult.OK Then
                Dim cmd As SqlCommand

                Try
                    OpenConnection()
                    cmd = New SqlCommand("sp_DeleteReader", connection)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@readerId", DGReaders.SelectedCells.Item(1).Value)

                    cmd.ExecuteNonQuery()
                    CloseConnection()
                    Show()

                Catch ex As Exception

                End Try

            Else
                MsgBox("Deletion canceled", vbInformation + vbOKOnly, "Warning")
            End If
        End If
    End Sub

    'Customizing the data grid view readers
    Sub customizingDGReaders()
        'Change heigth to all rows
        For i = 0 To DGReaders.Rows.Count - 1
            DGReaders.Rows(i).Height = 45
        Next

        'Change width colums
        DGReaders.Columns(0).Width = 35
        DGReaders.Columns(1).Width = 80
        DGReaders.Columns(2).Width = 150
        DGReaders.Columns(3).Width = 100
        DGReaders.Columns(4).Width = 250
        DGReaders.Columns(5).Width = 250

        'Change header appearance
        DGReaders.EnableHeadersVisualStyles = False
        Dim style As DataGridViewCellStyle = New DataGridViewCellStyle()
        style.BackColor = Color.White
        style.ForeColor = Color.Black
        style.Font = New Font("Segoe UI", 10, FontStyle.Regular Or FontStyle.Bold)
        DGReaders.ColumnHeadersDefaultCellStyle = style
    End Sub
End Class
