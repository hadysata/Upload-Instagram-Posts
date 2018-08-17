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
        Me.ImportImageButton = New System.Windows.Forms.Button()
        Me.LoginGroupBox = New System.Windows.Forms.GroupBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ImageGroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CaptionGroupBox = New System.Windows.Forms.GroupBox()
        Me.PostButton = New System.Windows.Forms.Button()
        Me.CaptionTextBox = New System.Windows.Forms.TextBox()
        Me.LoginGroupBox.SuspendLayout()
        Me.ImageGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaptionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImportImageButton
        '
        Me.ImportImageButton.Location = New System.Drawing.Point(21, 34)
        Me.ImportImageButton.Name = "ImportImageButton"
        Me.ImportImageButton.Size = New System.Drawing.Size(220, 23)
        Me.ImportImageButton.TabIndex = 0
        Me.ImportImageButton.Text = "Import Image"
        Me.ImportImageButton.UseVisualStyleBackColor = True
        '
        'LoginGroupBox
        '
        Me.LoginGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.LoginGroupBox.Controls.Add(Me.Label2)
        Me.LoginGroupBox.Controls.Add(Me.UsernameTextBox)
        Me.LoginGroupBox.Controls.Add(Me.Label1)
        Me.LoginGroupBox.Controls.Add(Me.LoginButton)
        Me.LoginGroupBox.Location = New System.Drawing.Point(12, 7)
        Me.LoginGroupBox.Name = "LoginGroupBox"
        Me.LoginGroupBox.Size = New System.Drawing.Size(260, 136)
        Me.LoginGroupBox.TabIndex = 1
        Me.LoginGroupBox.TabStop = False
        Me.LoginGroupBox.Text = "Login"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(89, 59)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(145, 20)
        Me.PasswordTextBox.TabIndex = 6
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password : "
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(89, 33)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(145, 20)
        Me.UsernameTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username : "
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(14, 98)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(220, 23)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'ImageGroupBox
        '
        Me.ImageGroupBox.Controls.Add(Me.PictureBox1)
        Me.ImageGroupBox.Controls.Add(Me.ImportImageButton)
        Me.ImageGroupBox.Enabled = False
        Me.ImageGroupBox.Location = New System.Drawing.Point(12, 149)
        Me.ImageGroupBox.Name = "ImageGroupBox"
        Me.ImageGroupBox.Size = New System.Drawing.Size(260, 196)
        Me.ImageGroupBox.TabIndex = 7
        Me.ImageGroupBox.TabStop = False
        Me.ImageGroupBox.Text = "Image"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(21, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 115)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'CaptionGroupBox
        '
        Me.CaptionGroupBox.Controls.Add(Me.CaptionTextBox)
        Me.CaptionGroupBox.Controls.Add(Me.PostButton)
        Me.CaptionGroupBox.Enabled = False
        Me.CaptionGroupBox.Location = New System.Drawing.Point(12, 351)
        Me.CaptionGroupBox.Name = "CaptionGroupBox"
        Me.CaptionGroupBox.Size = New System.Drawing.Size(260, 136)
        Me.CaptionGroupBox.TabIndex = 7
        Me.CaptionGroupBox.TabStop = False
        Me.CaptionGroupBox.Text = "Caption"
        '
        'PostButton
        '
        Me.PostButton.Location = New System.Drawing.Point(14, 98)
        Me.PostButton.Name = "PostButton"
        Me.PostButton.Size = New System.Drawing.Size(220, 23)
        Me.PostButton.TabIndex = 2
        Me.PostButton.Text = "Post"
        Me.PostButton.UseVisualStyleBackColor = True
        '
        'CaptionTextBox
        '
        Me.CaptionTextBox.Location = New System.Drawing.Point(13, 21)
        Me.CaptionTextBox.Multiline = True
        Me.CaptionTextBox.Name = "CaptionTextBox"
        Me.CaptionTextBox.Size = New System.Drawing.Size(228, 64)
        Me.CaptionTextBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 498)
        Me.Controls.Add(Me.CaptionGroupBox)
        Me.Controls.Add(Me.ImageGroupBox)
        Me.Controls.Add(Me.LoginGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Upload Instagram Posts"
        Me.LoginGroupBox.ResumeLayout(False)
        Me.LoginGroupBox.PerformLayout()
        Me.ImageGroupBox.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaptionGroupBox.ResumeLayout(False)
        Me.CaptionGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImportImageButton As System.Windows.Forms.Button
    Friend WithEvents LoginGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CaptionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PostButton As System.Windows.Forms.Button
    Friend WithEvents CaptionTextBox As System.Windows.Forms.TextBox

End Class
