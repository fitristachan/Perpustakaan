<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perpustakaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perpustakaan))
        Me.ListBoxKoleksiBuku = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnShowDataGrid = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxKoleksiBuku
        '
        Me.ListBoxKoleksiBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxKoleksiBuku.FormattingEnabled = True
        Me.ListBoxKoleksiBuku.ItemHeight = 15
        Me.ListBoxKoleksiBuku.Location = New System.Drawing.Point(12, 324)
        Me.ListBoxKoleksiBuku.Name = "ListBoxKoleksiBuku"
        Me.ListBoxKoleksiBuku.Size = New System.Drawing.Size(154, 259)
        Me.ListBoxKoleksiBuku.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(649, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(18, 22)
        Me.ToolStripLabel1.Text = "+"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(14, 22)
        Me.ToolStripLabel2.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Layanan Pustaka"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Daftar Koleksi Buku"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(17, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(75, 74)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Politeknik Negeri Jakarta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(515, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "1. Tambahkan koleksi buku dengan melalui menu 'Tambah Koleksi' atau dengan meneka" &
    "n tanda '+' di atas."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(359, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "2. Sebelum menghapus koleksi, mohon tambahkan koleksi terlebih dahulu."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(441, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "3. Hapus koleksi buku dengan memilih buku yang ingin dihapus pada 'Daftar Koleksi" &
    " Buku'. "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Selanjutnya, tekan tanda '-' di atas."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 142)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manual Penggunaan Aplikasi:"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(172, 324)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.Size = New System.Drawing.Size(465, 230)
        Me.DataGridKoleksi.TabIndex = 13
        '
        'BtnShowDataGrid
        '
        Me.BtnShowDataGrid.Location = New System.Drawing.Point(558, 560)
        Me.BtnShowDataGrid.Name = "BtnShowDataGrid"
        Me.BtnShowDataGrid.Size = New System.Drawing.Size(75, 23)
        Me.BtnShowDataGrid.TabIndex = 14
        Me.BtnShowDataGrid.Text = "Select"
        Me.BtnShowDataGrid.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(477, 560)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 15
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDelete.Location = New System.Drawing.Point(396, 560)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 16
        Me.BtnDelete.Text = "Remove"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 603)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnShowDataGrid)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ListBoxKoleksiBuku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxKoleksiBuku As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnShowDataGrid As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
End Class
