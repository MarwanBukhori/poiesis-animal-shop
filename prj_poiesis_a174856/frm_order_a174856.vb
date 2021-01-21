Public Class frm_order_a174856
    Private Sub frm_order_a174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim mysql As String = "SELECT * FROM TBL_ORDER_A174856"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_order.DataSource = mydatatable

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu2_a174856.Show()
        Me.Hide()

    End Sub
End Class