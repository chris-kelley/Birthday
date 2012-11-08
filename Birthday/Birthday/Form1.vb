Public Class Form1

    Dim YearArray(199) As Integer
    Dim YearCounter As Integer = 0
    Dim FullYear, ModYear, LeapYear, MonthCounter, DayCounter As Integer
    Dim StepOne, StepTwo, StepThree, StepFour, StepFive, StepSix, StepSeven, StepEight, StepNine As Double
    Dim Day As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        For a = 1900 To 2099

            YearArray(YearCounter) = a
            YearComboBox.Items.Add(a)

            YearCounter += 1

        Next

    End Sub

    Private Sub MonthComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthComboBox.SelectedIndexChanged

        DayComboBox.SelectedIndex = -1
        DayComboBox.Items.Clear()

        FullYear = CInt(YearComboBox.SelectedItem)
        ModYear = FullYear Mod 100

        If FullYear Mod 4 = 0 Then

            If FullYear Mod 100 = 0 Then

                If FullYear Mod 400 = 0 Then

                    LeapYear = 1

                End If

            Else

                LeapYear = 0

            End If

            LeapYear = 1

        Else

            LeapYear = 0

        End If

        If LeapYear = 1 And MonthComboBox.SelectedIndex = 1 Then

            DayCounter = 29

        ElseIf LeapYear = 0 And MonthComboBox.SelectedIndex = 1 Then

            DayCounter = 28

        Else

            Select Case MonthComboBox.SelectedIndex

                Case 0, 2, 4, 6, 7, 9, 11

                    DayCounter = 31

                Case 3, 5, 8, 10

                    DayCounter = 30

            End Select

        End If

        For a = 1 To DayCounter

            DayComboBox.Items.Add(a.ToString)

        Next

    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click

        If YearComboBox.SelectedIndex = -1 Or MonthComboBox.SelectedIndex = -1 Or DayComboBox.SelectedIndex = -1 Then

            ErrorMessage()

            If YearComboBox.SelectedIndex = -1 Then

                YearLabel.ForeColor = Color.Red
                YearLabel.Font = New System.Drawing.Font(YearLabel.Font, FontStyle.Bold)

            Else

                YearLabel.Font = New System.Drawing.Font(YearLabel.Font, FontStyle.Regular)
                YearLabel.ForeColor = Color.Black

            End If


            If MonthComboBox.SelectedIndex = -1 Then

                MonthLabel.ForeColor = Color.Red
                MonthLabel.Font = New System.Drawing.Font(MonthLabel.Font, FontStyle.Bold)

            Else

                MonthLabel.Font = New System.Drawing.Font(MonthLabel.Font, FontStyle.Regular)
                MonthLabel.ForeColor = Color.Black

            End If


            If DayComboBox.SelectedIndex = -1 Then

                DayLabel.ForeColor = Color.Red
                DayLabel.Font = New System.Drawing.Font(DayLabel.Font, FontStyle.Bold)

            Else

                DayLabel.Font = New System.Drawing.Font(DayLabel.Font, FontStyle.Regular)
                DayLabel.ForeColor = Color.Black

            End If

        Else

            Dim MonthCode As Integer

            Select Case MonthComboBox.SelectedIndex

                Case 0, 9
                    MonthCode = 1
                Case 1, 2, 10
                    MonthCode = 4
                Case 3, 6
                    MonthCode = 0
                Case 4
                    MonthCode = 2
                Case 5
                    MonthCode = 5
                Case 7
                    MonthCode = 3
                Case 8, 11
                    MonthCode = 6

            End Select

            StepOne = ModYear * 5
            StepTwo = StepOne / 4
            StepThree = StepTwo - (StepTwo Mod 1)
            StepFour = StepThree + MonthCode
            StepFive = StepFour + CInt(DayComboBox.SelectedItem)
            StepSix = StepFive / 7
            StepSeven = StepSix * 10
            StepEight = StepSeven - (StepSeven Mod 1)
            StepNine = StepEight Mod 10

            If LeapYear = 1 Then

                If MonthComboBox.SelectedIndex = 1 Or MonthComboBox.SelectedIndex = 1 Then

                    StepNine = StepNine - 1

                    If StepNine < 0 Then

                        StepNine = 1

                    End If

                End If

            End If

            Select Case StepNine

                Case 1
                    Day = "Sunday"
                Case 2
                    Day = "Monday"
                Case 4
                    Day = "Tuesday"
                Case 5
                    Day = "Wednesday"
                Case 7
                    Day = "Thursday"
                Case 8
                    Day = "Friday"
                Case 0
                    Day = "Saturday"

            End Select

            OutputLabel1.Text = "You were born on " & (MonthComboBox.SelectedIndex + 1).ToString & "-" & DayComboBox.SelectedItem.ToString & "-" & YearComboBox.SelectedItem.ToString & "."

            If LeapYear = 1 Then

                OutputLabel2.Text = FullYear & " was a leap year."

            ElseIf LeapYear = 0 Then

                OutputLabel2.Text = FullYear & " was not a leap year"

            End If
            OutputLabel3.Text = "You were born on a " & Day & "."

        End If

    End Sub

    Private Sub ErrorMessage()

        MessageBox.Show("You must supply me with year, month, and day, or I can't tell you the day of the week on which you were born." & Environment.NewLine & Environment.NewLine & "Please try again.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click, ResetToolStripMenuItem.Click

        Reset()

    End Sub

    Private Sub Reset()

        YearLabel.Font = New System.Drawing.Font(YearLabel.Font, FontStyle.Regular)
        YearLabel.ForeColor = Color.Black

        MonthLabel.Font = New System.Drawing.Font(MonthLabel.Font, FontStyle.Regular)
        MonthLabel.ForeColor = Color.Black

        DayLabel.Font = New System.Drawing.Font(DayLabel.Font, FontStyle.Regular)
        DayLabel.ForeColor = Color.Black

        YearComboBox.SelectedIndex = -1

        MonthComboBox.SelectedIndex = -1

        DayComboBox.SelectedIndex = -1
        DayComboBox.Items.Clear()

        OutputLabel1.ResetText()
        OutputLabel2.ResetText()
        OutputLabel3.ResetText()

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click

        MessageBox.Show("This application will tell you the day of the week on a particular date fell, falls, or will fall, from 1900 through 2099. Leap years are accounted for, so just enter data as needed." & Environment.NewLine & Environment.NewLine & "Simply choose your birth year, month, and day from the drop down menus, and then press the Calculate button." & Environment.NewLine & Environment.NewLine & "The application will then display the birthday you entered and the day of the week for that date." & Environment.NewLine & Environment.NewLine & "To try again, you can either immediately choose new options from the drop down menus, or you can press the Reset button to clear the fields and then choose new information." & Environment.NewLine & Environment.NewLine & "To exit the application, click the Close button.", "How to use", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        MessageBox.Show("All code written by me, Chris Kelley, October 2012" & Environment.NewLine & Environment.NewLine & "Algorithm taken from Brainetics®, which I purchased for my daughter some months ago.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
