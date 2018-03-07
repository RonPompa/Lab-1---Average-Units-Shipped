Public Class Form1
    'Variables
    'This is the minimum value integer for the range
    Const minValue As Integer = 0
    'This is the maximum value integer for the range
    Const maxValue As Integer = 1000
    'Number of days in a week
    Const daysInAWeek As Integer = 7
    'Units each day
    Dim unitsEachDay(6) As Integer
    Dim counter As Integer = 0
    'Calculates average
    Dim average As Double
    Dim total As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset all inputs
        txtInput.Text = ""
        txtOutput.Text = ""
        lblDay.Text = "Days: 1"
        lblResults.Text = ""
        btnEnter.Enabled = True
        counter = 0
        average = 0
        total = 0
        txtInput.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtUnits_Click(sender As Object, e As EventArgs) Handles lblUnits.Click

    End Sub

    Private Sub txtDay_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click







        'Error Messages
        If (Integer.TryParse(txtInput.Text, unitsEachDay(counter)) = False) Then
            MessageBox.Show("The value must be a whole number", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtInput.Text = ""
            txtInput.Focus()

        Else
            If ((unitsEachDay(counter) <= maxValue And unitsEachDay(counter) >= minValue) = False) Then
                MessageBox.Show("The value must be within range of 0 and 1000", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtInput.Text = ""
                txtInput.Focus()

            Else
                unitsEachDay(counter) = Convert.ToInt32(txtInput.Text)
                txtOutput.Text += unitsEachDay(counter) & vbCrLf
                lblDay.Text = "Days: " & counter + 1
                counter += 1
                txtInput.Text = ""
                'Calculation

                If (counter = daysInAWeek) Then
                    btnEnter.Enabled = False

                    For counter = 1 To daysInAWeek - 1
                        total += unitsEachDay(counter)
                    Next
                    average = total / daysInAWeek + 1


                    lblResults.Text = "Average per day: " & average

                End If

            End If

        End If













    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged

    End Sub
End Class
