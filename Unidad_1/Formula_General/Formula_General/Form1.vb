Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim c As Double
    Dim raiz As Double
    Dim raiz2 As Double
    Dim resultado As Double

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click

    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        End
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        resultado = (b * b - (4 * a * c))
        raiz = ((-b) + Math.Sqrt(resultado)) / (2 * a)
        raiz2 = ((-b) - Math.Sqrt(resultado)) / (2 * a)
        L8.Text = raiz
        L9.Text = raiz2




    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub L9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L9.Click

    End Sub
End Class
