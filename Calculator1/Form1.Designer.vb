<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.butNumberSeven = New System.Windows.Forms.Button()
        Me.butNumberEight = New System.Windows.Forms.Button()
        Me.butNumberFour = New System.Windows.Forms.Button()
        Me.butNumberNine = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.butNumberTwo = New System.Windows.Forms.Button()
        Me.butNumberThree = New System.Windows.Forms.Button()
        Me.butNumberOne = New System.Windows.Forms.Button()
        Me.butNumberSix = New System.Windows.Forms.Button()
        Me.butNumberFive = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.butNumberZero = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.butResult = New System.Windows.Forms.Button()
        Me.butSubstract = New System.Windows.Forms.Button()
        Me.butMultiply = New System.Windows.Forms.Button()
        Me.butDivide = New System.Windows.Forms.Button()
        Me.butAdd = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.butSqr = New System.Windows.Forms.Button()
        Me.butClean = New System.Windows.Forms.Button()
        Me.butHighNumber = New System.Windows.Forms.Button()
        Me.txtCache = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'butNumberSeven
        '
        Me.butNumberSeven.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberSeven.Location = New System.Drawing.Point(3, 3)
        Me.butNumberSeven.Name = "butNumberSeven"
        Me.butNumberSeven.Size = New System.Drawing.Size(109, 94)
        Me.butNumberSeven.TabIndex = 0
        Me.butNumberSeven.Text = "7"
        Me.butNumberSeven.UseVisualStyleBackColor = True
        '
        'butNumberEight
        '
        Me.butNumberEight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberEight.DialogResult = System.Windows.Forms.DialogResult.No
        Me.butNumberEight.Location = New System.Drawing.Point(118, 3)
        Me.butNumberEight.Name = "butNumberEight"
        Me.butNumberEight.Size = New System.Drawing.Size(110, 94)
        Me.butNumberEight.TabIndex = 1
        Me.butNumberEight.Text = "8"
        Me.butNumberEight.UseVisualStyleBackColor = True
        '
        'butNumberFour
        '
        Me.butNumberFour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberFour.Location = New System.Drawing.Point(3, 103)
        Me.butNumberFour.Name = "butNumberFour"
        Me.butNumberFour.Size = New System.Drawing.Size(109, 94)
        Me.butNumberFour.TabIndex = 4
        Me.butNumberFour.Text = "4"
        Me.butNumberFour.UseVisualStyleBackColor = True
        '
        'butNumberNine
        '
        Me.butNumberNine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberNine.Location = New System.Drawing.Point(234, 3)
        Me.butNumberNine.Name = "butNumberNine"
        Me.butNumberNine.Size = New System.Drawing.Size(94, 94)
        Me.butNumberNine.TabIndex = 3
        Me.butNumberNine.Text = "9"
        Me.butNumberNine.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.91465!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.08535!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberTwo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberThree, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberOne, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberSix, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberFive, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberSeven, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberFour, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberNine, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.butNumberEight, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 307)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(331, 292)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'butNumberTwo
        '
        Me.butNumberTwo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberTwo.Location = New System.Drawing.Point(118, 203)
        Me.butNumberTwo.Name = "butNumberTwo"
        Me.butNumberTwo.Size = New System.Drawing.Size(110, 86)
        Me.butNumberTwo.TabIndex = 8
        Me.butNumberTwo.Text = "2"
        Me.butNumberTwo.UseVisualStyleBackColor = True
        '
        'butNumberThree
        '
        Me.butNumberThree.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberThree.Location = New System.Drawing.Point(234, 203)
        Me.butNumberThree.Name = "butNumberThree"
        Me.butNumberThree.Size = New System.Drawing.Size(94, 86)
        Me.butNumberThree.TabIndex = 8
        Me.butNumberThree.Text = "3"
        Me.butNumberThree.UseVisualStyleBackColor = True
        '
        'butNumberOne
        '
        Me.butNumberOne.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberOne.Location = New System.Drawing.Point(3, 203)
        Me.butNumberOne.Name = "butNumberOne"
        Me.butNumberOne.Size = New System.Drawing.Size(109, 86)
        Me.butNumberOne.TabIndex = 6
        Me.butNumberOne.Text = "1"
        Me.butNumberOne.UseVisualStyleBackColor = True
        '
        'butNumberSix
        '
        Me.butNumberSix.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberSix.Location = New System.Drawing.Point(234, 103)
        Me.butNumberSix.Name = "butNumberSix"
        Me.butNumberSix.Size = New System.Drawing.Size(94, 94)
        Me.butNumberSix.TabIndex = 5
        Me.butNumberSix.Text = "6"
        Me.butNumberSix.UseVisualStyleBackColor = True
        '
        'butNumberFive
        '
        Me.butNumberFive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberFive.Location = New System.Drawing.Point(118, 103)
        Me.butNumberFive.Name = "butNumberFive"
        Me.butNumberFive.Size = New System.Drawing.Size(110, 94)
        Me.butNumberFive.TabIndex = 4
        Me.butNumberFive.Text = "5"
        Me.butNumberFive.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(131, 635)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 0)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'butNumberZero
        '
        Me.butNumberZero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butNumberZero.Location = New System.Drawing.Point(3, 3)
        Me.butNumberZero.Name = "butNumberZero"
        Me.butNumberZero.Size = New System.Drawing.Size(104, 84)
        Me.butNumberZero.TabIndex = 7
        Me.butNumberZero.Text = "0"
        Me.butNumberZero.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.butResult, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.butSubstract, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.butMultiply, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.butDivide, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.butAdd, 0, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(349, 212)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(107, 479)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'butResult
        '
        Me.butResult.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butResult.Location = New System.Drawing.Point(3, 389)
        Me.butResult.Name = "butResult"
        Me.butResult.Size = New System.Drawing.Size(101, 85)
        Me.butResult.TabIndex = 4
        Me.butResult.Text = "="
        Me.butResult.UseVisualStyleBackColor = True
        '
        'butSubstract
        '
        Me.butSubstract.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butSubstract.Location = New System.Drawing.Point(3, 197)
        Me.butSubstract.Name = "butSubstract"
        Me.butSubstract.Size = New System.Drawing.Size(101, 94)
        Me.butSubstract.TabIndex = 2
        Me.butSubstract.Text = "-"
        Me.butSubstract.UseVisualStyleBackColor = True
        '
        'butMultiply
        '
        Me.butMultiply.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butMultiply.Location = New System.Drawing.Point(3, 99)
        Me.butMultiply.Name = "butMultiply"
        Me.butMultiply.Size = New System.Drawing.Size(101, 92)
        Me.butMultiply.TabIndex = 1
        Me.butMultiply.Text = "x"
        Me.butMultiply.UseVisualStyleBackColor = True
        '
        'butDivide
        '
        Me.butDivide.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butDivide.Location = New System.Drawing.Point(3, 3)
        Me.butDivide.Name = "butDivide"
        Me.butDivide.Size = New System.Drawing.Size(101, 90)
        Me.butDivide.TabIndex = 0
        Me.butDivide.Text = "/"
        Me.butDivide.UseVisualStyleBackColor = True
        '
        'butAdd
        '
        Me.butAdd.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butAdd.Location = New System.Drawing.Point(3, 298)
        Me.butAdd.Name = "butAdd"
        Me.butAdd.Size = New System.Drawing.Size(101, 85)
        Me.butAdd.TabIndex = 3
        Me.butAdd.Text = "+"
        Me.butAdd.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtResult.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtResult.Location = New System.Drawing.Point(3, 24)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtResult.Size = New System.Drawing.Size(440, 96)
        Me.txtResult.TabIndex = 9
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78355!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21645!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.butSqr, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.butClean, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.butHighNumber, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 212)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(331, 89)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'butSqr
        '
        Me.butSqr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butSqr.Location = New System.Drawing.Point(234, 3)
        Me.butSqr.Name = "butSqr"
        Me.butSqr.Size = New System.Drawing.Size(94, 83)
        Me.butSqr.TabIndex = 3
        Me.butSqr.Text = "sqr"
        Me.butSqr.UseVisualStyleBackColor = True
        '
        'butClean
        '
        Me.butClean.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butClean.ForeColor = System.Drawing.SystemColors.ControlText
        Me.butClean.Location = New System.Drawing.Point(3, 3)
        Me.butClean.Name = "butClean"
        Me.butClean.Size = New System.Drawing.Size(109, 83)
        Me.butClean.TabIndex = 1
        Me.butClean.Text = "C"
        Me.butClean.UseVisualStyleBackColor = True
        '
        'butHighNumber
        '
        Me.butHighNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butHighNumber.Location = New System.Drawing.Point(118, 3)
        Me.butHighNumber.Name = "butHighNumber"
        Me.butHighNumber.Size = New System.Drawing.Size(110, 83)
        Me.butHighNumber.TabIndex = 2
        Me.butHighNumber.Text = "x^2"
        Me.butHighNumber.UseVisualStyleBackColor = True
        '
        'txtCache
        '
        Me.txtCache.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.txtCache.Location = New System.Drawing.Point(3, 3)
        Me.txtCache.Name = "txtCache"
        Me.txtCache.Size = New System.Drawing.Size(440, 25)
        Me.txtCache.TabIndex = 11
        Me.txtCache.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.butNumberZero, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(130, 601)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(110, 90)
        Me.TableLayoutPanel4.TabIndex = 12
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.txtCache, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txtResult, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(10, 81)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(446, 125)
        Me.TableLayoutPanel5.TabIndex = 13
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 715)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Calculator"
        Me.Text = "CALCULATOR"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents butNumberSeven As Button
    Friend WithEvents butNumberEight As Button
    Friend WithEvents butNumberFour As Button
    Friend WithEvents butNumberNine As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents butNumberTwo As Button
    Friend WithEvents butNumberThree As Button
    Friend WithEvents butNumberOne As Button
    Friend WithEvents butNumberSix As Button
    Friend WithEvents butNumberFive As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents butNumberZero As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents butAdd As Button
    Friend WithEvents butSubstract As Button
    Friend WithEvents butMultiply As Button
    Friend WithEvents butDivide As Button
    Friend WithEvents butResult As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents butHighNumber As Button
    Friend WithEvents butClean As Button
    Friend WithEvents txtCache As TextBox
    Friend WithEvents butSqr As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
