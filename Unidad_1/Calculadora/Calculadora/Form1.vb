Public Class Form1
    Dim var1 As Double = 0
    Dim var2 As Double = 0
    Dim var3 As Double = 0
    Dim resultado As Double
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then

            var1 = TextBox1.Text
        Else
            var1 = 0

        End If
        If CheckBox2.Checked Then
            var2 = TextBox2.Text
        Else
            var2 = 0


        End If
        If CheckBox3.Checked Then
            var3 = TextBox3.Text
        Else
            var3 = 0

        End If
        resultado = var1 + var2 + var3
        Label1.Text = resultado
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        Label1.Text = ""
    End Sub
End Class
