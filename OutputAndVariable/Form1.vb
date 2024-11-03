Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click


        MsgBox("Welcome to VB.NET Programming")

        MessageBox.Show("This is another way to display message")



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVariable.Click

        Dim FirstName As String
        Dim LastName As String

        FirstName = "Anas"
        LastName = "Yakubu"

        MsgBox("Hello and Welcome" & " " & FirstName & " " & LastName)

        FirstName = "Abbas"
        LastName = "Yakubu"


        MsgBox("Hello and Welcome" & " " & FirstName & " " & LastName)



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles DataType.Click
        Dim Make As String
        Dim Model As String
        Dim Doors As Integer
        Dim Colour As String
        Dim isTaxed As Boolean
        Dim Price As Decimal
        Dim DateRegister As Date




        Make = "Ford"
        Model = "Escort"
        Doors = 5
        Colour = "Red"
        isTaxed = True
        Price = 999.99
        DateRegister = #11/3/2024#

        MsgBox("The car is " & Make & vbNewLine & Model & vbNewLine &
               Doors & vbNewLine & Colour & vbNewLine & isTaxed & vbNewLine & Price & vbNewLine & DateRegister)



    End Sub
End Class
