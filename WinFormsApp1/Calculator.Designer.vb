<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtDisplay = New Label()
        Button5 = New Button()
        Button7 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        dot = New Button()
        Button2 = New Button()
        Button0 = New Button()
        Equal = New Button()
        Button3 = New Button()
        Button6 = New Button()
        ButtonAdd = New Button()
        ButtonMinus = New Button()
        ButtonMultiply = New Button()
        ButtonDivide = New Button()
        Button9 = New Button()
        Button8 = New Button()
        ButtonDelete = New Button()
        CLEAR = New Button()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtDisplay.FlatStyle = FlatStyle.Flat
        txtDisplay.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDisplay.ForeColor = Color.White
        txtDisplay.Location = New Point(34, 41)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(307, 92)
        txtDisplay.TabIndex = 22
        txtDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom
        Button5.FlatAppearance.BorderColor = Color.White
        Button5.Location = New Point(117, 420)
        Button5.Margin = New Padding(3, 4, 3, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(58, 68)
        Button5.TabIndex = 4
        Button5.TabStop = False
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Bottom
        Button7.FlatAppearance.BorderColor = Color.White
        Button7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(34, 521)
        Button7.Margin = New Padding(3, 4, 3, 4)
        Button7.Name = "Button7"
        Button7.Size = New Size(58, 68)
        Button7.TabIndex = 6
        Button7.TabStop = False
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.Location = New Point(34, 420)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(58, 68)
        Button4.TabIndex = 3
        Button4.TabStop = False
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.Location = New Point(34, 321)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(58, 64)
        Button1.TabIndex = 0
        Button1.TabStop = False
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dot
        ' 
        dot.Anchor = AnchorStyles.Bottom
        dot.FlatAppearance.BorderColor = Color.White
        dot.Location = New Point(34, 617)
        dot.Margin = New Padding(3, 4, 3, 4)
        dot.Name = "dot"
        dot.Size = New Size(58, 67)
        dot.TabIndex = 10
        dot.TabStop = False
        dot.Text = "."
        dot.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.Location = New Point(117, 321)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(58, 64)
        Button2.TabIndex = 1
        Button2.TabStop = False
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Anchor = AnchorStyles.Bottom
        Button0.FlatAppearance.BorderColor = Color.White
        Button0.Location = New Point(116, 617)
        Button0.Margin = New Padding(3, 4, 3, 4)
        Button0.Name = "Button0"
        Button0.Size = New Size(143, 67)
        Button0.TabIndex = 9
        Button0.TabStop = False
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' Equal
        ' 
        Equal.Anchor = AnchorStyles.Bottom
        Equal.BackColor = Color.Aqua
        Equal.FlatAppearance.BorderColor = Color.Aqua
        Equal.FlatAppearance.BorderSize = 0
        Equal.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        Equal.FlatAppearance.MouseOverBackColor = Color.Aqua
        Equal.FlatStyle = FlatStyle.Flat
        Equal.Location = New Point(283, 521)
        Equal.Margin = New Padding(3, 4, 3, 4)
        Equal.Name = "Equal"
        Equal.Size = New Size(58, 163)
        Equal.TabIndex = 17
        Equal.TabStop = False
        Equal.Text = "="
        Equal.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.Location = New Point(201, 321)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(58, 64)
        Button3.TabIndex = 2
        Button3.TabStop = False
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Bottom
        Button6.FlatAppearance.BorderColor = Color.White
        Button6.Location = New Point(201, 420)
        Button6.Margin = New Padding(3, 4, 3, 4)
        Button6.Name = "Button6"
        Button6.Size = New Size(58, 68)
        Button6.TabIndex = 5
        Button6.TabStop = False
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Anchor = AnchorStyles.Bottom
        ButtonAdd.BackColor = Color.Aqua
        ButtonAdd.FlatAppearance.BorderColor = Color.Aqua
        ButtonAdd.FlatAppearance.BorderSize = 0
        ButtonAdd.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonAdd.FlatAppearance.MouseOverBackColor = Color.Aqua
        ButtonAdd.FlatStyle = FlatStyle.Flat
        ButtonAdd.Location = New Point(283, 421)
        ButtonAdd.Margin = New Padding(3, 4, 3, 4)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(58, 64)
        ButtonAdd.TabIndex = 16
        ButtonAdd.TabStop = False
        ButtonAdd.Text = "+"
        ButtonAdd.UseMnemonic = False
        ButtonAdd.UseVisualStyleBackColor = False
        ' 
        ' ButtonMinus
        ' 
        ButtonMinus.Anchor = AnchorStyles.Bottom
        ButtonMinus.BackColor = Color.Aqua
        ButtonMinus.FlatAppearance.BorderColor = Color.Aqua
        ButtonMinus.FlatAppearance.BorderSize = 0
        ButtonMinus.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonMinus.FlatAppearance.MouseOverBackColor = Color.Aqua
        ButtonMinus.FlatStyle = FlatStyle.Flat
        ButtonMinus.Location = New Point(283, 321)
        ButtonMinus.Margin = New Padding(3, 4, 3, 4)
        ButtonMinus.Name = "ButtonMinus"
        ButtonMinus.Size = New Size(58, 64)
        ButtonMinus.TabIndex = 15
        ButtonMinus.TabStop = False
        ButtonMinus.Text = "-"
        ButtonMinus.UseVisualStyleBackColor = False
        ' 
        ' ButtonMultiply
        ' 
        ButtonMultiply.Anchor = AnchorStyles.Bottom
        ButtonMultiply.BackColor = Color.Aqua
        ButtonMultiply.FlatAppearance.BorderColor = Color.Aqua
        ButtonMultiply.FlatAppearance.BorderSize = 0
        ButtonMultiply.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonMultiply.FlatAppearance.MouseOverBackColor = Color.Aqua
        ButtonMultiply.FlatStyle = FlatStyle.Flat
        ButtonMultiply.Location = New Point(201, 223)
        ButtonMultiply.Margin = New Padding(3, 4, 3, 4)
        ButtonMultiply.Name = "ButtonMultiply"
        ButtonMultiply.Size = New Size(58, 64)
        ButtonMultiply.TabIndex = 19
        ButtonMultiply.TabStop = False
        ButtonMultiply.Text = "*"
        ButtonMultiply.UseVisualStyleBackColor = False
        ' 
        ' ButtonDivide
        ' 
        ButtonDivide.Anchor = AnchorStyles.Bottom
        ButtonDivide.BackColor = Color.Aqua
        ButtonDivide.FlatAppearance.BorderColor = Color.Aqua
        ButtonDivide.FlatAppearance.BorderSize = 0
        ButtonDivide.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonDivide.FlatAppearance.MouseOverBackColor = Color.Aqua
        ButtonDivide.FlatStyle = FlatStyle.Flat
        ButtonDivide.Location = New Point(283, 223)
        ButtonDivide.Margin = New Padding(3, 4, 3, 4)
        ButtonDivide.Name = "ButtonDivide"
        ButtonDivide.Size = New Size(58, 64)
        ButtonDivide.TabIndex = 20
        ButtonDivide.TabStop = False
        ButtonDivide.Text = "/"
        ButtonDivide.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.Bottom
        Button9.FlatAppearance.BorderColor = Color.White
        Button9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button9.Location = New Point(201, 521)
        Button9.Margin = New Padding(3, 4, 3, 4)
        Button9.Name = "Button9"
        Button9.Size = New Size(58, 68)
        Button9.TabIndex = 8
        Button9.TabStop = False
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Bottom
        Button8.FlatAppearance.BorderColor = Color.White
        Button8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(117, 521)
        Button8.Margin = New Padding(3, 4, 3, 4)
        Button8.Name = "Button8"
        Button8.Size = New Size(58, 68)
        Button8.TabIndex = 7
        Button8.TabStop = False
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Anchor = AnchorStyles.Bottom
        ButtonDelete.BackColor = Color.Aqua
        ButtonDelete.FlatAppearance.BorderColor = Color.Aqua
        ButtonDelete.FlatAppearance.BorderSize = 0
        ButtonDelete.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonDelete.FlatAppearance.MouseOverBackColor = Color.Aqua
        ButtonDelete.FlatStyle = FlatStyle.Flat
        ButtonDelete.Location = New Point(117, 223)
        ButtonDelete.Margin = New Padding(3, 4, 3, 4)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(58, 64)
        ButtonDelete.TabIndex = 21
        ButtonDelete.TabStop = False
        ButtonDelete.Text = "DEL"
        ButtonDelete.UseVisualStyleBackColor = False
        ' 
        ' CLEAR
        ' 
        CLEAR.Anchor = AnchorStyles.Bottom
        CLEAR.BackColor = Color.IndianRed
        CLEAR.FlatAppearance.BorderColor = Color.IndianRed
        CLEAR.FlatAppearance.MouseDownBackColor = Color.Tomato
        CLEAR.FlatAppearance.MouseOverBackColor = Color.IndianRed
        CLEAR.FlatStyle = FlatStyle.Flat
        CLEAR.Location = New Point(34, 223)
        CLEAR.Margin = New Padding(3, 4, 3, 4)
        CLEAR.Name = "CLEAR"
        CLEAR.Size = New Size(58, 64)
        CLEAR.TabIndex = 12
        CLEAR.TabStop = False
        CLEAR.Text = "C"
        CLEAR.UseVisualStyleBackColor = False
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(379, 752)
        Controls.Add(txtDisplay)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonDivide)
        Controls.Add(ButtonMultiply)
        Controls.Add(Equal)
        Controls.Add(ButtonAdd)
        Controls.Add(ButtonMinus)
        Controls.Add(CLEAR)
        Controls.Add(dot)
        Controls.Add(Button0)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Calculator"
        Text = "Calculator"
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtDisplay As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dot As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Equal As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonMinus As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend Protected WithEvents ButtonDelete As Button
    Friend WithEvents CLEAR As Button

End Class
