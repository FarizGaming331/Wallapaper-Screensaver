Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = Form2.TextBox2.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
        ProgressBar1.Value = 0
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Me.Hide()
            Form2.Show()
            ProgressBar1.Value = 0
            Label1.Text = ProgressBar1.Value
        Else
            Label1.Text = ProgressBar1.Value
            ProgressBar1.Value = ProgressBar1.Value + 1
            PictureBox1.Size = Me.Size
        End If
    End Sub
End Class
