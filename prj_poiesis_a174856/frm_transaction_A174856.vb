Public Class frm_transaction_A174856
    Private Sub refresh_order_lbl()
        lbl_order.Text = lb_order.Text
    End Sub

    Private Sub frm_transaction_A174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim mysql As String = "SELECT DISTINCT FLD_ORDER_ID FROM TBL_TRANSACTION_A174856"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lb_order.DataSource = mydatatable

        lb_order.DisplayMember = "FLD_ORDER_ID"
        refresh_order(lb_order.Text)
    End Sub


    Private Sub refresh_order(orderid As String)

        Dim mysql As String = "SELECT * FROM TBL_TRANSACTION_A174856 WHERE FLD_ORDER_ID='" & orderid & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable

    End Sub



    Private Sub lb_order_MouseClick(sender As Object, e As MouseEventArgs) Handles lb_order.MouseClick
        refresh_order(lb_order.Text)
        refresh_order_lbl()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu2_a174856.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_makeorder_A174856.Show()
        Me.Hide()
    End Sub
End Class