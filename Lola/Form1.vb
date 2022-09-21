Public Class Form1
    Dim btna As Boolean = False
    Dim btnb As Boolean = False
    Dim btnc As Boolean = False
    Dim btnd As Boolean = False

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        btna = CheckBox1.CheckState()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        btnb = CheckBox2.CheckState()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        btnc = CheckBox3.CheckState()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox4.CheckedChanged
        btnd = CheckBox4.CheckState()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If btna = True And btnb = False And btnc = False And btnd = True Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
            MsgBox("Incorrect Password!!!")
        End If
    End Sub
End Class
