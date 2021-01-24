Public Class frm_splashscreen_A174856
    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        frm_mainmenu2_a174856.Show()
        Me.Hide()
    End Sub


    Private Sub frm_splashscreen_A174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
    End Sub
End Class