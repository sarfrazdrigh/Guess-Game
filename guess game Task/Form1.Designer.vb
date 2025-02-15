<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.textInput = New System.Windows.Forms.TextBox()
        Me.guessBtn = New System.Windows.Forms.PictureBox()
        Me.restartBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.guessText = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.scoreText = New System.Windows.Forms.Label()
        Me.remainText = New System.Windows.Forms.Label()
        Me.correctguessImg = New System.Windows.Forms.PictureBox()
        Me.wrongguessImg = New System.Windows.Forms.PictureBox()
        Me.headTextImg = New System.Windows.Forms.PictureBox()
        Me.checktext = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guessBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restartBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.correctguessImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wrongguessImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headTextImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(178, 215)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(237, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(178, 261)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(237, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'textInput
        '
        Me.textInput.BackColor = System.Drawing.Color.Gold
        Me.textInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textInput.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textInput.Location = New System.Drawing.Point(178, 282)
        Me.textInput.Multiline = True
        Me.textInput.Name = "textInput"
        Me.textInput.Size = New System.Drawing.Size(237, 60)
        Me.textInput.TabIndex = 3
        '
        'guessBtn
        '
        Me.guessBtn.BackColor = System.Drawing.Color.Transparent
        Me.guessBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.guessBtn.Image = CType(resources.GetObject("guessBtn.Image"), System.Drawing.Image)
        Me.guessBtn.Location = New System.Drawing.Point(178, 366)
        Me.guessBtn.Name = "guessBtn"
        Me.guessBtn.Size = New System.Drawing.Size(237, 62)
        Me.guessBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guessBtn.TabIndex = 4
        Me.guessBtn.TabStop = False
        '
        'restartBtn
        '
        Me.restartBtn.BackColor = System.Drawing.Color.Transparent
        Me.restartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.restartBtn.Image = CType(resources.GetObject("restartBtn.Image"), System.Drawing.Image)
        Me.restartBtn.Location = New System.Drawing.Point(178, 454)
        Me.restartBtn.Name = "restartBtn"
        Me.restartBtn.Size = New System.Drawing.Size(237, 62)
        Me.restartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.restartBtn.TabIndex = 5
        Me.restartBtn.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(785, 259)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(237, 62)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(736, 215)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(237, 46)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(720, 324)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(237, 46)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 9
        Me.PictureBox8.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(764, 434)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(237, 46)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 11
        Me.PictureBox10.TabStop = False
        '
        'guessText
        '
        Me.guessText.AutoSize = True
        Me.guessText.BackColor = System.Drawing.Color.Transparent
        Me.guessText.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.guessText.Image = CType(resources.GetObject("guessText.Image"), System.Drawing.Image)
        Me.guessText.Location = New System.Drawing.Point(801, 272)
        Me.guessText.Name = "guessText"
        Me.guessText.Size = New System.Drawing.Size(33, 34)
        Me.guessText.TabIndex = 12
        Me.guessText.Text = "0"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(785, 366)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(237, 62)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(785, 479)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(237, 62)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'scoreText
        '
        Me.scoreText.AutoSize = True
        Me.scoreText.BackColor = System.Drawing.Color.Transparent
        Me.scoreText.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.scoreText.Image = CType(resources.GetObject("scoreText.Image"), System.Drawing.Image)
        Me.scoreText.Location = New System.Drawing.Point(801, 381)
        Me.scoreText.Name = "scoreText"
        Me.scoreText.Size = New System.Drawing.Size(33, 34)
        Me.scoreText.TabIndex = 15
        Me.scoreText.Text = "0"
        '
        'remainText
        '
        Me.remainText.AutoSize = True
        Me.remainText.BackColor = System.Drawing.Color.Transparent
        Me.remainText.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.remainText.Image = CType(resources.GetObject("remainText.Image"), System.Drawing.Image)
        Me.remainText.Location = New System.Drawing.Point(801, 493)
        Me.remainText.Name = "remainText"
        Me.remainText.Size = New System.Drawing.Size(33, 34)
        Me.remainText.TabIndex = 16
        Me.remainText.Text = "5"
        '
        'correctguessImg
        '
        Me.correctguessImg.BackColor = System.Drawing.Color.Transparent
        Me.correctguessImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.correctguessImg.Image = CType(resources.GetObject("correctguessImg.Image"), System.Drawing.Image)
        Me.correctguessImg.Location = New System.Drawing.Point(476, 290)
        Me.correctguessImg.Name = "correctguessImg"
        Me.correctguessImg.Size = New System.Drawing.Size(190, 138)
        Me.correctguessImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.correctguessImg.TabIndex = 17
        Me.correctguessImg.TabStop = False
        Me.correctguessImg.Visible = False
        '
        'wrongguessImg
        '
        Me.wrongguessImg.BackColor = System.Drawing.Color.Transparent
        Me.wrongguessImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.wrongguessImg.Image = CType(resources.GetObject("wrongguessImg.Image"), System.Drawing.Image)
        Me.wrongguessImg.Location = New System.Drawing.Point(476, 290)
        Me.wrongguessImg.Name = "wrongguessImg"
        Me.wrongguessImg.Size = New System.Drawing.Size(190, 138)
        Me.wrongguessImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.wrongguessImg.TabIndex = 18
        Me.wrongguessImg.TabStop = False
        Me.wrongguessImg.Visible = False
        '
        'headTextImg
        '
        Me.headTextImg.BackColor = System.Drawing.Color.Transparent
        Me.headTextImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.headTextImg.Image = CType(resources.GetObject("headTextImg.Image"), System.Drawing.Image)
        Me.headTextImg.Location = New System.Drawing.Point(45, 121)
        Me.headTextImg.Name = "headTextImg"
        Me.headTextImg.Size = New System.Drawing.Size(1041, 49)
        Me.headTextImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.headTextImg.TabIndex = 0
        Me.headTextImg.TabStop = False
        '
        'checktext
        '
        Me.checktext.AutoSize = True
        Me.checktext.BackColor = System.Drawing.Color.Transparent
        Me.checktext.Font = New System.Drawing.Font("MS UI Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.checktext.Image = CType(resources.GetObject("checktext.Image"), System.Drawing.Image)
        Me.checktext.Location = New System.Drawing.Point(494, 446)
        Me.checktext.Name = "checktext"
        Me.checktext.Size = New System.Drawing.Size(0, 34)
        Me.checktext.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1098, 750)
        Me.Controls.Add(Me.checktext)
        Me.Controls.Add(Me.wrongguessImg)
        Me.Controls.Add(Me.correctguessImg)
        Me.Controls.Add(Me.remainText)
        Me.Controls.Add(Me.scoreText)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.guessText)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.restartBtn)
        Me.Controls.Add(Me.guessBtn)
        Me.Controls.Add(Me.textInput)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.headTextImg)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guessBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restartBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.correctguessImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wrongguessImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headTextImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents textInput As TextBox
    Friend WithEvents guessBtn As PictureBox
    Friend WithEvents restartBtn As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents guessText As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents scoreText As Label
    Friend WithEvents remainText As Label
    Friend WithEvents correctguessImg As PictureBox
    Friend WithEvents wrongguessImg As PictureBox
    Friend WithEvents headTextImg As PictureBox
    Friend WithEvents checktext As Label
End Class
