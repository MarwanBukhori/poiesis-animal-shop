Public Class frm_insertproducts_A174856

    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertproducts_A174856_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174856")

        txt_id.Text = generate_id()

        txt_img.Text = defaultpicture
        pic_box.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCTS_A174856").Rows(0).Item("LASTID")

        Dim newmatric As String = "P" & Mid(lastid, 2) + 1
        Return newmatric
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A174856 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "','" & txt_type.Text & "' ,'" & txt_weight.Text & "' ,'" & txt_desc.Text & "' ,'" & txt_quantity.Text & "' )"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_img.Text, "pictures\" & txt_id.Text & ".jpg")


            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174856")
            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_price.Text = ""
            txt_type.Text = ""
            txt_weight.Text = ""
            txt_desc.Text = ""
            txt_quantity.Text = ""
            txt_img.Text = defaultpicture
            pic_box.BackgroundImage = Image.FromFile(defaultpicture)
            Beep()
            MsgBox("You have successfully add new product")

        Catch ex As Exception
            Beep()
            MsgBox(“There is a mistake in the data you entered, as shown below” & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub btn_picture_Click(sender As System.Object, e As System.EventArgs) Handles btn_picture.Click

        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        Try
            pic_box.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_img.Text = OpenFileDialog1.FileName

        Catch ex As Exception

            MsgBox("You didnt select any picture for your product")
        End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_mainmenu2_a174856.Show()
        Me.Hide()
    End Sub

    Private Sub pnl_bot_Paint(sender As Object, e As PaintEventArgs) Handles pnl_bot.Paint

    End Sub
End Class