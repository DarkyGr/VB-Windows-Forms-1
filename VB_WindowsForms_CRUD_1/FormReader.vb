Imports System.Data.SqlClient

Public Class FormReader

    'Load Data to Form
    Private Sub FormReader_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConnection()
        MsgBox("The connection is successful", vbOKOnly + vbInformation, "Reader's System")
    End Sub

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

    'Calculate the position for the panel
    Private Sub PnlTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseMove
        If drag Then
            Me.Location = Me.PointToScreen(New Point(FormReader.MousePosition.X - Me.Location.X - ex,
                                                     FormReader.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        PnlData.Visible = True
    End Sub

    'When the drag is false the panel is stop
    Private Sub PnlTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles PnlTitle.MouseUp
        drag = False
    End Sub
End Class
