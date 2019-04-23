
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
        LinkLabel1.Hide()
        Button2.Hide()
        WebBrowser1.ScriptErrorsSuppressed = True
        If My.Computer.Network.IsAvailable Then
            WebBrowser1.Navigate("Agar.io")
        Else
            Label1.Show()
            LinkLabel1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Button1.Hide()
        Button2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Normal
        Button1.Show()
        Button2.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Computer.Network.IsAvailable Then
            WebBrowser1.Navigate("Agar.io")
            Label1.Hide()
            LinkLabel1.Hide()
        Else
            Label1.Show()
            LinkLabel1.Show()
        End If
    End Sub
End Class
