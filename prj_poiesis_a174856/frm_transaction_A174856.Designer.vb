<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_transaction_A174856
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.lb_order = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_order = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_totally = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.tb_quantity = New System.Windows.Forms.TextBox()
        Me.tb_prod_id = New System.Windows.Forms.TextBox()
        Me.lbl_prod_id = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_price_each = New System.Windows.Forms.Label()
        Me.tb_price_each = New System.Windows.Forms.TextBox()
        Me.tb_price = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_order)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.lb_order)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 737)
        Me.Panel1.TabIndex = 0
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.White
        Me.btn_order.Location = New System.Drawing.Point(159, 589)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(91, 29)
        Me.btn_order.TabIndex = 4
        Me.btn_order.Text = "BACK"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(56, 589)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(91, 29)
        Me.btn_back.TabIndex = 3
        Me.btn_back.Text = "MENU"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'lb_order
        '
        Me.lb_order.FormattingEnabled = True
        Me.lb_order.ItemHeight = 16
        Me.lb_order.Location = New System.Drawing.Point(56, 83)
        Me.lb_order.Name = "lb_order"
        Me.lb_order.Size = New System.Drawing.Size(194, 436)
        Me.lb_order.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(637, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INVOICE"
        '
        'lbl_order
        '
        Me.lbl_order.AutoSize = True
        Me.lbl_order.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order.ForeColor = System.Drawing.Color.Black
        Me.lbl_order.Location = New System.Drawing.Point(950, 156)
        Me.lbl_order.Name = "lbl_order"
        Me.lbl_order.Size = New System.Drawing.Size(63, 34)
        Me.lbl_order.TabIndex = 2
        Me.lbl_order.Text = "      "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(894, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ORDER ID"
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AllowUserToDeleteRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(376, 156)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_order.Size = New System.Drawing.Size(419, 363)
        Me.grd_order.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(519, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "POIESIS ANIMAL SHOP"
        '
        'lbl_totally
        '
        Me.lbl_totally.AutoSize = True
        Me.lbl_totally.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totally.ForeColor = System.Drawing.Color.Black
        Me.lbl_totally.Location = New System.Drawing.Point(933, 622)
        Me.lbl_totally.Name = "lbl_totally"
        Me.lbl_totally.Size = New System.Drawing.Size(63, 34)
        Me.lbl_totally.TabIndex = 8
        Me.lbl_totally.Text = "      "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Vladimir Script", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(392, 609)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "MarwanBukhori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(876, 589)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TOTAL PRICE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(398, 639)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Manager"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.Black
        Me.lbl_quantity.Location = New System.Drawing.Point(852, 286)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(77, 20)
        Me.lbl_quantity.TabIndex = 13
        Me.lbl_quantity.Text = "QUANTITY"
        '
        'tb_quantity
        '
        Me.tb_quantity.Location = New System.Drawing.Point(956, 284)
        Me.tb_quantity.Name = "tb_quantity"
        Me.tb_quantity.ReadOnly = True
        Me.tb_quantity.Size = New System.Drawing.Size(100, 22)
        Me.tb_quantity.TabIndex = 16
        Me.tb_quantity.Text = "0"
        '
        'tb_prod_id
        '
        Me.tb_prod_id.Location = New System.Drawing.Point(955, 230)
        Me.tb_prod_id.Name = "tb_prod_id"
        Me.tb_prod_id.ReadOnly = True
        Me.tb_prod_id.Size = New System.Drawing.Size(100, 22)
        Me.tb_prod_id.TabIndex = 15
        '
        'lbl_prod_id
        '
        Me.lbl_prod_id.AutoSize = True
        Me.lbl_prod_id.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prod_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_prod_id.Location = New System.Drawing.Point(830, 232)
        Me.lbl_prod_id.Name = "lbl_prod_id"
        Me.lbl_prod_id.Size = New System.Drawing.Size(99, 20)
        Me.lbl_prod_id.TabIndex = 12
        Me.lbl_prod_id.Text = "PRODUCT ID"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.Black
        Me.lbl_price.Location = New System.Drawing.Point(852, 399)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(83, 20)
        Me.lbl_price.TabIndex = 17
        Me.lbl_price.Text = "SUB PRICE"
        '
        'lbl_price_each
        '
        Me.lbl_price_each.AutoSize = True
        Me.lbl_price_each.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price_each.ForeColor = System.Drawing.Color.Black
        Me.lbl_price_each.Location = New System.Drawing.Point(838, 345)
        Me.lbl_price_each.Name = "lbl_price_each"
        Me.lbl_price_each.Size = New System.Drawing.Size(97, 20)
        Me.lbl_price_each.TabIndex = 19
        Me.lbl_price_each.Text = "PRICE EACH"
        '
        'tb_price_each
        '
        Me.tb_price_each.Location = New System.Drawing.Point(956, 345)
        Me.tb_price_each.Name = "tb_price_each"
        Me.tb_price_each.ReadOnly = True
        Me.tb_price_each.Size = New System.Drawing.Size(100, 22)
        Me.tb_price_each.TabIndex = 20
        '
        'tb_price
        '
        Me.tb_price.AutoSize = True
        Me.tb_price.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price.ForeColor = System.Drawing.Color.Black
        Me.tb_price.Location = New System.Drawing.Point(960, 399)
        Me.tb_price.Name = "tb_price"
        Me.tb_price.Size = New System.Drawing.Size(57, 23)
        Me.tb_price.TabIndex = 21
        Me.tb_price.Text = "      0"
        '
        'frm_transaction_A174856
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1112, 737)
        Me.Controls.Add(Me.tb_price)
        Me.Controls.Add(Me.tb_price_each)
        Me.Controls.Add(Me.lbl_price_each)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.tb_quantity)
        Me.Controls.Add(Me.tb_prod_id)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_prod_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_totally)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_order)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frm_transaction_A174856"
        Me.Text = "                                              "
        Me.Panel1.ResumeLayout(False)
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_order As ListBox
    Friend WithEvents lbl_order As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_totally As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents tb_quantity As TextBox
    Friend WithEvents tb_prod_id As TextBox
    Friend WithEvents lbl_prod_id As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_price_each As Label
    Friend WithEvents tb_price_each As TextBox
    Friend WithEvents tb_price As Label
End Class
