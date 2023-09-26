<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThốngKêToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.ThốngKêToolStripMenuItem, Me.LoạiSảnPhẩmToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.DToolStripMenuItem.Text = "Đăng Nhập"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản Phẩm"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'ThốngKêToolStripMenuItem
        '
        Me.ThốngKêToolStripMenuItem.Name = "ThốngKêToolStripMenuItem"
        Me.ThốngKêToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ThốngKêToolStripMenuItem.Text = "Thống Kê"
        '
        'LoạiSảnPhẩmToolStripMenuItem
        '
        Me.LoạiSảnPhẩmToolStripMenuItem.Name = "LoạiSảnPhẩmToolStripMenuItem"
        Me.LoạiSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.LoạiSảnPhẩmToolStripMenuItem.Text = "Loại Sản Phẩm"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 406)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThốngKêToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoạiSảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class
