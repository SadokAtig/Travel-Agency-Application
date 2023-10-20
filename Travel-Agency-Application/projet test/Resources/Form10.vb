Public Class Form10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("WE HOPE THAT YOU VISIT US SOON :):):)")
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Form1.Hide()
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()
        Form5.Hide()
        Form6.Hide()
        Form7.Hide()
        Form8.Hide()

    End Sub
End Class