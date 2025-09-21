Public Class Calculator

    ' Track if result was just shown
    Private resultShown As Boolean = False

    ' ---------------------------
    ' Form Setup
    ' ---------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.KeyPreview = True ' Allow form to capture key presses
    End Sub

    ' ---------------------------
    ' DIGIT BUTTONS
    ' ---------------------------
    Private Sub Digit_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click,
        Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        If txtDisplay.Text = "Error" Then Exit Sub

        If resultShown Then
            txtDisplay.Text = ""
            resultShown = False
        End If

        Dim btn As Button = CType(sender, Button)
        Dim digit As String = btn.Text

        ' Prevent leading zero in new number segment
        If digit = "0" Then
            If txtDisplay.Text = "" Then Exit Sub

            Dim lastOpIndex As Integer = txtDisplay.Text.LastIndexOfAny("+-*/".ToCharArray())
            Dim currentSegment As String = If(lastOpIndex >= 0, txtDisplay.Text.Substring(lastOpIndex + 1), txtDisplay.Text)

            If currentSegment = "0" Then Exit Sub
        Else
            ' If current segment is a single zero, replace it
            Dim lastOpIndex As Integer = txtDisplay.Text.LastIndexOfAny("+-*/".ToCharArray())
            Dim currentSegmentStart As Integer = If(lastOpIndex >= 0, lastOpIndex + 1, 0)
            If txtDisplay.Text.Substring(currentSegmentStart) = "0" Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentSegmentStart)
            End If
        End If

        txtDisplay.Text &= digit
        txtDisplay.Focus()
    End Sub

    ' ---------------------------
    ' DECIMAL BUTTON
    ' ---------------------------
    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles dot.Click
        If txtDisplay.Text = "Error" Then Exit Sub

        If resultShown Then
            txtDisplay.Text = ""
            resultShown = False
        End If

        AddDecimal()
        txtDisplay.Focus()
    End Sub

    Private Sub AddDecimal()
        If txtDisplay.Text.EndsWith(".") Then Exit Sub

        If Not CurrentNumberHasDecimal() Then
            If txtDisplay.Text.Length = 0 OrElse "+-*/".Contains(txtDisplay.Text.Last()) Then
                txtDisplay.Text &= "0."
            Else
                txtDisplay.Text &= "."
            End If
        End If
    End Sub

    Private Function CurrentNumberHasDecimal() As Boolean
        Dim lastOpIndex As Integer = txtDisplay.Text.LastIndexOfAny("+-*/".ToCharArray())
        Dim currentNumber As String = If(lastOpIndex >= 0, txtDisplay.Text.Substring(lastOpIndex + 1), txtDisplay.Text)
        Return currentNumber.Contains(".")
    End Function

    ' ---------------------------
    ' DELETE & CLEAR
    ' ---------------------------
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If txtDisplay.Text = "Error" OrElse resultShown Then
            txtDisplay.Text = ""
            resultShown = False
        ElseIf txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        txtDisplay.Text = ""
        resultShown = False
    End Sub

    ' ---------------------------
    ' OPERATORS
    ' ---------------------------
    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        If txtDisplay.Text = "Error" Then Exit Sub
        AddOrReplaceOperator("/")
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        If txtDisplay.Text = "Error" Then Exit Sub
        AddOrReplaceOperator("*")
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        If txtDisplay.Text = "Error" Then Exit Sub
        AddOrReplaceOperator("-")
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If txtDisplay.Text = "Error" Then Exit Sub
        AddOrReplaceOperator("+")
    End Sub

    Private Sub AddOrReplaceOperator(op As String)
        If resultShown Then resultShown = False

        If txtDisplay.Text.Length = 0 Then
            If op = "-" Then txtDisplay.Text &= op
            Return
        End If

        Dim lastChar As Char = txtDisplay.Text(txtDisplay.Text.Length - 1)

        If "+*/".Contains(lastChar) Then
            If op = "-" Then
                txtDisplay.Text &= op
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1) & op
            End If

        ElseIf lastChar = "-"c Then
            If op <> "-" Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1) & op
            End If

        ElseIf lastChar = "."c Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1) & op

        Else
            txtDisplay.Text &= op
        End If
    End Sub

    ' ---------------------------
    ' EQUAL BUTTON
    ' ---------------------------
    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        Try
            Dim result As Object = New DataTable().Compute(txtDisplay.Text, Nothing)
            Dim value As Double = Convert.ToDouble(result)

            If Double.IsInfinity(value) OrElse Double.IsNaN(value) Then
                txtDisplay.Text = "Error"
                resultShown = False
                Return
            End If

            If value = Math.Truncate(value) Then
                txtDisplay.Text = value.ToString("0")
            Else
                txtDisplay.Text = value.ToString("0.########")
            End If

            resultShown = True

        Catch ex As Exception
            txtDisplay.Text = "Error"
            resultShown = False
        End Try
    End Sub

    ' ---------------------------
    ' KEYBOARD HANDLING
    ' ---------------------------
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If txtDisplay.Text = "Error" Then
            If e.KeyChar <> ChrW(8) AndAlso e.KeyChar <> ChrW(27) Then
                e.Handled = True
                Exit Sub
            End If
        End If

        If resultShown AndAlso Char.IsDigit(e.KeyChar) Then
            txtDisplay.Text = ""
            resultShown = False
        End If

        Select Case e.KeyChar
            Case "0"c To "9"c
                Dim digit As String = e.KeyChar.ToString()

                If digit = "0" Then
                    If txtDisplay.Text = "" Then Exit Sub

                    Dim lastOpIndex As Integer = txtDisplay.Text.LastIndexOfAny("+-*/".ToCharArray())
                    Dim currentSegment As String = If(lastOpIndex >= 0, txtDisplay.Text.Substring(lastOpIndex + 1), txtDisplay.Text)

                    If currentSegment = "0" Then Exit Sub
                Else
                    Dim lastOpIndex As Integer = txtDisplay.Text.LastIndexOfAny("+-*/".ToCharArray())
                    Dim currentSegmentStart As Integer = If(lastOpIndex >= 0, lastOpIndex + 1, 0)
                    If txtDisplay.Text.Substring(currentSegmentStart) = "0" Then
                        txtDisplay.Text = txtDisplay.Text.Substring(0, currentSegmentStart)
                    End If
                End If

                txtDisplay.Text &= digit

            Case "."c
                If Not CurrentNumberHasDecimal() Then
                    txtDisplay.Text &= "."
                End If

            Case "+"c, "-"c, "*"c, "/"c
                AddOrReplaceOperator(e.KeyChar)

            Case ChrW(13)   ' Enter
                e.Handled = True
                Equal_Click(Nothing, Nothing)

            Case ChrW(8)    ' Backspace
                ButtonDelete_Click(Nothing, Nothing)

            Case ChrW(27)   ' Escape
                ButtonClear_Click(Nothing, Nothing)

            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtDisplay_Click(sender As Object, e As EventArgs) Handles txtDisplay.Click

    End Sub
End Class
