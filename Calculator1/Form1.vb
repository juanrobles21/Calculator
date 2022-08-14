Public Class Calculator

    Public number1 As String
    Public number2 As String
    Public symbolOperator As String
    Public result As String
    Private Sub butNumberOne_Click(sender As Object, e As EventArgs) Handles butNumberOne.Click
        txtResult.Text = txtResult.Text + "1"
    End Sub

    Private Sub butNumberTwo_Click(sender As Object, e As EventArgs) Handles butNumberTwo.Click
        txtResult.Text = txtResult.Text + "2"
    End Sub

    Private Sub butNumberThree_Click(sender As Object, e As EventArgs) Handles butNumberThree.Click
        txtResult.Text = txtResult.Text + "3"
    End Sub

    Private Sub butNumberFour_Click(sender As Object, e As EventArgs) Handles butNumberFour.Click
        txtResult.Text = txtResult.Text + "4"
    End Sub

    Private Sub butNumberFive_Click(sender As Object, e As EventArgs) Handles butNumberFive.Click
        txtResult.Text = txtResult.Text + "5"
    End Sub

    Private Sub butNumberSix_Click(sender As Object, e As EventArgs) Handles butNumberSix.Click
        txtResult.Text = txtResult.Text + "6"
    End Sub

    Private Sub butNumberSeven_Click(sender As Object, e As EventArgs) Handles butNumberSeven.Click
        txtResult.Text = txtResult.Text + "7"
    End Sub

    Private Sub butNumberEight_Click(sender As Object, e As EventArgs) Handles butNumberEight.Click
        txtResult.Text = txtResult.Text + "8"
    End Sub

    Private Sub butNumberNine_Click(sender As Object, e As EventArgs) Handles butNumberNine.Click
        txtResult.Text = txtResult.Text + "9"
    End Sub

    Private Sub butClean_Click(sender As Object, e As EventArgs) Handles butClean.Click
        txtResult.Clear()
        txtCache.Clear()


    End Sub

    Private Sub butNumberZero_Click(sender As Object, e As EventArgs) Handles butNumberZero.Click
        txtResult.Text = txtResult.Text + "0"
    End Sub

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click
        number1 = txtResult.Text
        txtResult.Clear()
        symbolOperator = "Add"
        txtCache.Text = number1 + "+"
    End Sub

    Private Sub butSubstract_Click(sender As Object, e As EventArgs) Handles butSubstract.Click
        number1 = txtResult.Text
        txtResult.Clear()
        symbolOperator = "Substract"
        txtCache.Text = number1 + "-"
    End Sub

    Private Sub butMultiply_Click(sender As Object, e As EventArgs) Handles butMultiply.Click
        number1 = txtResult.Text
        txtResult.Clear()
        symbolOperator = "Multiply"
        txtCache.Text = number1 + "*"
    End Sub

    Private Sub butDivide_Click(sender As Object, e As EventArgs) Handles butDivide.Click
        number1 = txtResult.Text
        txtResult.Clear()
        symbolOperator = "Divide"
        txtCache.Text = number1 + "/"
    End Sub

    Private Sub butResult_Click(sender As Object, e As EventArgs) Handles butResult.Click
        number2 = txtResult.Text
        txtResult.Clear()

        If symbolOperator = "Add" Then
            result = Val(number1) + Val(number2)
            txtResult.Text = result
            txtCache.Text = number1 + "+" + number2
        End If

        If symbolOperator = "Substract" Then
            result = Val(number1) - Val(number2)
            txtResult.Text = result
            txtCache.Text = number1 + "-" + number2
        End If

        If symbolOperator = "Multiply" Then
            result = Val(number1) * Val(number2)
            txtResult.Text = result
            txtCache.Text = number1 + "*" + number2
        End If

        If symbolOperator = "Divide" Then
            result = Val(number1) / Val(number2)
            txtResult.Text = result
            txtCache.Text = number1 + "/" + number2
        End If

    End Sub

    Private Sub butHighNumber_Click(sender As Object, e As EventArgs) Handles butHighNumber.Click
        number1 = txtResult.Text
        result = Val(number1) * Val(number1)
        txtResult.Text = result
        txtCache.Text = number1 + "^2"
    End Sub

    Private Sub butSqr_Click(sender As Object, e As EventArgs) Handles butSqr.Click
        number1 = txtResult.Text
        result = Math.Sqrt(d:=Val(number1))
        txtResult.Text = result
        txtCache.Text = "sqr(" + number1 + ")"
    End Sub
End Class
