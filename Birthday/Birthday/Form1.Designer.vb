<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HowToUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YearLabel = New System.Windows.Forms.Label
        Me.YearComboBox = New System.Windows.Forms.ComboBox
        Me.MonthLabel = New System.Windows.Forms.Label
        Me.MonthComboBox = New System.Windows.Forms.ComboBox
        Me.DayLabel = New System.Windows.Forms.Label
        Me.DayComboBox = New System.Windows.Forms.ComboBox
        Me.CalculateButton = New System.Windows.Forms.Button
        Me.ResetButton = New System.Windows.Forms.Button
        Me.CloseButton = New System.Windows.Forms.Button
        Me.OutputLabel1 = New System.Windows.Forms.Label
        Me.OutputLabel2 = New System.Windows.Forms.Label
        Me.OutputLabel3 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(482, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ResetToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowToUseToolStripMenuItem
        '
        Me.HowToUseToolStripMenuItem.Name = "HowToUseToolStripMenuItem"
        Me.HowToUseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HowToUseToolStripMenuItem.Text = "How to use"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLabel.Location = New System.Drawing.Point(12, 33)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(155, 20)
        Me.YearLabel.TabIndex = 0
        Me.YearLabel.Text = "Enter your birth year:"
        '
        'YearComboBox
        '
        Me.YearComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Location = New System.Drawing.Point(12, 61)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(121, 28)
        Me.YearComboBox.TabIndex = 1
        '
        'MonthLabel
        '
        Me.MonthLabel.AutoSize = True
        Me.MonthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthLabel.Location = New System.Drawing.Point(12, 97)
        Me.MonthLabel.Name = "MonthLabel"
        Me.MonthLabel.Size = New System.Drawing.Size(170, 20)
        Me.MonthLabel.TabIndex = 0
        Me.MonthLabel.Text = "Enter your birth month:"
        '
        'MonthComboBox
        '
        Me.MonthComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.MonthComboBox.Location = New System.Drawing.Point(12, 125)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(121, 28)
        Me.MonthComboBox.TabIndex = 2
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayLabel.Location = New System.Drawing.Point(12, 161)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(150, 20)
        Me.DayLabel.TabIndex = 0
        Me.DayLabel.Text = "Enter your birth day:"
        '
        'DayComboBox
        '
        Me.DayComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayComboBox.FormattingEnabled = True
        Me.DayComboBox.Location = New System.Drawing.Point(12, 189)
        Me.DayComboBox.Name = "DayComboBox"
        Me.DayComboBox.Size = New System.Drawing.Size(121, 28)
        Me.DayComboBox.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateButton.Location = New System.Drawing.Point(48, 225)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(88, 30)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(197, 225)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(88, 30)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(346, 225)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(88, 30)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'OutputLabel1
        '
        Me.OutputLabel1.AutoSize = True
        Me.OutputLabel1.Location = New System.Drawing.Point(194, 67)
        Me.OutputLabel1.Name = "OutputLabel1"
        Me.OutputLabel1.Size = New System.Drawing.Size(0, 15)
        Me.OutputLabel1.TabIndex = 7
        '
        'OutputLabel2
        '
        Me.OutputLabel2.AutoSize = True
        Me.OutputLabel2.Location = New System.Drawing.Point(194, 99)
        Me.OutputLabel2.Name = "OutputLabel2"
        Me.OutputLabel2.Size = New System.Drawing.Size(0, 15)
        Me.OutputLabel2.TabIndex = 8
        '
        'OutputLabel3
        '
        Me.OutputLabel3.AutoSize = True
        Me.OutputLabel3.Location = New System.Drawing.Point(194, 131)
        Me.OutputLabel3.Name = "OutputLabel3"
        Me.OutputLabel3.Size = New System.Drawing.Size(0, 15)
        Me.OutputLabel3.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 267)
        Me.Controls.Add(Me.OutputLabel3)
        Me.Controls.Add(Me.OutputLabel2)
        Me.Controls.Add(Me.OutputLabel1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DayComboBox)
        Me.Controls.Add(Me.DayLabel)
        Me.Controls.Add(Me.MonthComboBox)
        Me.Controls.Add(Me.MonthLabel)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(Me.YearLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "On what day were you born?"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YearLabel As System.Windows.Forms.Label
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MonthLabel As System.Windows.Forms.Label
    Friend WithEvents MonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DayLabel As System.Windows.Forms.Label
    Friend WithEvents DayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents OutputLabel1 As System.Windows.Forms.Label
    Friend WithEvents OutputLabel2 As System.Windows.Forms.Label
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutputLabel3 As System.Windows.Forms.Label

End Class
