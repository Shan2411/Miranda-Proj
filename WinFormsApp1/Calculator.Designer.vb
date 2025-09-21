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
        txtDisplay.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDisplay.ForeColor = Color.White
        txtDisplay.Location = New Point(18, 118)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(311, 37)
        txtDisplay.TabIndex = 22
        txtDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Bottom
        Button5.BackColor = SystemColors.ButtonFace
        Button5.FlatAppearance.BorderColor = Color.White
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button5.ForeColor = SystemColors.ControlText
        Button5.Location = New Point(102, 393)
        Button5.Margin = New Padding(0)
        Button5.Name = "Button5"
        Button5.Size = New Size(77, 82)
        Button5.TabIndex = 4
        Button5.TabStop = False
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Bottom
        Button7.BackColor = SystemColors.ButtonFace
        Button7.FlatAppearance.BorderColor = Color.White
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button7.ForeColor = SystemColors.ControlText
        Button7.Location = New Point(25, 475)
        Button7.Margin = New Padding(0)
        Button7.Name = "Button7"
        Button7.Size = New Size(77, 82)
        Button7.TabIndex = 6
        Button7.TabStop = False
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom
        Button4.BackColor = SystemColors.ButtonFace
        Button4.FlatAppearance.BorderColor = Color.White
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(25, 393)
        Button4.Margin = New Padding(0)
        Button4.Name = "Button4"
        Button4.Size = New Size(77, 82)
        Button4.TabIndex = 3
        Button4.TabStop = False
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom
        Button1.BackColor = SystemColors.ButtonFace
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(25, 311)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 82)
        Button1.TabIndex = 0
        Button1.TabStop = False
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dot
        ' 
        dot.Anchor = AnchorStyles.Bottom
        dot.BackColor = SystemColors.ButtonFace
        dot.FlatAppearance.BorderColor = Color.White
        dot.FlatStyle = FlatStyle.Flat
        dot.Font = New Font("Microsoft Sans Serif", 12.0F)
        dot.ForeColor = SystemColors.ControlText
        dot.Location = New Point(25, 557)
        dot.Margin = New Padding(0)
        dot.Name = "dot"
        dot.Size = New Size(77, 67)
        dot.TabIndex = 10
        dot.TabStop = False
        dot.Text = "."
        dot.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom
        Button2.BackColor = SystemColors.ButtonFace
        Button2.FlatAppearance.BorderColor = Color.White
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(102, 311)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(77, 82)
        Button2.TabIndex = 1
        Button2.TabStop = False
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button0
        ' 
        Button0.Anchor = AnchorStyles.Bottom
        Button0.BackColor = SystemColors.ButtonFace
        Button0.FlatAppearance.BorderColor = Color.White
        Button0.FlatStyle = FlatStyle.Flat
        Button0.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button0.ForeColor = SystemColors.ControlText
        Button0.Location = New Point(100, 557)
        Button0.Margin = New Padding(0)
        Button0.Name = "Button0"
        Button0.Size = New Size(154, 67)
        Button0.TabIndex = 9
        Button0.TabStop = False
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = False
        ' 
        ' Equal
        ' 
        Equal.Anchor = AnchorStyles.Bottom
        Equal.BackColor = Color.Aqua
        Equal.FlatAppearance.BorderColor = Color.Aqua
        Equal.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        Equal.FlatAppearance.MouseOverBackColor = Color.LightCyan
        Equal.FlatStyle = FlatStyle.Flat
        Equal.Font = New Font("Microsoft Sans Serif", 12.0F)
        Equal.Location = New Point(254, 475)
        Equal.Margin = New Padding(0)
        Equal.Name = "Equal"
        Equal.Size = New Size(76, 149)
        Equal.TabIndex = 17
        Equal.TabStop = False
        Equal.Text = "="
        Equal.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom
        Button3.BackColor = SystemColors.ButtonFace
        Button3.FlatAppearance.BorderColor = Color.White
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button3.ForeColor = SystemColors.ControlText
        Button3.Location = New Point(178, 311)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(77, 82)
        Button3.TabIndex = 2
        Button3.TabStop = False
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Bottom
        Button6.BackColor = SystemColors.ButtonFace
        Button6.FlatAppearance.BorderColor = Color.White
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button6.ForeColor = SystemColors.ControlText
        Button6.Location = New Point(178, 393)
        Button6.Margin = New Padding(0)
        Button6.Name = "Button6"
        Button6.Size = New Size(77, 82)
        Button6.TabIndex = 5
        Button6.TabStop = False
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Anchor = AnchorStyles.Bottom
        ButtonAdd.BackColor = Color.Aqua
        ButtonAdd.FlatAppearance.BorderColor = Color.Aqua
        ButtonAdd.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonAdd.FlatAppearance.MouseOverBackColor = Color.LightCyan
        ButtonAdd.FlatStyle = FlatStyle.Flat
        ButtonAdd.Font = New Font("Microsoft Sans Serif", 12.0F)
        ButtonAdd.Location = New Point(253, 393)
        ButtonAdd.Margin = New Padding(0)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(77, 82)
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
        ButtonMinus.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonMinus.FlatAppearance.MouseOverBackColor = Color.LightCyan
        ButtonMinus.FlatStyle = FlatStyle.Flat
        ButtonMinus.Font = New Font("Microsoft Sans Serif", 12.0F)
        ButtonMinus.Location = New Point(253, 311)
        ButtonMinus.Margin = New Padding(0)
        ButtonMinus.Name = "ButtonMinus"
        ButtonMinus.Size = New Size(77, 82)
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
        ButtonMultiply.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonMultiply.FlatAppearance.MouseOverBackColor = Color.LightCyan
        ButtonMultiply.FlatStyle = FlatStyle.Flat
        ButtonMultiply.Font = New Font("Microsoft Sans Serif", 12.0F)
        ButtonMultiply.Location = New Point(178, 245)
        ButtonMultiply.Margin = New Padding(0)
        ButtonMultiply.Name = "ButtonMultiply"
        ButtonMultiply.Size = New Size(77, 67)
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
        ButtonDivide.FlatAppearance.MouseDownBackColor = Color.Aqua
        ButtonDivide.FlatAppearance.MouseOverBackColor = Color.LightCyan
        ButtonDivide.FlatStyle = FlatStyle.Flat
        ButtonDivide.Font = New Font("Microsoft Sans Serif", 12.0F)
        ButtonDivide.Location = New Point(253, 245)
        ButtonDivide.Margin = New Padding(0)
        ButtonDivide.Name = "ButtonDivide"
        ButtonDivide.Size = New Size(77, 76)
        ButtonDivide.TabIndex = 20
        ButtonDivide.TabStop = False
        ButtonDivide.Text = "/"
        ButtonDivide.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.Bottom
        Button9.BackColor = SystemColors.ButtonFace
        Button9.FlatAppearance.BorderColor = Color.White
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button9.ForeColor = SystemColors.ControlText
        Button9.Location = New Point(176, 475)
        Button9.Margin = New Padding(0)
        Button9.Name = "Button9"
        Button9.Size = New Size(78, 82)
        Button9.TabIndex = 8
        Button9.TabStop = False
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.Anchor = AnchorStyles.Bottom
        Button8.BackColor = SystemColors.ButtonFace
        Button8.FlatAppearance.BorderColor = Color.White
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Microsoft Sans Serif", 12.0F)
        Button8.ForeColor = SystemColors.ControlText
        Button8.Location = New Point(102, 475)
        Button8.Margin = New Padding(0)
        Button8.Name = "Button8"
        Button8.Size = New Size(77, 82)
        Button8.TabIndex = 7
        Button8.TabStop = False
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Anchor = AnchorStyles.Bottom
        ButtonDelete.BackColor = Color.Aqua
        ButtonDelete.FlatAppearance.BorderColor = Color.Aqua
        ButtonDelete.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise
        ButtonDelete.FlatAppearance.MouseOverBackColor = Color.LightCyan
        ButtonDelete.FlatStyle = FlatStyle.Flat
        ButtonDelete.Font = New Font("Microsoft Sans Serif", 12.0F)
        ButtonDelete.Location = New Point(102, 245)
        ButtonDelete.Margin = New Padding(0)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(77, 67)
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
        CLEAR.FlatAppearance.MouseOverBackColor = Color.LightCyan
        CLEAR.FlatStyle = FlatStyle.Flat
        CLEAR.Font = New Font("Microsoft Sans Serif", 12F)
        CLEAR.Location = New Point(25, 246)
        CLEAR.Margin = New Padding(0)
        CLEAR.Name = "CLEAR"
        CLEAR.Size = New Size(78, 67)
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
        ClientSize = New Size(358, 646)
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
