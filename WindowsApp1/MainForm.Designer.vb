<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogInfoLabel = New System.Windows.Forms.Label()
        Me.mainRefreshButton = New System.Windows.Forms.Button()
        Me.mainShowButton = New System.Windows.Forms.Button()
        Me.MainRemoveButton = New System.Windows.Forms.Button()
        Me.mainEditButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1MinSize = 220
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1224, 1083)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.Snow
        Me.SplitContainer2.Panel2.Controls.Add(Me.LogInfoLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.mainRefreshButton)
        Me.SplitContainer2.Panel2.Controls.Add(Me.mainShowButton)
        Me.SplitContainer2.Panel2.Controls.Add(Me.MainRemoveButton)
        Me.SplitContainer2.Panel2.Controls.Add(Me.mainEditButton)
        Me.SplitContainer2.Panel2.Controls.Add(Me.addButton)
        Me.SplitContainer2.Panel2.Controls.Add(Me.searchButton)
        Me.SplitContainer2.Size = New System.Drawing.Size(300, 1083)
        Me.SplitContainer2.SplitterDistance = 113
        Me.SplitContainer2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Snow
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LogInfoLabel
        '
        Me.LogInfoLabel.AutoSize = True
        Me.LogInfoLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogInfoLabel.Font = New System.Drawing.Font("Cascadia Code", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInfoLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LogInfoLabel.Location = New System.Drawing.Point(0, 938)
        Me.LogInfoLabel.Name = "LogInfoLabel"
        Me.LogInfoLabel.Size = New System.Drawing.Size(72, 28)
        Me.LogInfoLabel.TabIndex = 11
        Me.LogInfoLabel.Text = "tutaj"
        Me.LogInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mainRefreshButton
        '
        Me.mainRefreshButton.BackColor = System.Drawing.Color.Snow
        Me.mainRefreshButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.mainRefreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.mainRefreshButton.FlatAppearance.BorderSize = 0
        Me.mainRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainRefreshButton.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainRefreshButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.mainRefreshButton.Image = CType(resources.GetObject("mainRefreshButton.Image"), System.Drawing.Image)
        Me.mainRefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainRefreshButton.Location = New System.Drawing.Point(0, 287)
        Me.mainRefreshButton.Name = "mainRefreshButton"
        Me.mainRefreshButton.Size = New System.Drawing.Size(300, 57)
        Me.mainRefreshButton.TabIndex = 10
        Me.mainRefreshButton.Text = "Odśwież"
        Me.mainRefreshButton.UseVisualStyleBackColor = False
        '
        'mainShowButton
        '
        Me.mainShowButton.BackColor = System.Drawing.Color.Snow
        Me.mainShowButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.mainShowButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.mainShowButton.FlatAppearance.BorderSize = 0
        Me.mainShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainShowButton.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainShowButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.mainShowButton.Image = CType(resources.GetObject("mainShowButton.Image"), System.Drawing.Image)
        Me.mainShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainShowButton.Location = New System.Drawing.Point(0, 228)
        Me.mainShowButton.Name = "mainShowButton"
        Me.mainShowButton.Size = New System.Drawing.Size(300, 59)
        Me.mainShowButton.TabIndex = 9
        Me.mainShowButton.Text = "Wyświetl "
        Me.mainShowButton.UseVisualStyleBackColor = False
        '
        'MainRemoveButton
        '
        Me.MainRemoveButton.BackColor = System.Drawing.Color.Snow
        Me.MainRemoveButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainRemoveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.MainRemoveButton.FlatAppearance.BorderSize = 0
        Me.MainRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainRemoveButton.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainRemoveButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.MainRemoveButton.Image = CType(resources.GetObject("MainRemoveButton.Image"), System.Drawing.Image)
        Me.MainRemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainRemoveButton.Location = New System.Drawing.Point(0, 171)
        Me.MainRemoveButton.Name = "MainRemoveButton"
        Me.MainRemoveButton.Size = New System.Drawing.Size(300, 57)
        Me.MainRemoveButton.TabIndex = 8
        Me.MainRemoveButton.Text = "Usuń"
        Me.MainRemoveButton.UseVisualStyleBackColor = False
        '
        'mainEditButton
        '
        Me.mainEditButton.BackColor = System.Drawing.Color.Snow
        Me.mainEditButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.mainEditButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.mainEditButton.FlatAppearance.BorderSize = 0
        Me.mainEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mainEditButton.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainEditButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.mainEditButton.Image = CType(resources.GetObject("mainEditButton.Image"), System.Drawing.Image)
        Me.mainEditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainEditButton.Location = New System.Drawing.Point(0, 114)
        Me.mainEditButton.Name = "mainEditButton"
        Me.mainEditButton.Size = New System.Drawing.Size(300, 57)
        Me.mainEditButton.TabIndex = 7
        Me.mainEditButton.Text = "Edytuj"
        Me.mainEditButton.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Snow
        Me.addButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.addButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.addButton.FlatAppearance.BorderSize = 0
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.addButton.Image = CType(resources.GetObject("addButton.Image"), System.Drawing.Image)
        Me.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addButton.Location = New System.Drawing.Point(0, 57)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(300, 57)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "Dodaj"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.Snow
        Me.searchButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.searchButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.searchButton.FlatAppearance.BorderSize = 0
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.ForeColor = System.Drawing.Color.RoyalBlue
        Me.searchButton.Image = CType(resources.GetObject("searchButton.Image"), System.Drawing.Image)
        Me.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.searchButton.Location = New System.Drawing.Point(0, 0)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(300, 57)
        Me.searchButton.TabIndex = 5
        Me.searchButton.Text = "Szukaj"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListView1.Size = New System.Drawing.Size(920, 1083)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(256, 118)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(255, 38)
        Me.ToolStripMenuItem1.Text = "Zaznacz wszystko"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(255, 38)
        Me.ToolStripMenuItem2.Text = "Odznacz wszystko"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(255, 38)
        Me.ToolStripMenuItem3.Text = "Odśwież"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 1083)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacients"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents mainShowButton As Button
    Friend WithEvents MainRemoveButton As Button
    Friend WithEvents mainEditButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents mainRefreshButton As Button
    Friend WithEvents LogInfoLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
End Class
