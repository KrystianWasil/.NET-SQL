<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditForm
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
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.PeselTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.Lavender
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.FirstNameTextBox.Location = New System.Drawing.Point(279, 146)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(446, 43)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'NumberTextBox
        '
        Me.NumberTextBox.BackColor = System.Drawing.Color.Lavender
        Me.NumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.NumberTextBox.Location = New System.Drawing.Point(279, 485)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(446, 43)
        Me.NumberTextBox.TabIndex = 1
        '
        'AdressTextBox
        '
        Me.AdressTextBox.BackColor = System.Drawing.Color.Lavender
        Me.AdressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AdressTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdressTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AdressTextBox.Location = New System.Drawing.Point(279, 578)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(446, 43)
        Me.AdressTextBox.TabIndex = 2
        '
        'PeselTextBox
        '
        Me.PeselTextBox.BackColor = System.Drawing.Color.Lavender
        Me.PeselTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PeselTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeselTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.PeselTextBox.Location = New System.Drawing.Point(279, 399)
        Me.PeselTextBox.Name = "PeselTextBox"
        Me.PeselTextBox.Size = New System.Drawing.Size(446, 43)
        Me.PeselTextBox.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.Lavender
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.EmailTextBox.Location = New System.Drawing.Point(279, 317)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(446, 43)
        Me.EmailTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.Lavender
        Me.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LastNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LastNameTextBox.Location = New System.Drawing.Point(279, 231)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(446, 43)
        Me.LastNameTextBox.TabIndex = 5
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Plum
        Me.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Cascadia Code ExtraLight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.Snow
        Me.ButtonSave.Location = New System.Drawing.Point(129, 691)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(147, 63)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Edytuj"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Plum
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Cascadia Code ExtraLight", 9.0!)
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Snow
        Me.ButtonCancel.Location = New System.Drawing.Point(498, 691)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(155, 63)
        Me.ButtonCancel.TabIndex = 7
        Me.ButtonCancel.Text = "Anuluj"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(44, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Podaj dane do edycji:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 0
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(77, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 45)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Imię:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(70, 576)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 45)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Adres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(70, 483)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 45)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Numer tel. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(70, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 45)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "PESEL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(77, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 45)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(77, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 45)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nazwisko:"
        '
        'EditForm
        '
        Me.AcceptButton = Me.ButtonSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(786, 898)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.PeselTextBox)
        Me.Controls.Add(Me.AdressTextBox)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Name = "EditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edycja"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents PeselTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
