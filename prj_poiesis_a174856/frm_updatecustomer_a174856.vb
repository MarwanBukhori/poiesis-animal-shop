Public Class frm_updatecustomer_a174856
    Dim current_id As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_customer_a174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()

        get_current_id()

    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174856"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customers.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_no.Text = ""
        txt_address.Text = ""

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        run_sql_command("UPDATE TBL_CUSTOMER_A174856 SET FLD_CUST_NAME='" & txt_name.Text & "', FLD_CUST_PHONE='" & txt_no.Text & "', FLD_CUST_ADDRESS='" & txt_address.Text & "'WHERE FLD_CUST_ID='" & current_id & "'")
        Beep()
        MsgBox("You have successfully updated the customer """ & current_id & """.")
        refresh_grid()
        clear_fields()
        get_current_id()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the customer """ & current_id & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_CUSTOMER_A174856 WHERE FLD_CUST_ID='" & current_id & "'")
            Beep()
            MsgBox("The customer """ & current_id & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_id()
        End If
    End Sub

    Private Sub get_current_id()
        Dim current_row As Integer = grd_customers.CurrentRow.Index
        current_id = grd_customers(0, current_row).Value

        txt_id.Text = current_id
        txt_name.Text = grd_customers(1, current_row).Value
        txt_no.Text = grd_customers(2, current_row).Value
        txt_address.Text = grd_customers(3, current_row).Value

    End Sub


    Private Sub grd_customers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customers.CellClick
        get_current_id()
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        'refresh_grid()
        frm_mainmenu2_a174856.Show()
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub grd_customers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customers.CellContentClick

    End Sub
End Class