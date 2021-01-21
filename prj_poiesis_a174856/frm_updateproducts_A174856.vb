Public Class frm_updateproducts_A174856

    Dim current_code As String

    Private Sub frm_updateproducts_A174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
    End Sub


    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174856"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_products.DataSource = mydatatable

    End Sub

    Private Sub clear_fields()

        txt_desc.Text = ""
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_quantity.Text = ""
        txt_type.Text = ""
        txt_weight.Text = ""

    End Sub


    Private Sub get_current_code()

        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_type.Text = grd_products(3, current_row).Value
        txt_weight.Text = grd_products(4, current_row).Value
        txt_desc.Text = grd_products(5, current_row).Value
        txt_quantity.Text = grd_products(6, current_row).Value

    End Sub


    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'run_sql_command("UPDATE TBL_PRODUCTS_A174856 SET FLD_PRODUCT_NAME='" & txt_newproductname.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        'run_sql_command("UPDATE TBL_PRODUCTS_A174856 SET FLD_PRICE='" & txt_newprice.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        'run_sql_command("UPDATE TBL_PRODUCTS_A174856 SET FLD_GENRE='" & txt_newgenre.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        'run_sql_command("UPDATE TBL_PRODUCTS_A174856 SET FLD_PLAYABLE='" & txt_newplayable.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        'run_sql_command("UPDATE TBL_PRODUCTS_A174856 SET FLD_RELEASED='" & txt_newreleased.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        'run_sql_command("UPDATE TBL_PRODUCTS_A174856 SET FLD_TYPE='" & txt_newtype.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        run_sql_command("UPDATE TBL_PRODUCTS_A174856 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE='" & txt_price.Text & "', FLD_TYPE='" & txt_type.Text & "', FLD_WEIGHT='" & txt_weight.Text & "', FLD_DESCRIPTION='" & txt_desc.Text & "', FLD_ORIGIN='" & txt_quantity.Text & "'WHERE FLD_PRODUCT_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the product : """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu2_a174856.Show()
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)

        Try
            If delete_confirmation = MsgBoxResult.Yes Then
                run_sql_command("DELETE FROM TBL_PRODUCTS_A174856 WHERE FLD_PRODUCT_ID='" & current_code & "'")
                My.Computer.FileSystem.DeleteFile("pictures\" & current_code & ".jpg")

                Beep()
                MsgBox("The product """ & current_code & """ has been successfully deleted.")

                refresh_grid()
                clear_fields()
                get_current_code()
            End If

        Catch ex As Exception

            Beep()
            MsgBox("Product deleted but not found related image")
            refresh_grid()
            clear_fields()
            get_current_code()

        End Try


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub grd_products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellContentClick

    End Sub
End Class