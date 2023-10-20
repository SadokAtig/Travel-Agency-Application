Imports System.IO
Public Class Form5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form7.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            MsgBox("PLEASE ENTER YOUR ARRIVAL TO CONFIRME your destntions")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fs As New FileStream("C:\Users\atigs\Desktop\pays.text", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim t() As String
        Dim t1() As String
        Dim t2() As String
        Dim trouve As Integer
        While sr.Peek > -1
            s = sr.ReadLine
            t = s.Split("#")
            t1 = s.Split(";")
            trouve = 0
            If s <> "" Then
                t2 = s.Split()
                If TextBox1.Text = "canada" Or TextBox1.Text = "brazil" Or TextBox1.Text = "usa" Or TextBox1.Text = "uk" Or TextBox1.Text = "turkey" Or TextBox1.Text = "colombia" Or TextBox1.Text = "emirates" Or TextBox1.Text = "allemand" Or TextBox1.Text = "italy" Or TextBox1.Text = "france" Or TextBox1.Text = "japan" Or TextBox1.Text = "china" Or TextBox1.Text = "morroco" Or TextBox1.Text = "span" Or TextBox1.Text = "ressua" Or TextBox1.Text = "greece" Or TextBox1.Text = "egypte" Then
                    ListBox1.Items.Add(t2(0))
                    trouve = trouve + 1
                End If


            End If
        End While
        sr.Close()
        fs.Close()

    End Sub
End Class