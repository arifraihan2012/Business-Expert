Imports System.Data
Imports System.Data.SqlClient
Public Class FrmLanguageSetup
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblSelectLanguage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSelectLanguage.Click

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Save Click Msg
        MsgBox("Data Saved Successfully", MsgBoxStyle.OkOnly, "Language Setup")
    End Sub

    Private Sub CmbSelectLanguage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSelectLanguage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnSave.Focus()

        End If
    End Sub

    Private Sub CmbSelectLanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSelectLanguage.SelectedIndexChanged

    End Sub

    Private Sub FrmLanguageSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class