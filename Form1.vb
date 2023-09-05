Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim stCountry As String
        stCountry = txtCountry.Text


        If stCountry = "SOUTH AFRICA" Then
            MsgBox("Molo!")
        ElseIf stCountry = "America" Then
            MsgBox("hi!")
        Else
            MsgBox("Hello!")
        End If

    End Sub
End Class
