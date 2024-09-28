<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.RegisterButton2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PasswordTextBox2 = New System.Windows.Forms.TextBox()
        Me.LoginTextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegisterButton2
        '
        Me.RegisterButton2.BackColor = System.Drawing.Color.Plum
        Me.RegisterButton2.FlatAppearance.BorderSize = 0
        Me.RegisterButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.RegisterButton2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RegisterButton2.Location = New System.Drawing.Point(412, 310)
        Me.RegisterButton2.Name = "RegisterButton2"
        Me.RegisterButton2.Size = New System.Drawing.Size(243, 91)
        Me.RegisterButton2.TabIndex = 25
        Me.RegisterButton2.Text = "Zarejestruj się"
        Me.RegisterButton2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(263, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 45)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Nazwa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(263, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 45)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Hasło"
        '
        'PasswordTextBox2
        '
        Me.PasswordTextBox2.BackColor = System.Drawing.Color.Lavender
        Me.PasswordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.PasswordTextBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.PasswordTextBox2.Location = New System.Drawing.Point(412, 236)
        Me.PasswordTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordTextBox2.Name = "PasswordTextBox2"
        Me.PasswordTextBox2.Size = New System.Drawing.Size(243, 43)
        Me.PasswordTextBox2.TabIndex = 22
        '
        'LoginTextBox2
        '
        Me.LoginTextBox2.BackColor = System.Drawing.Color.Lavender
        Me.LoginTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LoginTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.LoginTextBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LoginTextBox2.Location = New System.Drawing.Point(412, 165)
        Me.LoginTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginTextBox2.Name = "LoginTextBox2"
        Me.LoginTextBox2.Size = New System.Drawing.Size(243, 43)
        Me.LoginTextBox2.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(91, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 50)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Zarejestruj się"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 0
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RegisterForm
        '
        Me.AcceptButton = Me.RegisterButton2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 503)
        Me.Controls.Add(Me.RegisterButton2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PasswordTextBox2)
        Me.Controls.Add(Me.LoginTextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegisterButton2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordTextBox2 As TextBox
    Friend WithEvents LoginTextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
