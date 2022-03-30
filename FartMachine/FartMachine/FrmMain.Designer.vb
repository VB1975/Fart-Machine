<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnFart1 = New System.Windows.Forms.Button()
        Me.BtnFart4 = New System.Windows.Forms.Button()
        Me.BtnFart3 = New System.Windows.Forms.Button()
        Me.BtnFart2 = New System.Windows.Forms.Button()
        Me.PicFartImage = New System.Windows.Forms.PictureBox()
        Me.PbrFartDuration = New System.Windows.Forms.ProgressBar()
        Me.LblPic1 = New System.Windows.Forms.Label()
        Me.LblPic2 = New System.Windows.Forms.Label()
        Me.TimFartLength = New System.Windows.Forms.Timer(Me.components)
        Me.TxtCounter = New System.Windows.Forms.TextBox()
        CType(Me.PicFartImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFart1
        '
        Me.BtnFart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFart1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnFart1.Location = New System.Drawing.Point(12, 298)
        Me.BtnFart1.Name = "BtnFart1"
        Me.BtnFart1.Size = New System.Drawing.Size(75, 75)
        Me.BtnFart1.TabIndex = 0
        Me.BtnFart1.Text = "1"
        Me.BtnFart1.UseVisualStyleBackColor = True
        '
        'BtnFart4
        '
        Me.BtnFart4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFart4.ForeColor = System.Drawing.Color.Teal
        Me.BtnFart4.Location = New System.Drawing.Point(411, 298)
        Me.BtnFart4.Name = "BtnFart4"
        Me.BtnFart4.Size = New System.Drawing.Size(75, 75)
        Me.BtnFart4.TabIndex = 1
        Me.BtnFart4.Text = "4"
        Me.BtnFart4.UseVisualStyleBackColor = True
        '
        'BtnFart3
        '
        Me.BtnFart3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFart3.ForeColor = System.Drawing.Color.Green
        Me.BtnFart3.Location = New System.Drawing.Point(278, 298)
        Me.BtnFart3.Name = "BtnFart3"
        Me.BtnFart3.Size = New System.Drawing.Size(75, 75)
        Me.BtnFart3.TabIndex = 2
        Me.BtnFart3.Text = "3"
        Me.BtnFart3.UseVisualStyleBackColor = True
        '
        'BtnFart2
        '
        Me.BtnFart2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFart2.ForeColor = System.Drawing.Color.Olive
        Me.BtnFart2.Location = New System.Drawing.Point(145, 298)
        Me.BtnFart2.Name = "BtnFart2"
        Me.BtnFart2.Size = New System.Drawing.Size(75, 75)
        Me.BtnFart2.TabIndex = 3
        Me.BtnFart2.Text = "2"
        Me.BtnFart2.UseVisualStyleBackColor = True
        '
        'PicFartImage
        '
        Me.PicFartImage.Location = New System.Drawing.Point(12, 12)
        Me.PicFartImage.Name = "PicFartImage"
        Me.PicFartImage.Size = New System.Drawing.Size(476, 251)
        Me.PicFartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFartImage.TabIndex = 4
        Me.PicFartImage.TabStop = False
        '
        'PbrFartDuration
        '
        Me.PbrFartDuration.Location = New System.Drawing.Point(12, 269)
        Me.PbrFartDuration.Name = "PbrFartDuration"
        Me.PbrFartDuration.Size = New System.Drawing.Size(473, 23)
        Me.PbrFartDuration.TabIndex = 5
        Me.PbrFartDuration.Visible = False
        '
        'LblPic1
        '
        Me.LblPic1.Font = New System.Drawing.Font("Mistral", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPic1.Location = New System.Drawing.Point(57, 33)
        Me.LblPic1.Name = "LblPic1"
        Me.LblPic1.Size = New System.Drawing.Size(401, 99)
        Me.LblPic1.TabIndex = 6
        Me.LblPic1.Text = "Make Me"
        Me.LblPic1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPic2
        '
        Me.LblPic2.Font = New System.Drawing.Font("Mistral", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPic2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPic2.Location = New System.Drawing.Point(57, 145)
        Me.LblPic2.Name = "LblPic2"
        Me.LblPic2.Size = New System.Drawing.Size(401, 100)
        Me.LblPic2.TabIndex = 7
        Me.LblPic2.Text = "FART"
        Me.LblPic2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimFartLength
        '
        Me.TimFartLength.Interval = 1000
        '
        'TxtCounter
        '
        Me.TxtCounter.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCounter.ForeColor = System.Drawing.Color.Teal
        Me.TxtCounter.Location = New System.Drawing.Point(12, 234)
        Me.TxtCounter.Name = "TxtCounter"
        Me.TxtCounter.Size = New System.Drawing.Size(75, 29)
        Me.TxtCounter.TabIndex = 8
        Me.TxtCounter.Text = "0"
        Me.TxtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCounter.Visible = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 383)
        Me.Controls.Add(Me.TxtCounter)
        Me.Controls.Add(Me.LblPic2)
        Me.Controls.Add(Me.LblPic1)
        Me.Controls.Add(Me.PbrFartDuration)
        Me.Controls.Add(Me.PicFartImage)
        Me.Controls.Add(Me.BtnFart2)
        Me.Controls.Add(Me.BtnFart3)
        Me.Controls.Add(Me.BtnFart4)
        Me.Controls.Add(Me.BtnFart1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fart Machine"
        CType(Me.PicFartImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFart1 As Button
    Friend WithEvents BtnFart4 As Button
    Friend WithEvents BtnFart3 As Button
    Friend WithEvents BtnFart2 As Button
    Friend WithEvents PicFartImage As PictureBox
    Friend WithEvents PbrFartDuration As ProgressBar
    Friend WithEvents LblPic1 As Label
    Friend WithEvents LblPic2 As Label
    Friend WithEvents TimFartLength As Timer
    Friend WithEvents TxtCounter As TextBox
End Class
