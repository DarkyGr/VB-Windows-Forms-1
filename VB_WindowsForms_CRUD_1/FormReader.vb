Imports System.Data.SqlClient

Public Class FormReader

    'Load Data to Form
    Private Sub FormReader_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConnection()
        'MsgBox("The connection is successful", vbOKOnly + vbInformation, "Reader's System")
    End Sub

    'Close Button
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
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

    'Add Button
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        PnlData.Visible = True
        BtnSave.Enabled = True
        BtnEdit.Enabled = False
        BtnEdit.BackColor = Color.Gray
        BtnCancel.Enabled = True
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

    'When the drag is false the panel is stop
    Private Sub PnlTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseUp
        drag = False
    End Sub
End Class
