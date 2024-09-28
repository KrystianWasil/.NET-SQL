<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.adressTextBox = New System.Windows.Forms.TextBox()
        Me.numberTextBox = New System.Windows.Forms.TextBox()
        Me.peselTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Plum
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cascadia Code ExtraLight", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(96, 679)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 53)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dodaj"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.Plum
        Me.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelButton.Font = New System.Drawing.Font("Cascadia Code ExtraLight", 9.0!)
        Me.cancelButton.ForeColor = System.Drawing.Color.Snow
        Me.cancelButton.Location = New System.Drawing.Point(506, 679)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(146, 53)
        Me.cancelButton.TabIndex = 2
        Me.cancelButton.Text = "Anuluj"
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.BackColor = System.Drawing.Color.Lavender
        Me.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.firstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.firstNameTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.firstNameTextBox.Location = New System.Drawing.Point(238, 165)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(428, 43)
        Me.firstNameTextBox.TabIndex = 3
        '
        'adressTextBox
        '
        Me.adressTextBox.BackColor = System.Drawing.Color.Lavender
        Me.adressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.adressTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.adressTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.adressTextBox.Location = New System.Drawing.Point(238, 570)
        Me.adressTextBox.Name = "adressTextBox"
        Me.adressTextBox.Size = New System.Drawing.Size(428, 43)
        Me.adressTextBox.TabIndex = 4
        '
        'numberTextBox
        '
        Me.numberTextBox.BackColor = System.Drawing.Color.Lavender
        Me.numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numberTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.numberTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.numberTextBox.Location = New System.Drawing.Point(238, 490)
        Me.numberTextBox.Name = "numberTextBox"
        Me.numberTextBox.Size = New System.Drawing.Size(428, 43)
        Me.numberTextBox.TabIndex = 5
        '
        'peselTextBox
        '
        Me.peselTextBox.BackColor = System.Drawing.Color.Lavender
        Me.peselTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.peselTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.peselTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.peselTextBox.Location = New System.Drawing.Point(238, 412)
        Me.peselTextBox.Name = "peselTextBox"
        Me.peselTextBox.Size = New System.Drawing.Size(428, 43)
        Me.peselTextBox.TabIndex = 6
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.Lavender
        Me.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.emailTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.emailTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.emailTextBox.Location = New System.Drawing.Point(238, 332)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(428, 43)
        Me.emailTextBox.TabIndex = 7
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.BackColor = System.Drawing.Color.Lavender
        Me.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lastNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.lastNameTextBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lastNameTextBox.Location = New System.Drawing.Point(238, 251)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(428, 43)
        Me.lastNameTextBox.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(598, 54)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Podaj dane nowego uzytkownika:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(59, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 45)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Imie:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(59, 570)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 45)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Adres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(59, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 45)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Numer tel. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(59, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 45)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "PESEL: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(59, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 45)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(59, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 45)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nazwisko:"
        '
        'AddForm
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.cancelButton = Me.cancelButton
        Me.ClientSize = New System.Drawing.Size(759, 861)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.peselTextBox)
        Me.Controls.Add(Me.numberTextBox)
        Me.Controls.Add(Me.adressTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents adressTextBox As TextBox
    Friend WithEvents numberTextBox As TextBox
    Friend WithEvents peselTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
