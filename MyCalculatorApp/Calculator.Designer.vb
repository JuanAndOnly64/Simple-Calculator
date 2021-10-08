<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDecimal = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnEqual = New System.Windows.Forms.Button()
        Me.BtnDivide = New System.Windows.Forms.Button()
        Me.BtnNum0 = New System.Windows.Forms.Button()
        Me.BtnNegative = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnNum9 = New System.Windows.Forms.Button()
        Me.BtnNum8 = New System.Windows.Forms.Button()
        Me.BtnNum7 = New System.Windows.Forms.Button()
        Me.BtnMinus = New System.Windows.Forms.Button()
        Me.BtnNum6 = New System.Windows.Forms.Button()
        Me.BtnNum5 = New System.Windows.Forms.Button()
        Me.BtnNum4 = New System.Windows.Forms.Button()
        Me.BtnMultiply = New System.Windows.Forms.Button()
        Me.BtnNum3 = New System.Windows.Forms.Button()
        Me.BtnNum2 = New System.Windows.Forms.Button()
        Me.BtnNum1 = New System.Windows.Forms.Button()
        Me.NumDisplay = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.BtnDecimal)
        Me.GroupBox1.Controls.Add(Me.BtnClear)
        Me.GroupBox1.Controls.Add(Me.BtnEqual)
        Me.GroupBox1.Controls.Add(Me.BtnDivide)
        Me.GroupBox1.Controls.Add(Me.BtnNum0)
        Me.GroupBox1.Controls.Add(Me.BtnNegative)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.BtnNum9)
        Me.GroupBox1.Controls.Add(Me.BtnNum8)
        Me.GroupBox1.Controls.Add(Me.BtnNum7)
        Me.GroupBox1.Controls.Add(Me.BtnMinus)
        Me.GroupBox1.Controls.Add(Me.BtnNum6)
        Me.GroupBox1.Controls.Add(Me.BtnNum5)
        Me.GroupBox1.Controls.Add(Me.BtnNum4)
        Me.GroupBox1.Controls.Add(Me.BtnMultiply)
        Me.GroupBox1.Controls.Add(Me.BtnNum3)
        Me.GroupBox1.Controls.Add(Me.BtnNum2)
        Me.GroupBox1.Controls.Add(Me.BtnNum1)
        Me.GroupBox1.Controls.Add(Me.NumDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 479)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculator1"
        '
        'BtnDecimal
        '
        Me.BtnDecimal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnDecimal.Location = New System.Drawing.Point(29, 392)
        Me.BtnDecimal.Name = "BtnDecimal"
        Me.BtnDecimal.Size = New System.Drawing.Size(77, 46)
        Me.BtnDecimal.TabIndex = 20
        Me.BtnDecimal.Tag = "Decimal"
        Me.BtnDecimal.Text = "."
        Me.BtnDecimal.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnClear.Location = New System.Drawing.Point(429, 174)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(77, 46)
        Me.BtnClear.TabIndex = 19
        Me.BtnClear.Text = "C"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnEqual
        '
        Me.BtnEqual.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnEqual.Location = New System.Drawing.Point(214, 392)
        Me.BtnEqual.Name = "BtnEqual"
        Me.BtnEqual.Size = New System.Drawing.Size(77, 46)
        Me.BtnEqual.TabIndex = 18
        Me.BtnEqual.Text = "="
        Me.BtnEqual.UseVisualStyleBackColor = False
        '
        'BtnDivide
        '
        Me.BtnDivide.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnDivide.Location = New System.Drawing.Point(333, 174)
        Me.BtnDivide.Name = "BtnDivide"
        Me.BtnDivide.Size = New System.Drawing.Size(77, 46)
        Me.BtnDivide.TabIndex = 17
        Me.BtnDivide.Tag = "Divide"
        Me.BtnDivide.Text = "÷"
        Me.BtnDivide.UseVisualStyleBackColor = False
        '
        'BtnNum0
        '
        Me.BtnNum0.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum0.Location = New System.Drawing.Point(121, 392)
        Me.BtnNum0.Name = "BtnNum0"
        Me.BtnNum0.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum0.TabIndex = 15
        Me.BtnNum0.Tag = "0"
        Me.BtnNum0.Text = "0"
        Me.BtnNum0.UseVisualStyleBackColor = False
        '
        'BtnNegative
        '
        Me.BtnNegative.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNegative.Location = New System.Drawing.Point(429, 250)
        Me.BtnNegative.Name = "BtnNegative"
        Me.BtnNegative.Size = New System.Drawing.Size(77, 46)
        Me.BtnNegative.TabIndex = 14
        Me.BtnNegative.Tag = "Negative"
        Me.BtnNegative.Text = "±"
        Me.BtnNegative.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnAdd.Location = New System.Drawing.Point(333, 325)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(77, 46)
        Me.BtnAdd.TabIndex = 13
        Me.BtnAdd.Tag = "Add"
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnNum9
        '
        Me.BtnNum9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum9.Location = New System.Drawing.Point(214, 325)
        Me.BtnNum9.Name = "BtnNum9"
        Me.BtnNum9.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum9.TabIndex = 12
        Me.BtnNum9.Tag = "9"
        Me.BtnNum9.Text = "9"
        Me.BtnNum9.UseVisualStyleBackColor = False
        '
        'BtnNum8
        '
        Me.BtnNum8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum8.Location = New System.Drawing.Point(121, 325)
        Me.BtnNum8.Name = "BtnNum8"
        Me.BtnNum8.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum8.TabIndex = 11
        Me.BtnNum8.Tag = "8"
        Me.BtnNum8.Text = "8"
        Me.BtnNum8.UseVisualStyleBackColor = False
        '
        'BtnNum7
        '
        Me.BtnNum7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum7.Location = New System.Drawing.Point(29, 325)
        Me.BtnNum7.Name = "BtnNum7"
        Me.BtnNum7.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum7.TabIndex = 10
        Me.BtnNum7.Tag = "7"
        Me.BtnNum7.Text = "7"
        Me.BtnNum7.UseVisualStyleBackColor = False
        '
        'BtnMinus
        '
        Me.BtnMinus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnMinus.Location = New System.Drawing.Point(333, 392)
        Me.BtnMinus.Name = "BtnMinus"
        Me.BtnMinus.Size = New System.Drawing.Size(77, 46)
        Me.BtnMinus.TabIndex = 9
        Me.BtnMinus.Tag = "Subtract"
        Me.BtnMinus.Text = "-"
        Me.BtnMinus.UseVisualStyleBackColor = False
        '
        'BtnNum6
        '
        Me.BtnNum6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum6.Location = New System.Drawing.Point(214, 250)
        Me.BtnNum6.Name = "BtnNum6"
        Me.BtnNum6.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum6.TabIndex = 8
        Me.BtnNum6.Tag = "6"
        Me.BtnNum6.Text = "6"
        Me.BtnNum6.UseVisualStyleBackColor = False
        '
        'BtnNum5
        '
        Me.BtnNum5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum5.Location = New System.Drawing.Point(121, 250)
        Me.BtnNum5.Name = "BtnNum5"
        Me.BtnNum5.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum5.TabIndex = 7
        Me.BtnNum5.Tag = "5"
        Me.BtnNum5.Text = "5"
        Me.BtnNum5.UseVisualStyleBackColor = False
        '
        'BtnNum4
        '
        Me.BtnNum4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum4.Location = New System.Drawing.Point(29, 250)
        Me.BtnNum4.Name = "BtnNum4"
        Me.BtnNum4.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum4.TabIndex = 6
        Me.BtnNum4.Tag = "4"
        Me.BtnNum4.Text = "4"
        Me.BtnNum4.UseVisualStyleBackColor = False
        '
        'BtnMultiply
        '
        Me.BtnMultiply.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnMultiply.Location = New System.Drawing.Point(333, 250)
        Me.BtnMultiply.Name = "BtnMultiply"
        Me.BtnMultiply.Size = New System.Drawing.Size(77, 46)
        Me.BtnMultiply.TabIndex = 5
        Me.BtnMultiply.Tag = "Multiply"
        Me.BtnMultiply.Text = "x"
        Me.BtnMultiply.UseVisualStyleBackColor = False
        '
        'BtnNum3
        '
        Me.BtnNum3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum3.Location = New System.Drawing.Point(214, 174)
        Me.BtnNum3.Name = "BtnNum3"
        Me.BtnNum3.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum3.TabIndex = 4
        Me.BtnNum3.Tag = "3"
        Me.BtnNum3.Text = "3"
        Me.BtnNum3.UseVisualStyleBackColor = False
        '
        'BtnNum2
        '
        Me.BtnNum2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum2.Location = New System.Drawing.Point(121, 174)
        Me.BtnNum2.Name = "BtnNum2"
        Me.BtnNum2.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum2.TabIndex = 3
        Me.BtnNum2.Tag = "2"
        Me.BtnNum2.Text = "2"
        Me.BtnNum2.UseVisualStyleBackColor = False
        '
        'BtnNum1
        '
        Me.BtnNum1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnNum1.Location = New System.Drawing.Point(29, 174)
        Me.BtnNum1.Name = "BtnNum1"
        Me.BtnNum1.Size = New System.Drawing.Size(77, 46)
        Me.BtnNum1.TabIndex = 2
        Me.BtnNum1.Tag = "1"
        Me.BtnNum1.Text = "1"
        Me.BtnNum1.UseVisualStyleBackColor = False
        '
        'NumDisplay
        '
        Me.NumDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NumDisplay.Location = New System.Drawing.Point(26, 60)
        Me.NumDisplay.Name = "NumDisplay"
        Me.NumDisplay.Size = New System.Drawing.Size(344, 71)
        Me.NumDisplay.TabIndex = 1
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Calculator"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEqual As Button
    Friend WithEvents BtnDivide As Button
    Friend WithEvents BtnNum0 As Button
    Friend WithEvents BtnNegative As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnNum9 As Button
    Friend WithEvents BtnNum8 As Button
    Friend WithEvents BtnNum7 As Button
    Friend WithEvents BtnMinus As Button
    Friend WithEvents BtnNum6 As Button
    Friend WithEvents BtnNum5 As Button
    Friend WithEvents BtnNum4 As Button
    Friend WithEvents BtnMultiply As Button
    Friend WithEvents BtnNum3 As Button
    Friend WithEvents BtnNum2 As Button
    Friend WithEvents BtnNum1 As Button
    Friend WithEvents NumDisplay As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnDecimal As Button
End Class
