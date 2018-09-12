<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.เมนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลพนกงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลการขายToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลการสงซอToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ขอมลบรษทผผลตToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.munUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.เมนToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'เมนToolStripMenuItem
        '
        Me.เมนToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ขอมลพนกงานToolStripMenuItem, Me.ขอมลสนคาToolStripMenuItem, Me.ขอมลการขายToolStripMenuItem, Me.ขอมลการสงซอToolStripMenuItem, Me.ขอมลบรษทผผลตToolStripMenuItem})
        Me.เมนToolStripMenuItem.Name = "เมนToolStripMenuItem"
        Me.เมนToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.เมนToolStripMenuItem.Text = "เมนู"
        '
        'ขอมลพนกงานToolStripMenuItem
        '
        Me.ขอมลพนกงานToolStripMenuItem.Name = "ขอมลพนกงานToolStripMenuItem"
        Me.ขอมลพนกงานToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ขอมลพนกงานToolStripMenuItem.Text = "ข้อมูลพนักงาน"
        '
        'ขอมลสนคาToolStripMenuItem
        '
        Me.ขอมลสนคาToolStripMenuItem.Name = "ขอมลสนคาToolStripMenuItem"
        Me.ขอมลสนคาToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ขอมลสนคาToolStripMenuItem.Text = "ข้อมูลสินค้า"
        '
        'ขอมลการขายToolStripMenuItem
        '
        Me.ขอมลการขายToolStripMenuItem.Name = "ขอมลการขายToolStripMenuItem"
        Me.ขอมลการขายToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ขอมลการขายToolStripMenuItem.Text = "ข้อมูลการขาย"
        '
        'ขอมลการสงซอToolStripMenuItem
        '
        Me.ขอมลการสงซอToolStripMenuItem.Name = "ขอมลการสงซอToolStripMenuItem"
        Me.ขอมลการสงซอToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ขอมลการสงซอToolStripMenuItem.Text = "ข้อมูลการสั่งซื้อ"
        '
        'ขอมลบรษทผผลตToolStripMenuItem
        '
        Me.ขอมลบรษทผผลตToolStripMenuItem.Name = "ขอมลบรษทผผลตToolStripMenuItem"
        Me.ขอมลบรษทผผลตToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ขอมลบรษทผผลตToolStripMenuItem.Text = "ข้อมูลบริษัทผู้ผลิต"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.munUser})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'munUser
        '
        Me.munUser.Name = "munUser"
        Me.munUser.Size = New System.Drawing.Size(152, 22)
        Me.munUser.Text = "จัดการผู้ใช้ระบบ"
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 469)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmMaster"
        Me.Text = "frmMaster"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents เมนToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ขอมลพนกงานToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ขอมลสนคาToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ขอมลการขายToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ขอมลการสงซอToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ขอมลบรษทผผลตToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents munUser As ToolStripMenuItem
End Class
