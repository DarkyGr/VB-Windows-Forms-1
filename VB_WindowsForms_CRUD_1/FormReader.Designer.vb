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
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.PnlData = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtRObservations = New System.Windows.Forms.TextBox()
        Me.LblRObservations = New System.Windows.Forms.Label()
        Me.TxtRAddress = New System.Windows.Forms.TextBox()
        Me.LblRAddress = New System.Windows.Forms.Label()
        Me.TxtRPhone = New System.Windows.Forms.TextBox()
        Me.LblRPhone = New System.Windows.Forms.Label()
        Me.TxtRName = New System.Windows.Forms.TextBox()
        Me.LblRName = New System.Windows.Forms.Label()
        Me.TxtRId = New System.Windows.Forms.TextBox()
        Me.lblRId = New System.Windows.Forms.Label()
        Me.DGReaders = New System.Windows.Forms.DataGridView()
        Me.PnlSide = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PnlTitle.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlContent.SuspendLayout()
        Me.PnlData.SuspendLayout()
        CType(Me.DGReaders, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(101, 19)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(374, 26)
        Me.TxtSearch.TabIndex = 3
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
        'PnlContent
        '
        Me.PnlContent.BackColor = System.Drawing.Color.White
        Me.PnlContent.Controls.Add(Me.PnlData)
        Me.PnlContent.Controls.Add(Me.DGReaders)
        Me.PnlContent.Controls.Add(Me.PnlSide)
        Me.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContent.Location = New System.Drawing.Point(0, 137)
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.Size = New System.Drawing.Size(983, 537)
        Me.PnlContent.TabIndex = 2
        '
        'PnlData
        '
        Me.PnlData.Controls.Add(Me.Button2)
        Me.PnlData.Controls.Add(Me.Button1)
        Me.PnlData.Controls.Add(Me.BtnSave)
        Me.PnlData.Controls.Add(Me.TxtRObservations)
        Me.PnlData.Controls.Add(Me.LblRObservations)
        Me.PnlData.Controls.Add(Me.TxtRAddress)
        Me.PnlData.Controls.Add(Me.LblRAddress)
        Me.PnlData.Controls.Add(Me.TxtRPhone)
        Me.PnlData.Controls.Add(Me.LblRPhone)
        Me.PnlData.Controls.Add(Me.TxtRName)
        Me.PnlData.Controls.Add(Me.LblRName)
        Me.PnlData.Controls.Add(Me.TxtRId)
        Me.PnlData.Controls.Add(Me.lblRId)
        Me.PnlData.Location = New System.Drawing.Point(0, 0)
        Me.PnlData.Name = "PnlData"
        Me.PnlData.Size = New System.Drawing.Size(983, 537)
        Me.PnlData.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(608, 494)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 31)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(450, 494)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 31)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(288, 494)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(96, 31)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtRObservations
        '
        Me.TxtRObservations.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRObservations.Location = New System.Drawing.Point(245, 369)
        Me.TxtRObservations.Multiline = True
        Me.TxtRObservations.Name = "TxtRObservations"
        Me.TxtRObservations.Size = New System.Drawing.Size(606, 92)
        Me.TxtRObservations.TabIndex = 9
        '
        'LblRObservations
        '
        Me.LblRObservations.AutoSize = True
        Me.LblRObservations.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRObservations.Location = New System.Drawing.Point(79, 372)
        Me.LblRObservations.Name = "LblRObservations"
        Me.LblRObservations.Size = New System.Drawing.Size(100, 19)
        Me.LblRObservations.TabIndex = 8
        Me.LblRObservations.Text = "Observations"
        '
        'TxtRAddress
        '
        Me.TxtRAddress.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRAddress.Location = New System.Drawing.Point(245, 247)
        Me.TxtRAddress.Multiline = True
        Me.TxtRAddress.Name = "TxtRAddress"
        Me.TxtRAddress.Size = New System.Drawing.Size(606, 92)
        Me.TxtRAddress.TabIndex = 7
        '
        'LblRAddress
        '
        Me.LblRAddress.AutoSize = True
        Me.LblRAddress.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRAddress.Location = New System.Drawing.Point(79, 250)
        Me.LblRAddress.Name = "LblRAddress"
        Me.LblRAddress.Size = New System.Drawing.Size(120, 19)
        Me.LblRAddress.TabIndex = 6
        Me.LblRAddress.Text = "Reader Address"
        '
        'TxtRPhone
        '
        Me.TxtRPhone.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRPhone.Location = New System.Drawing.Point(245, 177)
        Me.TxtRPhone.Name = "TxtRPhone"
        Me.TxtRPhone.Size = New System.Drawing.Size(606, 26)
        Me.TxtRPhone.TabIndex = 5
        '
        'LblRPhone
        '
        Me.LblRPhone.AutoSize = True
        Me.LblRPhone.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRPhone.Location = New System.Drawing.Point(79, 180)
        Me.LblRPhone.Name = "LblRPhone"
        Me.LblRPhone.Size = New System.Drawing.Size(107, 19)
        Me.LblRPhone.TabIndex = 4
        Me.LblRPhone.Text = "Reader Phone"
        '
        'TxtRName
        '
        Me.TxtRName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRName.Location = New System.Drawing.Point(245, 115)
        Me.TxtRName.Name = "TxtRName"
        Me.TxtRName.Size = New System.Drawing.Size(606, 26)
        Me.TxtRName.TabIndex = 3
        '
        'LblRName
        '
        Me.LblRName.AutoSize = True
        Me.LblRName.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRName.Location = New System.Drawing.Point(79, 118)
        Me.LblRName.Name = "LblRName"
        Me.LblRName.Size = New System.Drawing.Size(103, 19)
        Me.LblRName.TabIndex = 2
        Me.LblRName.Text = "Reader Name"
        '
        'TxtRId
        '
        Me.TxtRId.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRId.Location = New System.Drawing.Point(245, 50)
        Me.TxtRId.Name = "TxtRId"
        Me.TxtRId.Size = New System.Drawing.Size(606, 26)
        Me.TxtRId.TabIndex = 1
        '
        'lblRId
        '
        Me.lblRId.AutoSize = True
        Me.lblRId.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRId.Location = New System.Drawing.Point(79, 53)
        Me.lblRId.Name = "lblRId"
        Me.lblRId.Size = New System.Drawing.Size(79, 19)
        Me.lblRId.TabIndex = 0
        Me.lblRId.Text = "Reader ID"
        '
        'DGReaders
        '
        Me.DGReaders.AllowUserToAddRows = False
        Me.DGReaders.AllowUserToDeleteRows = False
        Me.DGReaders.AllowUserToResizeColumns = False
        Me.DGReaders.BackgroundColor = System.Drawing.Color.White
        Me.DGReaders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReaders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGReaders.EnableHeadersVisualStyles = False
        Me.DGReaders.Location = New System.Drawing.Point(0, 0)
        Me.DGReaders.Name = "DGReaders"
        Me.DGReaders.RowHeadersVisible = False
        Me.DGReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGReaders.Size = New System.Drawing.Size(851, 537)
        Me.DGReaders.TabIndex = 1
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
        Me.PictureBox2.Location = New System.Drawing.Point(20, 269)
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
        Me.PnlData.ResumeLayout(False)
        Me.PnlData.PerformLayout()
        CType(Me.DGReaders, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DGReaders As DataGridView
    Friend WithEvents PnlData As Panel
    Friend WithEvents lblRId As Label
    Friend WithEvents TxtRId As TextBox
    Friend WithEvents TxtRObservations As TextBox
    Friend WithEvents LblRObservations As Label
    Friend WithEvents TxtRAddress As TextBox
    Friend WithEvents LblRAddress As Label
    Friend WithEvents TxtRPhone As TextBox
    Friend WithEvents LblRPhone As Label
    Friend WithEvents TxtRName As TextBox
    Friend WithEvents LblRName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Button2 As Button
End Class
