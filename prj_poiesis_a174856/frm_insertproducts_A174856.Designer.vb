<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_insertproducts_A174856
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.pnl_left = New System.Windows.Forms.Panel()
        Me.pic_box = New System.Windows.Forms.PictureBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.txt_img = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.pnl_bot = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_desc = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnl_top.SuspendLayout()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_left.SuspendLayout()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_bot.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl_top.Controls.Add(Me.Panel1)
        Me.pnl_top.Controls.Add(Me.Label1)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(1242, 114)
        Me.pnl_top.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1242, 14)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INSERT NEW PRODUCTS"
        '
        'grd_products
        '
        Me.grd_products.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(322, 150)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(836, 410)
        Me.grd_products.TabIndex = 3
        '
        'pnl_left
        '
        Me.pnl_left.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_left.Controls.Add(Me.pic_box)
        Me.pnl_left.Controls.Add(Me.btn_picture)
        Me.pnl_left.Controls.Add(Me.txt_img)
        Me.pnl_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_left.Location = New System.Drawing.Point(0, 114)
        Me.pnl_left.Name = "pnl_left"
        Me.pnl_left.Size = New System.Drawing.Size(282, 477)
        Me.pnl_left.TabIndex = 5
        '
        'pic_box
        '
        Me.pic_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_box.Location = New System.Drawing.Point(40, 78)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.Size = New System.Drawing.Size(195, 203)
        Me.pic_box.TabIndex = 2
        Me.pic_box.TabStop = False
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btn_picture.Location = New System.Drawing.Point(62, 379)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(136, 30)
        Me.btn_picture.TabIndex = 1
        Me.btn_picture.Text = "SELECT"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'txt_img
        '
        Me.txt_img.Location = New System.Drawing.Point(62, 320)
        Me.txt_img.Name = "txt_img"
        Me.txt_img.Size = New System.Drawing.Size(138, 22)
        Me.txt_img.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(58, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(273, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(574, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Weight"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(562, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Origin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(822, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(284, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Price"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(97, 36)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(138, 22)
        Me.txt_id.TabIndex = 7
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(646, 88)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(138, 22)
        Me.txt_quantity.TabIndex = 8
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(355, 34)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(138, 22)
        Me.txt_name.TabIndex = 9
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(646, 32)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(138, 22)
        Me.txt_type.TabIndex = 11
        '
        'txt_weight
        '
        Me.txt_weight.Location = New System.Drawing.Point(97, 83)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(138, 22)
        Me.txt_weight.TabIndex = 12
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(355, 87)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(138, 22)
        Me.txt_price.TabIndex = 13
        '
        'pnl_bot
        '
        Me.pnl_bot.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl_bot.Controls.Add(Me.Button2)
        Me.pnl_bot.Controls.Add(Me.Button1)
        Me.pnl_bot.Controls.Add(Me.btn_insert)
        Me.pnl_bot.Controls.Add(Me.txt_desc)
        Me.pnl_bot.Controls.Add(Me.txt_price)
        Me.pnl_bot.Controls.Add(Me.txt_weight)
        Me.pnl_bot.Controls.Add(Me.txt_type)
        Me.pnl_bot.Controls.Add(Me.txt_name)
        Me.pnl_bot.Controls.Add(Me.txt_quantity)
        Me.pnl_bot.Controls.Add(Me.txt_id)
        Me.pnl_bot.Controls.Add(Me.Label8)
        Me.pnl_bot.Controls.Add(Me.Label7)
        Me.pnl_bot.Controls.Add(Me.Label6)
        Me.pnl_bot.Controls.Add(Me.Label5)
        Me.pnl_bot.Controls.Add(Me.Label4)
        Me.pnl_bot.Controls.Add(Me.Label3)
        Me.pnl_bot.Controls.Add(Me.Label2)
        Me.pnl_bot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_bot.Location = New System.Drawing.Point(0, 591)
        Me.pnl_bot.Name = "pnl_bot"
        Me.pnl_bot.Size = New System.Drawing.Size(1242, 227)
        Me.pnl_bot.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(133, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 30)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(16, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 30)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btn_insert.Location = New System.Drawing.Point(434, 142)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(136, 30)
        Me.btn_insert.TabIndex = 3
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(953, 32)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(243, 96)
        Me.txt_desc.TabIndex = 14
        Me.txt_desc.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_insertproducts_A174856
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1242, 818)
        Me.Controls.Add(Me.pnl_left)
        Me.Controls.Add(Me.pnl_bot)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.pnl_top)
        Me.Name = "frm_insertproducts_A174856"
        Me.Text = "frm_insertproducts_A174856"
        Me.pnl_top.ResumeLayout(False)
        Me.pnl_top.PerformLayout()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_left.ResumeLayout(False)
        Me.pnl_left.PerformLayout()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_bot.ResumeLayout(False)
        Me.pnl_bot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_top As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents pnl_left As Panel
    Friend WithEvents pic_box As PictureBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents txt_img As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents pnl_bot As Panel
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_desc As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
