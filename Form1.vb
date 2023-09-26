Public Class Form1
    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click

        Dim frm As New ClientDangNhap()
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click

    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        Dim frm As New ClientThongTinSanPham()
        frm.MdiParent = Me
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Show()
    End Sub
End Class
