Public Class frm_insertcustomer_A174856


    Private Sub frm_insertcustomer_A174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        txt_id.Text = generate_id()


    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174856"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd__customer.DataSource = mydatatable

    End Sub
    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_CUST_ID) AS LASTID FROM TBL_CUSTOMER_A174856").Rows(0).Item("LASTID")

        Dim newmatric As String = "C" & Mid(lastid, 2) + 1
        Return newmatric
    End Function

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_no.Text = ""
        txt_address.Text = ""
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A174856 VALUES ('” & txt_id.Text & "', '" & txt_name.Text & "', " & txt_no.Text & ", '" & txt_address.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            refresh_grid()
            clear_fields()
            txt_id.Text = generate_id()
            Beep()
            MsgBox("You have successfully add new customer")

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try

    End Sub

    Private Sub pnl_top_Paint(sender As Object, e As PaintEventArgs) Handles pnl_top.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu2_a174856.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class