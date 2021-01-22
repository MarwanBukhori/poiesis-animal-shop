Public Class frm_transaction_A174856
    Dim price As String
    Dim jumlah As Double

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
        'grd_order.Columns.Add("PRICE", "PRICE")


    End Sub


    Private Sub refresh_order(orderid As String)

        Dim mysql As String = "SELECT * FROM TBL_TRANSACTION_A174856 WHERE FLD_ORDER_ID='" & orderid & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable
        tb_prod_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        tb_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")


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




    Private Sub grd_order_SelectionChanged(sender As Object, e As EventArgs) Handles grd_order.SelectionChanged
        Try
            Dim proid As String = grd_order.SelectedRows(0).Cells(1).Value.ToString
            tb_prod_id.Text = proid

            Dim quan As String = grd_order.SelectedRows(0).Cells(2).Value.ToString
            tb_quantity.Text = quan

            refresh_price(proid)

        Catch ex As Exception

            refresh_order_lbl()

        End Try

    End Sub


    Private Sub refresh_price(proid As String)

        Try
            Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174856 WHERE FLD_PRODUCT_ID='" & proid & "'"
            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
            myreader.Fill(mydatatable)

            price = mydatatable.Rows(0).Item("FLD_PRICE")

            tb_price_each.Text = price

            tb_price.Text = "RM " & price * tb_quantity.Text

        Catch ex As Exception

            MsgBox("Problem occur")

        End Try

    End Sub

    'Private Sub refresh_total_price()


    '    If grd_order.RowCount > 0 Then
    '        jumlah = 0

    '        For index As Integer = 0 To grd_order.RowCount - 1
    '            jumlah += Convert.ToDouble(grd_order.Rows(Index).Cells(3).Value)
    '        Next

    '        lbl_totally.Text = "RM " & jumlah

    '    ElseIf grd_order.RowCount = 1 Then

    '    End If
    'End Sub


End Class