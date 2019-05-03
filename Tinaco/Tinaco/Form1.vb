Public Class Form1
    Dim captot, con As Double
    Dim en, s1, s2, st, lts, cap, lr As Double
    Dim en2, s12, s22, st2, lts2, cap2, lr2 As Double
    Dim en3, s13, s23, st3, lts3, cap3, lr3 As Double


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        End
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MyPB1.Increment(lts)


        If MyPB1.Value = cap Then

        End If
        Label5.Visible = True

        Label5.Text = MyPB1.Value & (" %")
        'segundo ticaco
        MyPB2.Increment(lts2)


        If MyPB2.Value = cap2 Then

        End If
        Label16.Visible = True

        Label16.Text = MyPB2.Value & (" %")
        'tercer tinnaco
        MyPB3.Increment(lts3)


        If MyPB3.Value = cap3 Then

        End If
        Label17.Visible = True

        Label17.Text = MyPB3.Value & (" %")



    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        captot = ComboBox2.Text
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub MyPB1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyPB1.Click

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub MyPB2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyPB2.Click

    End Sub

    Private Sub MyPB3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyPB3.Click

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        en = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        en2 = TextBox6.Text
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        en3 = TextBox11.Text
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Timer1.Start()
        con = en + en2 + en3
        If captot < con Then
            MsgBox("Te falta un poco de la entrada total distribullela mejor")
        End If
        If captot > con Then
            MsgBox("Te sobra un poco de la entrada total distribullela mejor")
        Else
            s1 = TextBox3.Text
            s2 = TextBox4.Text
            cap = TextBox5.Text

            st = s1 + s2

            If en < st Then
                MsgBox("Joven tu suma es mayor serias tan amable de cambiarla")
                TextBox3.Text = ""
                TextBox4.Text = ""
                Label5.Text = ""
            Else
                MsgBox("Todo esta listo joven continuemos")
                lr = en - st
            End If

            lts = lr + lts


            'Segundo tinaco.
            s12 = TextBox7.Text
            s22 = TextBox12.Text
            cap2 = TextBox8.Text

            st2 = s12 + s22


            If en2 < st2 Then
                MsgBox("Joven tu suma es mayor serias tan amable de cambiarla")
                TextBox7.Text = ""
                TextBox12.Text = ""
                Label16.Text = ""
            Else
                MsgBox("Todo esta listo joven continuemos")
                lr2 = en2 - st2
            End If

            lts2 = lr2 + lts2

            'tercer tinaco.


            s13 = TextBox9.Text
            s23 = TextBox10.Text
            cap3 = ComboBox1.Text

            st3 = s13 + s23


            If en3 < st3 Then
                MsgBox("Joven tu suma es mayor serias tan amable de cambiarla")
                TextBox9.Text = ""
                TextBox10.Text = ""
                Label17.Text = ""
            Else
                MsgBox("Todo esta listo joven continuemos")
                lr3 = en3 - st3
            End If

            lts3 = lr3 + lts3
        End If
    End Sub

   
End Class
