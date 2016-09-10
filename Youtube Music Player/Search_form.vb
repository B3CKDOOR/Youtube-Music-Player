Public Class Search_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = WebBrowser1.Url.ToString()
        Dim urlconvfalse = TextBox1.Text
        Dim urlconvtrue As String = urlconvfalse.Replace("watch?v=", "v/")
        TextBox1.Text = urlconvtrue
        Main_Form.URLBox.Text = urlconvtrue
        Main_Form.Flash1.Movie = urlconvtrue
        Close()
    End Sub
End Class