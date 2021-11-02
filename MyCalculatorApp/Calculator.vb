Public Class Calculator


    Dim MathProblem As String = ""
    Dim FirstNumberString As String = ""
    Dim SecondNumberString As String = ""
    Dim ButtonCounter As Integer = 0
    Dim DeciamlCounter As Integer = 0
    Dim NegativeCounter As Integer = 0
    Dim FirstNumberInt As Double = 0
    Dim SecondNumberInt As Double = 0
    Dim FinalTotal As Double = 0
    Dim Add As Integer = 0
    Dim Subtract As Integer = 0
    Dim Divide As Integer = 0
    Dim Multiply As Integer = 0
    Dim Equal As Integer = 0

    'Numbers, Deciaml, and Negative/Positive buttons
    '/////////////////////////////////////////////////////////////////////////////

    'The button for all the numbers
    Private Sub CalcNumButtons(sender As Object, e As EventArgs) Handles BtnNum0.Click, BtnNum1.Click, BtnNum2.Click, BtnNum3.Click,
    BtnNum4.Click, BtnNum5.Click, BtnNum6.Click, BtnNum7.Click, BtnNum8.Click, BtnNum9.Click

        'this will reset the counters and empty the textbox once if you input your second number
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
            Equal = 0
        End If

        'Determines which button was clicked
        Dim intNumClick As Button = CType(sender, Button)
        'will retive whatever is in the tag
        Dim strNum As String = intNumClick.Tag.ToString

        'will display the number to the textbox
        NumDisplay.Text = NumDisplay.Text + strNum

    End Sub


    'The button for the Decimal and Negative/Postive

    Private Sub BtnDNC(sender As Object, e As EventArgs) Handles BtnNegative.Click, BtnDecimal.Click, BtnClear.Click

        'this will reset the counters and empty the textbox once if you input your second number
        If ButtonCounter = 1 Then
            NumDisplay.Text = ""
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0
        End If
        'Determines which button was clicked
        Dim DecimalNegativeClear As Button = CType(sender, Button)
        'will retive whatever is in the tag
        Dim DNC As String = DecimalNegativeClear.Tag.ToString
        'makes sure that you can change number on calculator to negative or back to positive
        If DNC = "Negative" Then
            If NegativeCounter = 0 Then
                NumDisplay.Text = "-" + NumDisplay.Text
                NegativeCounter = 1

            Else NegativeCounter = 1
                NumDisplay.Text = NumDisplay.Text.Remove(0, 1)
                NegativeCounter = 0
            End If

        End If
        'makes sure you can only put one deciaml when clicked
        If DNC = "Decimal" Then
            If DeciamlCounter = 0 Then
                NumDisplay.Text = NumDisplay.Text + "."
                DeciamlCounter = 1

            Else DeciamlCounter = 1
                NumDisplay.Text = NumDisplay.Text + ""
            End If

        End If
        'Clears all values
        If DNC = "Clear" Then
            NumDisplay.Text = ("")
            Add = 0
            Subtract = 0
            Divide = 0
            Multiply = 0
            Equal = 0
            ButtonCounter = 0
            DeciamlCounter = 0
            NegativeCounter = 0

            FirstNumberString = ""
            SecondNumberString = ""
        End If

    End Sub

    'Plus, Minus, Add, Subtract buttons
    '////////////////////////////////////////////////////////////
    Private Sub Symbol_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click, BtnMinus.Click, BtnMultiply.Click,
        BtnDivide.Click
        FirstNumberString = ""
        SecondNumberString = ""

        'Determines which button was clicked
        Dim Symbol As Button = CType(sender, Button)
        'will retive whatever is in the tag
        Dim strSymbol As String = Symbol.Tag.ToString

        'this entire if statment will check if either the add, subtract, divide, or multiply buttons were clicked
        If strSymbol = "Add" Then

            MathProblem = NumDisplay.Text
            FirstNumberString = MathProblem
            FirstNumberInt = Double.Parse(FirstNumberString)
            FinalTotal = FirstNumberInt
            Add = 1
            ButtonCounter = 1
            MathProblem = ""

            Subtract = 0
            Divide = 0
            Multiply = 0
            Equal = 0


        ElseIf strSymbol = "Subtract" Then

            MathProblem = NumDisplay.Text
            FirstNumberString = MathProblem
            FirstNumberInt = Double.Parse(FirstNumberString)
            FinalTotal = FirstNumberInt
            Subtract = 1
            ButtonCounter = 1
            MathProblem = ""

            Add = 0
            Divide = 0
            Multiply = 0
            Equal = 0

        ElseIf strSymbol = "Divide" Then

            MathProblem = NumDisplay.Text
            FirstNumberString = MathProblem
            FirstNumberInt = Double.Parse(FirstNumberString)
            FinalTotal = FirstNumberInt
            Divide = 1
            ButtonCounter = 1
            MathProblem = ""

            Add = 0
            Subtract = 0
            Multiply = 0
            Equal = 0

        ElseIf strSymbol = "Multiply" Then

            MathProblem = NumDisplay.Text
            FirstNumberString = MathProblem
            FirstNumberInt = Double.Parse(FirstNumberString)
            FinalTotal = FirstNumberInt
            Multiply = 1
            ButtonCounter = 1
            MathProblem = ""

            Add = 0
            Subtract = 0
            Divide = 0
            Equal = 0
        End If
    End Sub

    'equal button
    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click

        If (Add = 1) Then
            If Equal = 0 Then
                MathProblem = NumDisplay.Text
                SecondNumberString = MathProblem
                SecondNumberInt = Double.Parse(SecondNumberString)

                FinalTotal = FinalTotal + SecondNumberInt
                NumDisplay.Text = FinalTotal

                Subtract = 0
                Divide = 0
                Multiply = 0
                Equal = 1
                MathProblem = ""

            ElseIf Equal = 1 Then
                FinalTotal = FinalTotal + SecondNumberInt
                NumDisplay.Text = FinalTotal

                'MathProblem = ""
            End If
            '////////////////////////////////////////
        ElseIf (Subtract = 1) Then
            If Equal = 0 Then
                MathProblem = NumDisplay.Text
                SecondNumberString = MathProblem
                SecondNumberInt = Double.Parse(SecondNumberString)

                FinalTotal = FirstNumberInt - SecondNumberInt
                NumDisplay.Text = FinalTotal

                Add = 0
                'Subtract = 0
                Divide = 0
                Multiply = 0
                Equal = 1

            ElseIf Equal = 1 Then
                FinalTotal = FinalTotal - SecondNumberInt
                NumDisplay.Text = FinalTotal
            End If
            '////////////////////////////////////////
        ElseIf (Multiply = 1) Then
            If Equal = 0 Then
                MathProblem = NumDisplay.Text
                SecondNumberString = MathProblem

                FirstNumberInt = Double.Parse(FirstNumberString)
                SecondNumberInt = Double.Parse(SecondNumberString)

                FinalTotal = FirstNumberInt * SecondNumberInt
                NumDisplay.Text = FinalTotal

                Add = 0
                Subtract = 0
                Divide = 0
                'Multiply = 0
                Equal = 1

            ElseIf Equal = 1 Then
                FinalTotal = FinalTotal * SecondNumberInt
                NumDisplay.Text = FinalTotal
            End If
            '////////////////////////////////////////
        ElseIf (Divide = 1) Then
            If Equal = 0 Then
                MathProblem = NumDisplay.Text
                SecondNumberString = MathProblem

                FirstNumberInt = Double.Parse(FirstNumberString)
                SecondNumberInt = Double.Parse(SecondNumberString)

                FinalTotal = FirstNumberInt / SecondNumberInt
                NumDisplay.Text = FinalTotal

                Add = 0
                Subtract = 0
                'Divide = 0
                Multiply = 0
                Equal = 1

            ElseIf Equal = 1 Then
                FinalTotal = FinalTotal / SecondNumberInt
                NumDisplay.Text = FinalTotal
            End If


        End If

    End Sub

End Class
