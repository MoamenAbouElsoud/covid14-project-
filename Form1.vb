Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Fever, Dry cough, Diarrhoea, Headache" Then
            Label1.Text = "Covid- 19"
        ElseIf ComboBox1.SelectedItem = "cough, Headache, diarrhoea" Then
            Label1.Text = "Normal Flu"
        ElseIf ComboBox1.SelectedItem = "Fever" Then
            Label1.Text = "Other disease"
        ElseIf ComboBox1.SelectedItem = "Conjunctivitis" Then
            Label1.Text = "Other disease"
        ElseIf ComboBox1.SelectedItem = "Difficulty breathing, loss of taste or smell" Then
            Label1.Text = "Covid- 19"
        ElseIf ComboBox1.SelectedItem = "runny nose, Headache, cough" Then
            Label1.Text = "strong Flu"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("Hallo," & TextBox2.Text & "  ," & TextBox1.Text + " years, " & "  Your disease is" & Label1.Text & "you have to go to doctor" & "  Thank you")

    End Sub
End Class