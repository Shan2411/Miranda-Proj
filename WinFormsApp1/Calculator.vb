Public Class Calculator

    ' Track if keyboard input is active
    Private keyboardActive As Boolean = False

    ' ---------------------------
    ' Full Screen & Not Adjustable
    ' ---------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Allow maximize but disable manual resizing
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = True
        Me.MinimizeBox = True

    End Sub





    ' ---------------------------
    ' DIGIT BUTTONS
    ' ---------------------------
    Private Sub Digit_Click(sender As Object, e As EventArgs) Handles Button0.Click, Button1.Click, Button2.Click,
        Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        If txtDisplay.Text = "Error" Then Exit Sub
        Dim btn As Button = CType(sender, Button)
        txtDisplay.Text &= btn.Text

        txtDisplay.Focus()
    End Sub

    ' ---------------------------
    ' DECIMAL BUTTON
    ' ---------------------------
    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles dot.Click
        If txtDisplay.Text = "Error" Then Exit Sub
        AddDecimal()
        txtDisplay.Focus()
    End Sub

    Private Sub AddDecimal()
        ' Prevent multiple consecutive decimals
        If txtDisplay.Text.EndsWith(".") Then Exit Sub

        ' Allow decimal only if current number doesn’t already have one
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
        If txtDisplay.Text = "Error" Then
            txtDisplay.Text = ""
        ElseIf txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles CLEAR.Click
        txtDisplay.Text = ""
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
            ' Prevent operator right after decimal → replace decimal with operator
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
                Return
            End If

            If value = Math.Truncate(value) Then
                txtDisplay.Text = value.ToString("0") ' whole number
            Else
                txtDisplay.Text = value.ToString("0.########") ' decimal
            End If

        Catch ex As Exception
            txtDisplay.Text = "Error"
        End Try
    End Sub

    ' ---------------------------
    ' KEYBOARD HANDLING
    ' ---------------------------
    ' Make sure you set Form1 property: KeyPreview = True

    ' When user clicks the display, activate keyboard input
    Private Sub txtDisplay_Click(sender As Object, e As EventArgs) Handles txtDisplay.Click
        keyboardActive = True
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not keyboardActive Then
            e.Handled = True
            Exit Sub
        End If

        If txtDisplay.Text = "Error" Then
            ' Only allow Backspace or Escape when Error is showing
            If e.KeyChar <> ChrW(8) AndAlso e.KeyChar <> ChrW(27) Then
                e.Handled = True
                Exit Sub
            End If
        End If

        Select Case e.KeyChar
            Case "0"c To "9"c
                txtDisplay.Text &= e.KeyChar

            Case "."c
                If Not CurrentNumberHasDecimal() Then
                    txtDisplay.Text &= "."
                End If

            Case "+"c, "-"c, "*"c, "/"c
                AddOrReplaceOperator(e.KeyChar)

            Case ChrW(13)   ' Enter key
                e.Handled = True
                Equal_Click(Nothing, Nothing)

            Case ChrW(8)    ' Backspace
                ButtonDelete_Click(Nothing, Nothing)

            Case ChrW(27)   ' Escape
                ButtonClear_Click(Nothing, Nothing)

            Case Else
                ' Ignore everything else
                e.Handled = True
        End Select
    End Sub




End Class
