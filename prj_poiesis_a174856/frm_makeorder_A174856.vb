Public Class frm_makeorder_A174856

    Dim number As Double
    Dim prod_price As Double
    Dim c As String
    Dim jumlah As Double
    Dim prod_quantity As Integer
    Dim current_code As String
    Dim current_code1 As String
    Dim current_code2 As String


    Private Sub frm_makeorder_A174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initializeColumn()
        btn_addcart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date


        refresh_order()

        Dim mysql3 As String = "SELECT * FROM TBL_STAFF_A174856"
        Dim mydatatable3 As New DataTable
        Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
        myreader3.Fill(mydatatable3)
        cb_staff.DataSource = mydatatable3
        cb_staff.DisplayMember = "FLD_STAFF_ID"
        refresh_staff(cb_staff.Text)


        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMER_A174856"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        cb_cust.DataSource = mydatatable2
        cb_cust.DisplayMember = "FLD_CUST_ID"
        refresh_cust(cb_cust.Text)


        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174856"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lb_prod.DataSource = mydatatable
        lb_prod.DisplayMember = "FLD_PRODUCT_ID"
        refresh_prod(lb_prod.Text)

    End Sub

    Private Sub refresh_prod(product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174856 WHERE FLD_PRODUCT_ID='" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        lbl_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        lbl_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        lbl_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        lbl_weight.Text = mydatatable.Rows(0).Item("FLD_WEIGHT")
        lbl_desc.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")
        lbl_post.Text = mydatatable.Rows(0).Item("FLD_ORIGIN")
        lbl_total.Text = number * lbl_price.Text

        Try
            pic_box.BackgroundImage = Image.FromFile("Pictures/" & lbl_id.Text & ".jpg")
        Catch ex As Exception
            pic_box.BackgroundImage = Image.FromFile("Pictures/nophoto.jpg")

        End Try


    End Sub
    Private Sub refresh_staff(staff As String)
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A174856 WHERE FLD_STAFF_ID='" & staff & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_staff_id.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
    End Sub

    Private Sub refresh_cust(customer As String)
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174856 WHERE FLD_CUST_ID='" & customer & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_cust_id.Text = mydatatable.Rows(0).Item("FLD_CUST_ID")
        lbl_cust_name.Text = mydatatable.Rows(0).Item("FLD_CUST_NAME")

    End Sub

    Private Sub refresh_order()
        Dim count As Integer = 1
        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER_A174856"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        count += mydatatable.Rows(0).Item("count_id")
        lbl_new_order.Text = "D" + count.ToString("100")
    End Sub


    Private Sub reset_new_order()
        cb_staff.SelectedIndex = 0
        cb_cust.SelectedIndex = 0
        lbl_cust_id.Text = ""
        lbl_cust_name.Text = ""
        lbl_staff_id.Text = ""

    End Sub


    Private Sub btn_new_order_Click_1(sender As Object, e As EventArgs) Handles btn_new_order.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try
            Dim mysql As String = "INSERT INTO TBL_ORDER_A174856 (FLD_ORDER_ID, FLD_CUST_ID, FLD_STAFF_ID) values (""" &
                lbl_new_order.Text & """,""" & lbl_cust_id.Text & """,""" & lbl_staff_id.Text & """)"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Order created! You can add product(s) now.")

            grd_orderlist.Rows.Clear()
            btn_addcart.Enabled = True
            btn_confirm.Enabled = True
            btn_remove.Enabled = True
            btn_new_order.Enabled = False

        Catch ex As Exception

            Beep()
            MsgBox("Order create fail, try again.")
            mytransaction.Rollback()
            myconnection2.Close()
        End Try



    End Sub

    Private Sub initializeColumn()
        grd_orderlist.ColumnCount = 4
        grd_orderlist.ColumnHeadersVisible = True
        grd_orderlist.Columns(0).Name = "Product ID"
        grd_orderlist.Columns(1).Name = "Product Name"
        grd_orderlist.Columns(2).Name = "Quantity"
        grd_orderlist.Columns(3).Name = "Price"
    End Sub


    Private Sub btn_addcart_Click(sender As System.Object, e As System.EventArgs) Handles btn_addcart.Click


        If lbl_quantity.Value = 0 Then
                Beep()
                MsgBox("Please add product quantity.")

            Else
                grd_orderlist.Rows.Add(New String() {lbl_id.Text, lbl_name.Text, lbl_quantity.Value, lbl_total.Text})

                lbl_total.Text = "0"
                lbl_quantity.Value = 0
                lbl_totally.Text = " "
                refresh_price()
            End If



    End Sub

    Private Sub refresh_price()

        If grd_orderlist.RowCount > 0 Then
            jumlah = 0

            For index As Integer = 0 To grd_orderlist.RowCount - 1
                jumlah += Convert.ToDouble(grd_orderlist.Rows(index).Cells(3).Value)
            Next

            lbl_totally.Text = "RM " & jumlah

        ElseIf grd_orderlist.RowCount = 1 Then

        End If
    End Sub

    Private Sub lbl_quantity_ValueChanged(sender As Object, e As EventArgs) Handles lbl_quantity.ValueChanged
        prod_quantity = lbl_quantity.Value
        prod_price = lbl_price.Text()
        lbl_total.Text = prod_quantity * prod_price
    End Sub


    Private Sub lb_prod_MouseClick(sender As Object, e As MouseEventArgs) Handles lb_prod.MouseClick
        refresh_prod(lb_prod.Text)
    End Sub



    Private Sub cb_cust_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_cust.SelectionChangeCommitted
        refresh_cust(cb_cust.Text)
    End Sub

    Private Sub cb_staff_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_staff.SelectionChangeCommitted
        refresh_staff(cb_staff.Text)
    End Sub


    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click

        Dim delete_msg = MsgBox("Confirm to delete this item from list?", MsgBoxStyle.YesNo)

        If delete_msg = MsgBoxResult.Yes Then
            grd_orderlist.Rows.Remove(grd_orderlist.CurrentRow)
            refresh_price()
        Else
            refresh_price()
        End If
    End Sub


    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction

        Try
            'looping
            For i As Integer = 0 To grd_orderlist.RowCount - 1
                Dim productid As String = grd_orderlist(0, i).Value
                Dim productname As String = grd_orderlist(1, i).Value
                Dim quantity As String = grd_orderlist(2, i).Value
                Dim price As String = grd_orderlist(3, i).Value

                Dim mysql As String = "INSERT INTO TBL_TRANSACTION_A174856 (FLD_ORDER_ID , FLD_PRODUCT_ID, FLD_QUANTITY) values (""" & lbl_new_order.Text & """, """ & productid & """, """ & quantity & """)"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)


                mywriter.ExecuteNonQuery()

            Next
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")

            grd_orderlist.Rows.Clear()
            reset_new_order()

            btn_addcart.Enabled = False
            btn_confirm.Enabled = False
            btn_remove.Enabled = False
            btn_new_order.Enabled = True
            lbl_quantity.Value = 0
            lbl_totally.Text = "0"
            refresh_order()

        Catch ex As Exception

            Beep()
            MsgBox("Please check for repeating products or product ID mistaken.")
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()

        End Try



    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu2_a174856.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        frm_transaction_A174856.Show()
    End Sub


End Class