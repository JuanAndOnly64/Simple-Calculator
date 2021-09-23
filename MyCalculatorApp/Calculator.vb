Public Class Calculator


    Dim MathProblem As String = ""
    Dim FirstNumberString As String = ""
    Dim SecondNumberString As String = ""
    Dim ButtonCounter As Integer = 0
    Dim DeciamlCounter As Integer = 0
    Dim NegativeCounter As Integer = 0
    Dim FirstNumberInt As Double = 0
    Dim SecondNumberInt As Double = 0
    Dim Add As Integer = 0
    Dim Subtract As Integer = 0
    Dim Divide As Integer = 0
    Dim Multiply As Integer = 0

    'Numbers, Deciaml, and Negative/Positive buttons
    '/////////////////////////////////////////////////////////////////////////////
    'The button for number 1 
    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles BtnNum1.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "1"

    End Sub

    'The button for number 2
    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles BtnNum2.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "2"

    End Sub

    'The button for number 3
    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles BtnNum3.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "3"

    End Sub

    'The button for number 4
    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles BtnNum4.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "4"

    End Sub

    'The button for number 5
    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles BtnNum5.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "5"

    End Sub

    'The button for number 6
    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles BtnNum6.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "6"

    End Sub

    'The button for number 7
    Private Sub btnNum7Click(sender As Object, e As EventArgs) Handles BtnNum7.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "7"

    End Sub

    'The button for number 8
    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles BtnNum8.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "8"

    End Sub

    'The button for number 9
    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles BtnNum9.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "9"

    End Sub

    'The button for number 0
    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles BtnNum0.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        NumDisplay.Text = NumDisplay.Text + "0"

    End Sub

    'The button for the Decimal
    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles BtnDecimal.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        If DeciamlCounter = 0 Then
            NumDisplay.Text = NumDisplay.Text + "."
            DeciamlCounter = 1

        Else DeciamlCounter = 1
            NumDisplay.Text = NumDisplay.Text + ""
        End If

    End Sub

    Private Sub BtnNegative_Click(sender As Object, e As EventArgs) Handles BtnNegative.Click
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If

        If NegativeCounter = 0 Then
            NumDisplay.Text = "-" + NumDisplay.Text
            NegativeCounter = 1

        Else negativecounter = 1
            NumDisplay.Text = NumDisplay.Text.Remove(0, 1)
            NegativeCounter = 0
        End If




    End Sub
    '/////////////////////////////////////////////////////////
    'The button to clear the dislay Label
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        NumDisplay.Text = ("")
        Add = 0
        Subtract = 0
        Divide = 0
        Multiply = 0
        ButtonCounter = 0
        DeciamlCounter = 0
        NegativeCounter = 0

        FirstNumberString = ""
        SecondNumberString = ""

    End Sub
    'Plus, Minus, Add, Subtract, Equal buttons
    '////////////////////////////////////////////////////////////
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        FirstNumberString = ""
        SecondNumberString = ""

        MathProblem = NumDisplay.Text
        FirstNumberString = MathProblem
        Add = 1
        ButtonCounter = 1
        MathProblem = ""

        Subtract = 0
        Divide = 0
        Multiply = 0
    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        FirstNumberString = ""
        SecondNumberString = ""

        MathProblem = NumDisplay.Text
        FirstNumberString = MathProblem
        Subtract = 1
        ButtonCounter = 1
        MathProblem = ""

        Add = 0
        Divide = 0
        Multiply = 0
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles BtnDivide.Click
        FirstNumberString = ""
        SecondNumberString = ""

        MathProblem = NumDisplay.Text
        FirstNumberString = MathProblem
        Divide = 1
        ButtonCounter = 1
        MathProblem = ""

        Add = 0
        Subtract = 0
        Multiply = 0
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        FirstNumberString = ""
        SecondNumberString = ""

        MathProblem = NumDisplay.Text
        FirstNumberString = MathProblem
        Multiply = 1
        ButtonCounter = 1
        MathProblem = ""

        Add = 0
        Subtract = 0
        Divide = 0
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click

        If (Add = 1) Then
            MathProblem = NumDisplay.Text
            SecondNumberString = MathProblem

            FirstNumberInt = Double.Parse(FirstNumberString)
            SecondNumberInt = Double.Parse(SecondNumberString)

            NumDisplay.Text = FirstNumberInt + SecondNumberInt

            Add = 0
            Subtract = 0
            Divide = 0
            Multiply = 0

            FirstNumberString = ""
            SecondNumberString = ""


        ElseIf (Subtract = 1) Then
            MathProblem = NumDisplay.Text
            SecondNumberString = MathProblem

            FirstNumberInt = Double.Parse(FirstNumberString)
            SecondNumberInt = Double.Parse(SecondNumberString)

            NumDisplay.Text = FirstNumberInt - SecondNumberInt

            Add = 0
            Subtract = 0
            Divide = 0
            Multiply = 0

            FirstNumberString = ""
            SecondNumberString = ""

        ElseIf (Multiply = 1) Then
            MathProblem = NumDisplay.Text
            SecondNumberString = MathProblem

            FirstNumberInt = Double.Parse(FirstNumberString)
            SecondNumberInt = Double.Parse(SecondNumberString)

            NumDisplay.Text = FirstNumberInt * SecondNumberInt

            Add = 0
            Subtract = 0
            Divide = 0
            Multiply = 0

            FirstNumberString = ""
            SecondNumberString = ""

        ElseIf (Divide = 1) Then
            MathProblem = NumDisplay.Text
            SecondNumberString = MathProblem

            FirstNumberInt = Double.Parse(FirstNumberString)
            SecondNumberInt = Double.Parse(SecondNumberString)

            NumDisplay.Text = FirstNumberInt / SecondNumberInt

            Add = 0
            Subtract = 0
            Divide = 0
            Multiply = 0

            FirstNumberString = ""
            SecondNumberString = ""

        End If

    End Sub

End Class
