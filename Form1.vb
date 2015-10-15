'Khadija Bibi
'ID-21301171
'Date: 10/09/2015
'Version:1.0.0


Public Class Form1

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        Dim i As Integer = 0

        For i = 0 To 10
            MessageBox.Show("The value of i is: " & i)
        Next

    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        Dim num1 As Integer = 1

        Do While num1 < 10
            MessageBox.Show("The value of num1 is :" & num1)
            num1 = num1 + 1
        Loop

    End Sub

    Private Sub btnUntil_Click(sender As Object, e As EventArgs) Handles btnUntil.Click
        Dim num As Integer = 1

        Do Until num = 5
            MessageBox.Show("The value of num is: " & num)
            num = num + 1
        Loop

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
