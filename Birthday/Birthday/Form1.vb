'Birthday Calculation Application
'
'Coded by Chris Kelley
'October, 2012
'
'This program will tell someone the day of the week of any date between
'1900 and 2099, with care taken to account for leap years. To avoid the
'possibility of error on the part of the user, combo boxes are used to
'obtain the dates, and the date chosen is displayed to the user for
'the purpose of verification.

Public Class Form1

    'Here I call my variables and my array

    Dim YearArray(199) As Integer
    Dim YearCounter As Integer = 0
    Dim FullYear, ModYear, LeapYear, MonthCounter, DayCounter As Integer
    Dim StepOne, StepTwo, StepThree, StepFour, StepFive, StepSix, StepSeven, StepEight, StepNine As Double
    Dim Day As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'This for loop is strictly for populating my array with the years from 1900 to 2099
        'I did it on form load so I could have it ready without having to hard code the values

        For a = 1900 To 2099

            YearArray(YearCounter) = a
            YearComboBox.Items.Add(a)

            YearCounter += 1

        Next

        MonthComboBox.Enabled = False
        DayComboBox.Enabled = False

    End Sub

    Private Sub MonthComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthComboBox.SelectedIndexChanged

        'This sub is activated when the month is chosen. I did this because I needed to 
        'check for leap years before I knew how many days to put in the day combo box, 
        'and I only need to make changes for January and February to account for leap years.

        'Each time a new month is chosen, the day gets reset until the month is analyzed.

        If MonthComboBox.SelectedIndex > -1 Then

            DayComboBox.Enabled = True

            DayComboBox.SelectedIndex = -1
            DayComboBox.Items.Clear()

            'This section checks for leap year. If the year is a leap year, I set my leap year
            'counter to 1, otherwise I set it to 0. I use this value later to configure a leap 
            'year date.

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

            'Now, I check to see if it is indeed a leap year. If it is, and if the month is February,
            'I set the number of days in that month to 29. If not, then the number of days is 28.

            If LeapYear = 1 And MonthComboBox.SelectedIndex = 1 Then

                DayCounter = 29

            ElseIf LeapYear = 0 And MonthComboBox.SelectedIndex = 1 Then

                DayCounter = 28

                'If the month chosen is not February, I need to set the number of days
                'according to the month. Using a Select Case allowed me to shorten the
                'code by including the various months in a single line for each 30 and
                '31 day months.

            Else

                Select Case MonthComboBox.SelectedIndex

                    Case 0, 2, 4, 6, 7, 9, 11

                        DayCounter = 31

                    Case 3, 5, 8, 10

                        DayCounter = 30

                End Select

            End If

            'Now I execute a loop to populate the Day combo box with the right number of days

            For a = 1 To DayCounter

                DayComboBox.Items.Add(a.ToString)

            Next

        End If

    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click, CalculateToolStripMenuItem.Click

        'When the calculate button is clicked, I first check for valid values in each of my
        'combo boxes. If any of them are blank, I display an error message and stop the 
        'calculation process. I then check to see which of them is blank and change the 
        'color and weight of the font for the header for any of them that are blank.

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

            'After determining that none of the combo boxes are blank, I begin the calculation
            'of day of the week based on a successful entry of a date. This algorithm comes from 
            'Brainetics, created by Mike Byster - www.brainetics.com. I bought the brainetics
            'program for my daughter, and this particular exercise caught my attention for
            'more than the fact that it was teaching my daughter to enjoy math. I was certain
            'I could code it into a program for the computer.

            'In deference for the fact that this is not my own algorithm, I will not comment
            'the code for the actual calculation. Suffice it to say that it works.

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

            'Once the calculation is complete, I take the values and display them for the user,
            'including the original date chosen.

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

        'This is my error message, displayed if a field is left blank when the calculate
        'button is clicked.

        MessageBox.Show("You must supply me with year, month, and day, or I can't tell you the day of the week on which you were born." & Environment.NewLine & Environment.NewLine & "Please try again.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click, ResetToolStripMenuItem.Click

        'This is my Reset Sub. Here I ensure the headers for each combo box are in black
        'text and not bold, I set my combo boxes to blanks, and I clear my text output
        'fields. I further clear the items out of the day combo box so I can determine
        'from 0 how many days to put in that box.

        YearLabel.Font = New System.Drawing.Font(YearLabel.Font, FontStyle.Regular)
        YearLabel.ForeColor = Color.Black

        MonthLabel.Font = New System.Drawing.Font(MonthLabel.Font, FontStyle.Regular)
        MonthLabel.ForeColor = Color.Black

        DayLabel.Font = New System.Drawing.Font(DayLabel.Font, FontStyle.Regular)
        DayLabel.ForeColor = Color.Black

        YearComboBox.SelectedIndex = -1

        MonthComboBox.SelectedIndex = -1
        MonthComboBox.Enabled = False

        DayComboBox.SelectedIndex = -1
        DayComboBox.Items.Clear()
        DayComboBox.Enabled = False

        OutputLabel1.ResetText()
        OutputLabel2.ResetText()
        OutputLabel3.ResetText()

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click, CloseToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToUseToolStripMenuItem.Click
        'This is my 'How to use' message

        MessageBox.Show("This application will tell you the day of the week on a particular date fell, falls, or will fall, from 1900 through 2099. Leap years are accounted for, so just enter data as needed." & Environment.NewLine & Environment.NewLine & "Simply choose your birth year, month, and day from the drop down menus, and then press the Calculate button." & Environment.NewLine & Environment.NewLine & "The application will then display the birthday you entered and the day of the week for that date." & Environment.NewLine & Environment.NewLine & "To try again, you can either immediately choose new options from the drop down menus, or you can press the Reset button to clear the fields and then choose new information." & Environment.NewLine & Environment.NewLine & "To exit the application, click the Close button.", "How to use", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'This is my 'About" message

        MessageBox.Show("All code written by me, Chris Kelley, October 2012" & Environment.NewLine & Environment.NewLine & "Algorithm taken from Brainetics®, which I purchased for my daughter some months ago.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub YearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearComboBox.SelectedIndexChanged

        If YearComboBox.SelectedIndex > -1 Then

            MonthComboBox.Enabled = True

        End If

    End Sub
End Class
