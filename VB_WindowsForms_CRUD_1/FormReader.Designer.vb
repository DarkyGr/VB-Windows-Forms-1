<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReader))
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PnlSearch = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.PnlSide = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PnlTitle.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlContent.SuspendLayout()
        Me.PnlSide.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DarkOrange
        Me.PnlTitle.Controls.Add(Me.BtnClose)
        Me.PnlTitle.Controls.Add(Me.LblTitle)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(983, 71)
        Me.PnlTitle.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(926, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(45, 45)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(39, 22)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(82, 22)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Readers"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.White
        Me.PnlSearch.Controls.Add(Me.TxtSearch)
        Me.PnlSearch.Controls.Add(Me.PictureBox1)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Location = New System.Drawing.Point(0, 71)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(983, 66)
        Me.PnlSearch.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(101, 19)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(374, 26)
        Me.TxtSearch.TabIndex = 3
        '
        'PnlContent
        '
        Me.PnlContent.BackColor = System.Drawing.Color.White
        Me.PnlContent.Controls.Add(Me.PnlSide)
        Me.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContent.Location = New System.Drawing.Point(0, 137)
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.Size = New System.Drawing.Size(983, 537)
        Me.PnlContent.TabIndex = 2
        '
        'PnlSide
        '
        Me.PnlSide.Controls.Add(Me.PictureBox2)
        Me.PnlSide.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlSide.Location = New System.Drawing.Point(851, 0)
        Me.PnlSide.Name = "PnlSide"
        Me.PnlSide.Size = New System.Drawing.Size(132, 537)
        Me.PnlSide.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 294)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'FormReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 674)
        Me.Controls.Add(Me.PnlContent)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlSearch.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlContent.ResumeLayout(False)
        Me.PnlSide.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents PnlSearch As Panel
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlContent As Panel
    Friend WithEvents PnlSide As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
