Public Class frm_transaction_A174856

    Dim totalprice As Double


    Private Sub frm_transaction_A174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A174856 ORDER BY FLD_ORDER_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lb_order.DataSource = mydatatable
        lb_order.DisplayMember = "FLD_ORDER_ID"
        refresh_order(lb_order.Text)
        refresh_price()

    End Sub


    Private Sub refresh_order(orderid As String)

        lbl_order.Text = orderid

        Dim mysql As String = "SELECT TBL_TRANSACTION_A174856.FLD_PRODUCT_ID AS Product_ID, TBL_PRODUCTS_A174856.FLD_PRODUCT_NAME AS Product_Name, TBL_TRANSACTION_A174856.FLD_QUANTITY AS Quantity,TBL_PRODUCTS_A174856.FLD_PRICE AS PRICE ,TBL_TRANSACTION_A174856.FLD_QUANTITY * TBL_PRODUCTS_A174856.FLD_PRICE AS SUB_TOTAL
FROM TBL_PRODUCTS_A174856 INNER JOIN TBL_TRANSACTION_A174856 ON TBL_PRODUCTS_A174856.FLD_PRODUCT_ID = TBL_TRANSACTION_A174856.FLD_PRODUCT_ID
WHERE FLD_ORDER_ID = '" & orderid & "';"

        Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)
            grd_order.DataSource = mydatatable


    End Sub

    Private Sub refresh_price()

        If grd_order.RowCount > 0 Then
                totalprice = 0

                For index As Integer = 0 To grd_order.RowCount - 1
                totalprice += Convert.ToDouble(grd_order.Rows(index).Cells(4).Value)
            Next

                lbl_totally.Text = "RM " & totalprice
            ElseIf grd_order.RowCount = 0 Then

                lbl_totally.Text = "RM 0"

            End If



    End Sub

    Private Sub lb_order_MouseClick(sender As Object, e As MouseEventArgs) Handles lb_order.MouseClick
        refresh_order(lb_order.Text)
        refresh_price()
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