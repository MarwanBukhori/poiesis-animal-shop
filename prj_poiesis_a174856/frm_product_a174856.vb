Public Class frm_product_a174856
    Private Sub frm_product_a174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A174856"

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lb_prod.DataSource = mydatatable
        lb_prod.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lb_prod.Text)

    End Sub


    Private Sub refresh_text(prod_id As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174856 WHERE FLD_PRODUCT_ID='" & prod_id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txt_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_ORIGIN")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_weight.Text = mydatatable.Rows(0).Item("FLD_WEIGHT")
        txt_desc.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_id.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.jpg")
        End Try

    End Sub




    Private Sub lb_prod_MouseClick(sender As Object, e As MouseEventArgs) Handles lb_prod.MouseClick
        refresh_text(lb_prod.Text)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu2_a174856.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub lb_prod_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lb_prod_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lb_prod.SelectedIndexChanged

    End Sub
End Class