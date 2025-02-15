Public Class Form1


    Dim targetNumber As Integer
    Dim guessCount As Integer = 0
    Dim remainingChances As Integer = 5
    Dim score As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Randomize()
        targetNumber = CInt(Int((25 * Rnd()) + 1))

    End Sub

    Private Sub guessBtn_Click(sender As Object, e As EventArgs) Handles guessBtn.Click

        Dim userGuess As Integer = Val(textInput.Text)
        guessCount += 1
        remainingChances -= 1

        If userGuess > 25 Then
            textInput.Text = ""
            checktext.Text = "Invalid Input"

        ElseIf userGuess = targetNumber Then
            correctguessImg.Visible = True
            wrongguessImg.Visible = False
            score += 10
            scoreText.Text = score
            targetNumber = CInt(Int((25 * Rnd()) + 1))
            guessText.Text = guessCount + 1
            remainingChances += 1
            remainText.Text = remainingChances
            checktext.Text = "Congratulations"



        ElseIf remainingChances = 0 Then

            targetNumber = CInt(Int((25 * Rnd()) + 1))
            guessCount = 0
            guessText.Text = guessCount
            remainingChances = 5
            remainText.Text = remainingChances
            score = 0
            scoreText.Text = score
            textInput.Text = ""

        ElseIf userGuess < targetNumber Then
            remainText.Text = remainingChances
            guessText.Text = guessCount
            wrongguessImg.Visible = True
            checktext.Text = "Too Low"
            textInput.Text = ""


        ElseIf userGuess > targetNumber Then
            guessText.Text = guessCount
            remainText.Text = remainingChances
            wrongguessImg.Visible = True
            checktext.Text = "Too High"
            textInput.Text = ""

        End If
    End Sub

    Private Sub restartBtn_Click(sender As Object, e As EventArgs) Handles restartBtn.Click
        targetNumber = CInt(Int((25 * Rnd()) + 1))
        guessCount = 0
        guessText.Text = guessCount
        remainingChances = 5
        remainText.Text = remainingChances
        score = 0
        scoreText.Text = score
        wrongguessImg.Visible = False
        correctguessImg.Visible = False
        textInput.Text = ""
        checktext.Text = ""

    End Sub
End Class
