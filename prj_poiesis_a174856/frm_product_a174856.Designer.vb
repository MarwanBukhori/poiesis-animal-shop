<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_a174856
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lb_prod = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_weight = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.RichTextBox()
        Me.pnl_top.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl_top.Controls.Add(Me.Panel1)
        Me.pnl_top.Controls.Add(Me.lbl_title)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(1287, 99)
        Me.pnl_top.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 10)
        Me.Panel1.TabIndex = 3
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(375, 27)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(305, 28)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "PRODUCT INFORMATIONS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_exit)
        Me.Panel2.Controls.Add(Me.btn_back)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(414, 633)
        Me.Panel2.TabIndex = 1
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btn_exit.Location = New System.Drawing.Point(143, 589)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(107, 32)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(26, 589)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(111, 32)
        Me.btn_back.TabIndex = 1
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lb_prod)
        Me.Panel3.Location = New System.Drawing.Point(42, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 444)
        Me.Panel3.TabIndex = 0
        '
        'lb_prod
        '
        Me.lb_prod.FormattingEnabled = True
        Me.lb_prod.ItemHeight = 16
        Me.lb_prod.Location = New System.Drawing.Point(3, 3)
        Me.lb_prod.Name = "lb_prod"
        Me.lb_prod.Size = New System.Drawing.Size(266, 436)
        Me.lb_prod.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel4.Controls.Add(Me.pic_product)
        Me.Panel4.Location = New System.Drawing.Point(843, 150)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(361, 386)
        Me.Panel4.TabIndex = 2
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(26, 29)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(306, 322)
        Me.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_product.TabIndex = 0
        Me.pic_product.TabStop = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.White
        Me.lbl_id.Location = New System.Drawing.Point(509, 187)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(30, 23)
        Me.lbl_id.TabIndex = 3
        Me.lbl_id.Text = "ID"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(471, 251)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(70, 23)
        Me.lbl_name.TabIndex = 4
        Me.lbl_name.Text = "Name"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.White
        Me.lbl_price.Location = New System.Drawing.Point(481, 314)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(58, 23)
        Me.lbl_price.TabIndex = 5
        Me.lbl_price.Text = "Price"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.Color.White
        Me.lbl_type.Location = New System.Drawing.Point(481, 379)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(56, 23)
        Me.lbl_type.TabIndex = 6
        Me.lbl_type.Text = "Type"
        '
        'lbl_weight
        '
        Me.lbl_weight.AutoSize = True
        Me.lbl_weight.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_weight.ForeColor = System.Drawing.Color.White
        Me.lbl_weight.Location = New System.Drawing.Point(462, 444)
        Me.lbl_weight.Name = "lbl_weight"
        Me.lbl_weight.Size = New System.Drawing.Size(77, 23)
        Me.lbl_weight.TabIndex = 7
        Me.lbl_weight.Text = "Weight"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.White
        Me.lbl_quantity.Location = New System.Drawing.Point(462, 510)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(68, 23)
        Me.lbl_quantity.TabIndex = 8
        Me.lbl_quantity.Text = "Origin"
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.ForeColor = System.Drawing.Color.White
        Me.lbl_desc.Location = New System.Drawing.Point(428, 585)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(113, 23)
        Me.lbl_desc.TabIndex = 9
        Me.lbl_desc.Text = "Description"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(566, 179)
        Me.txt_id.Multiline = True
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(220, 33)
        Me.txt_id.TabIndex = 10
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(566, 244)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(220, 33)
        Me.txt_name.TabIndex = 11
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(566, 306)
        Me.txt_price.Multiline = True
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(114, 33)
        Me.txt_price.TabIndex = 12
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(566, 372)
        Me.txt_type.Multiline = True
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(114, 33)
        Me.txt_type.TabIndex = 13
        '
        'txt_weight
        '
        Me.txt_weight.Location = New System.Drawing.Point(566, 437)
        Me.txt_weight.Multiline = True
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(114, 33)
        Me.txt_weight.TabIndex = 14
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(566, 503)
        Me.txt_quantity.Multiline = True
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(114, 33)
        Me.txt_quantity.TabIndex = 15
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(566, 570)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(465, 126)
        Me.txt_desc.TabIndex = 16
        Me.txt_desc.Text = ""
        '
        'frm_product_a174856
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1287, 732)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_weight)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnl_top)
        Me.Name = "frm_product_a174856"
        Me.Text = "frm_product_a174856"
        Me.pnl_top.ResumeLayout(False)
        Me.pnl_top.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnl_top As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_exit As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_weight As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_desc As RichTextBox
    Friend WithEvents lb_prod As ListBox
End Class
