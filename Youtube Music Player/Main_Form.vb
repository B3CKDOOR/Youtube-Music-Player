Public Class Main_Form
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Search_form.WebBrowser1.Url = New Uri("http://www.youtube.com/results?search_type=&search_query=" + Searchbox.Text + "&aq=f")
        Search_form.Show()
    End Sub
    Private Sub URLBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles URLBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim urlconvfalse = URLBox.Text
            Dim urlconvtrue As String = urlconvfalse.Replace("/watch?v=", "/v/")
            URLBox.Text = urlconvtrue
            Flash1.Movie = URLBox.Text
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim urlconvfalse = URLBox.Text
        Dim urlconvtrue As String = urlconvfalse.Replace("/watch?v=", "/v/")
        URLBox.Text = urlconvtrue
        Flash1.Movie = URLBox.Text
    End Sub
    Private Sub Searchbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Searchbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub


    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        URLBox.Text = Flash1.Movie
        Flash1.Select()
        Text = ProductName & "  |  Version: " & ProductVersion
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dir = CurDir()
        Dim viddownfalse = URLBox.Text
        Dim viddowntrue As String = viddownfalse.Replace("/v/", "/watch?v=")
        Dim YouDLstr = (Dir & "\youtube-dl.exe --no-continue " & viddowntrue)
        Shell(Dir & "\youtube-dl.exe " & viddowntrue)
    End Sub

End Class