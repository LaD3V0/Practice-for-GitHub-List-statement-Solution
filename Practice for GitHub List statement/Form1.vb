Public Class frmMain
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listTeachers.SelectedIndexChanged
        If listTeachers.SelectedIndex = 0 Then
            picSelimovic.Visible = True
            lblSel.Visible = True
            picChristy.Visible = False
            lblChristy.Visible = False
            picArm.Visible = False
            lblArm.Visible = False
            picGreen.Visible = False
            lblGreen.Visible = False
            picNipert.Visible = False
            lblNIpery.Visible = False
        ElseIf listTeachers.SelectedIndex = 1 Then
            picGreen.Visible = True
            lblGreen.Visible = True
            picSelimovic.Visible = False
            lblSel.Visible = False
            picNipert.Visible = False
            lblNIpery.Visible = False
            picChristy.Visible = False
            lblChristy.Visible = False
            picArm.Visible = False
            lblArm.Visible = False
        ElseIf listTeachers.SelectedIndex = 2 Then
            picNipert.Visible = True
            lblNIpery.Visible = True
            picSelimovic.Visible = False
            lblSel.Visible = False
            picChristy.Visible = False
            lblChristy.Visible = False
            picArm.Visible = False
            lblArm.Visible = False
            picGreen.Visible = False
            lblGreen.Visible = False
        ElseIf listTeachers.SelectedIndex = 3 Then
            picChristy.Visible = True
            lblChristy.Visible = True
            picArm.Visible = False
            lblArm.Visible = False
            picGreen.Visible = False
            lblGreen.Visible = False
            picSelimovic.Visible = False
            lblSel.Visible = False
            picNipert.Visible = False
            lblNIpery.Visible = False
        ElseIf listTeachers.SelectedIndex = 4 Then
            picArm.Visible = True
            lblArm.Visible = True
            picGreen.Visible = False
            lblGreen.Visible = False
            picSelimovic.Visible = False
            lblSel.Visible = False
            picNipert.Visible = False
            lblNIpery.Visible = False
            picChristy.Visible = False
            lblChristy.Visible = False
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblArm.Click

    End Sub
End Class
