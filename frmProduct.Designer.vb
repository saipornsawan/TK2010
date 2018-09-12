<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.components = New System.ComponentModel.Container()
        Dim T_noLabel As System.Windows.Forms.Label
        Dim G_noLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim SizeLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim Pro_nameLabel As System.Windows.Forms.Label
        Dim Pro_noLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim lblCount As System.Windows.Forms.Label
        Me.T_noTextBox = New System.Windows.Forms.TextBox()
        Me.G_noTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.Pro_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Pro_noTextBox = New System.Windows.Forms.TextBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.bttFind = New System.Windows.Forms.Button()
        Me.bttUpdate = New System.Windows.Forms.Button()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bttDel = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        T_noLabel = New System.Windows.Forms.Label()
        G_noLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        SizeLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        Pro_nameLabel = New System.Windows.Forms.Label()
        Pro_noLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        lblCount = New System.Windows.Forms.Label()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_noLabel
        '
        T_noLabel.AutoSize = True
        T_noLabel.Location = New System.Drawing.Point(339, 101)
        T_noLabel.Name = "T_noLabel"
        T_noLabel.Size = New System.Drawing.Size(47, 13)
        T_noLabel.TabIndex = 27
        T_noLabel.Text = "ประเภท:"
        '
        'G_noLabel
        '
        G_noLabel.AutoSize = True
        G_noLabel.Location = New System.Drawing.Point(184, 101)
        G_noLabel.Name = "G_noLabel"
        G_noLabel.Size = New System.Drawing.Size(31, 13)
        G_noLabel.TabIndex = 25
        G_noLabel.Text = "เพศ:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(22, 101)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(33, 13)
        PriceLabel.TabIndex = 23
        PriceLabel.Text = "ราคา:"
        '
        'SizeLabel
        '
        SizeLabel.AutoSize = True
        SizeLabel.Location = New System.Drawing.Point(543, 64)
        SizeLabel.Name = "SizeLabel"
        SizeLabel.Size = New System.Drawing.Size(28, 13)
        SizeLabel.TabIndex = 21
        SizeLabel.Text = "size:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(407, 64)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(16, 13)
        ColorLabel.TabIndex = 19
        ColorLabel.Text = "สี:"
        '
        'Pro_nameLabel
        '
        Pro_nameLabel.AutoSize = True
        Pro_nameLabel.Location = New System.Drawing.Point(219, 64)
        Pro_nameLabel.Name = "Pro_nameLabel"
        Pro_nameLabel.Size = New System.Drawing.Size(49, 13)
        Pro_nameLabel.TabIndex = 17
        Pro_nameLabel.Text = "ชื่อสินค้า:"
        '
        'Pro_noLabel
        '
        Pro_noLabel.AutoSize = True
        Pro_noLabel.Location = New System.Drawing.Point(22, 64)
        Pro_noLabel.Name = "Pro_noLabel"
        Pro_noLabel.Size = New System.Drawing.Size(55, 13)
        Pro_noLabel.TabIndex = 15
        Pro_noLabel.Text = "รหัสสินค้า:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(22, 29)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 13)
        Label1.TabIndex = 29
        Label1.Text = "ค้นหา:"
        '
        'lblCount
        '
        lblCount.AutoSize = True
        lblCount.Location = New System.Drawing.Point(31, 192)
        lblCount.Name = "lblCount"
        lblCount.Size = New System.Drawing.Size(40, 13)
        lblCount.TabIndex = 36
        lblCount.Text = "จำนวน"
        '
        'T_noTextBox
        '
        Me.T_noTextBox.Location = New System.Drawing.Point(416, 98)
        Me.T_noTextBox.Name = "T_noTextBox"
        Me.T_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.T_noTextBox.TabIndex = 28
        '
        'G_noTextBox
        '
        Me.G_noTextBox.Location = New System.Drawing.Point(233, 98)
        Me.G_noTextBox.Name = "G_noTextBox"
        Me.G_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.G_noTextBox.TabIndex = 26
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(78, 98)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 24
        '
        'SizeTextBox
        '
        Me.SizeTextBox.Location = New System.Drawing.Point(597, 61)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SizeTextBox.TabIndex = 22
        '
        'ColorTextBox
        '
        Me.ColorTextBox.Location = New System.Drawing.Point(437, 61)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColorTextBox.TabIndex = 20
        '
        'Pro_nameTextBox
        '
        Me.Pro_nameTextBox.Location = New System.Drawing.Point(301, 61)
        Me.Pro_nameTextBox.Name = "Pro_nameTextBox"
        Me.Pro_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pro_nameTextBox.TabIndex = 18
        '
        'Pro_noTextBox
        '
        Me.Pro_noTextBox.Location = New System.Drawing.Point(83, 61)
        Me.Pro_noTextBox.Name = "Pro_noTextBox"
        Me.Pro_noTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pro_noTextBox.TabIndex = 16
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(83, 26)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 20)
        Me.txtFind.TabIndex = 30
        '
        'bttFind
        '
        Me.bttFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttFind.Location = New System.Drawing.Point(189, 24)
        Me.bttFind.Name = "bttFind"
        Me.bttFind.Size = New System.Drawing.Size(52, 23)
        Me.bttFind.TabIndex = 31
        Me.bttFind.Text = "ค้นหา"
        Me.bttFind.UseVisualStyleBackColor = True
        '
        'bttUpdate
        '
        Me.bttUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttUpdate.Location = New System.Drawing.Point(78, 147)
        Me.bttUpdate.Name = "bttUpdate"
        Me.bttUpdate.Size = New System.Drawing.Size(98, 34)
        Me.bttUpdate.TabIndex = 32
        Me.bttUpdate.Text = "บันทึกการแก้ไข"
        Me.bttUpdate.UseVisualStyleBackColor = True
        '
        'dgvList
        '
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Location = New System.Drawing.Point(29, 210)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.Size = New System.Drawing.Size(680, 163)
        Me.dgvList.TabIndex = 33
        '
        'err
        '
        Me.err.ContainerControl = Me
        '
        'bttDel
        '
        Me.bttDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttDel.Location = New System.Drawing.Point(630, 147)
        Me.bttDel.Name = "bttDel"
        Me.bttDel.Size = New System.Drawing.Size(79, 34)
        Me.bttDel.TabIndex = 34
        Me.bttDel.Text = "ลบ"
        Me.bttDel.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(44, 379)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(493, 92)
        Me.ListView1.TabIndex = 35
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 126
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 97
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 473)
        Me.Controls.Add(lblCount)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.bttDel)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.bttUpdate)
        Me.Controls.Add(Me.bttFind)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(T_noLabel)
        Me.Controls.Add(Me.T_noTextBox)
        Me.Controls.Add(G_noLabel)
        Me.Controls.Add(Me.G_noTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(SizeLabel)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(Pro_nameLabel)
        Me.Controls.Add(Me.Pro_nameTextBox)
        Me.Controls.Add(Pro_noLabel)
        Me.Controls.Add(Me.Pro_noTextBox)
        Me.Name = "frmProduct"
        Me.Text = "frmProduct"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents T_noTextBox As TextBox
    Friend WithEvents G_noTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents SizeTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents Pro_nameTextBox As TextBox
    Friend WithEvents Pro_noTextBox As TextBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents bttFind As Button
    Friend WithEvents bttUpdate As System.Windows.Forms.Button
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents bttDel As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
