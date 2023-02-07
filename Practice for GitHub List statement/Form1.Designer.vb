<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.listTeachers = New System.Windows.Forms.ListBox()
        Me.lblSel = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblArm = New System.Windows.Forms.Label()
        Me.lblChristy = New System.Windows.Forms.Label()
        Me.lblNIpery = New System.Windows.Forms.Label()
        Me.picArm = New System.Windows.Forms.PictureBox()
        Me.picSelimovic = New System.Windows.Forms.PictureBox()
        Me.picNipert = New System.Windows.Forms.PictureBox()
        Me.picChristy = New System.Windows.Forms.PictureBox()
        Me.picGreen = New System.Windows.Forms.PictureBox()
        CType(Me.picArm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSelimovic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNipert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChristy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listTeachers
        '
        Me.listTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listTeachers.FormattingEnabled = True
        Me.listTeachers.ItemHeight = 25
        Me.listTeachers.Items.AddRange(New Object() {"Teacher #1", "Teacher #2", "Teacher #3", "Teacher #4 ", "Teacher #5"})
        Me.listTeachers.Location = New System.Drawing.Point(541, 118)
        Me.listTeachers.Name = "listTeachers"
        Me.listTeachers.Size = New System.Drawing.Size(121, 129)
        Me.listTeachers.TabIndex = 0
        '
        'lblSel
        '
        Me.lblSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSel.Location = New System.Drawing.Point(226, 289)
        Me.lblSel.Name = "lblSel"
        Me.lblSel.Size = New System.Drawing.Size(113, 24)
        Me.lblSel.TabIndex = 5
        Me.lblSel.Text = "Mrs.Selimovic"
        Me.lblSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSel.Visible = False
        '
        'lblGreen
        '
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreen.Location = New System.Drawing.Point(226, 289)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(113, 24)
        Me.lblGreen.TabIndex = 7
        Me.lblGreen.Text = "Ms.Green"
        Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGreen.Visible = False
        '
        'lblArm
        '
        Me.lblArm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArm.Location = New System.Drawing.Point(224, 336)
        Me.lblArm.Name = "lblArm"
        Me.lblArm.Size = New System.Drawing.Size(115, 36)
        Me.lblArm.TabIndex = 8
        Me.lblArm.Text = "Ms.Armstrong"
        Me.lblArm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblArm.Visible = False
        '
        'lblChristy
        '
        Me.lblChristy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChristy.Location = New System.Drawing.Point(226, 289)
        Me.lblChristy.Name = "lblChristy"
        Me.lblChristy.Size = New System.Drawing.Size(113, 24)
        Me.lblChristy.TabIndex = 9
        Me.lblChristy.Text = "Ms.Christy"
        Me.lblChristy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblChristy.Visible = False
        '
        'lblNIpery
        '
        Me.lblNIpery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIpery.Location = New System.Drawing.Point(226, 289)
        Me.lblNIpery.Name = "lblNIpery"
        Me.lblNIpery.Size = New System.Drawing.Size(113, 24)
        Me.lblNIpery.TabIndex = 10
        Me.lblNIpery.Text = "Mr.Nipert"
        Me.lblNIpery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNIpery.Visible = False
        '
        'picArm
        '
        Me.picArm.Image = Global.Practice_for_GitHub_List_statement.My.Resources.Resources.Armstrong_CS
        Me.picArm.Location = New System.Drawing.Point(159, 12)
        Me.picArm.Name = "picArm"
        Me.picArm.Size = New System.Drawing.Size(250, 321)
        Me.picArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picArm.TabIndex = 11
        Me.picArm.TabStop = False
        Me.picArm.Visible = False
        '
        'picSelimovic
        '
        Me.picSelimovic.Image = Global.Practice_for_GitHub_List_statement.My.Resources.Resources.Selimovic_CS
        Me.picSelimovic.Location = New System.Drawing.Point(220, 118)
        Me.picSelimovic.Name = "picSelimovic"
        Me.picSelimovic.Size = New System.Drawing.Size(119, 149)
        Me.picSelimovic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSelimovic.TabIndex = 4
        Me.picSelimovic.TabStop = False
        Me.picSelimovic.Visible = False
        '
        'picNipert
        '
        Me.picNipert.Image = Global.Practice_for_GitHub_List_statement.My.Resources.Resources.Nipert_CS
        Me.picNipert.Location = New System.Drawing.Point(151, 12)
        Me.picNipert.Name = "picNipert"
        Me.picNipert.Size = New System.Drawing.Size(258, 255)
        Me.picNipert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picNipert.TabIndex = 3
        Me.picNipert.TabStop = False
        Me.picNipert.Visible = False
        '
        'picChristy
        '
        Me.picChristy.Image = Global.Practice_for_GitHub_List_statement.My.Resources.Resources.Christy_CS
        Me.picChristy.Location = New System.Drawing.Point(160, 104)
        Me.picChristy.Name = "picChristy"
        Me.picChristy.Size = New System.Drawing.Size(249, 163)
        Me.picChristy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picChristy.TabIndex = 2
        Me.picChristy.TabStop = False
        Me.picChristy.Visible = False
        '
        'picGreen
        '
        Me.picGreen.Image = Global.Practice_for_GitHub_List_statement.My.Resources.Resources.Green_CS
        Me.picGreen.Location = New System.Drawing.Point(151, 12)
        Me.picGreen.Name = "picGreen"
        Me.picGreen.Size = New System.Drawing.Size(250, 255)
        Me.picGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGreen.TabIndex = 1
        Me.picGreen.TabStop = False
        Me.picGreen.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picArm)
        Me.Controls.Add(Me.lblNIpery)
        Me.Controls.Add(Me.lblChristy)
        Me.Controls.Add(Me.lblArm)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblSel)
        Me.Controls.Add(Me.picSelimovic)
        Me.Controls.Add(Me.picNipert)
        Me.Controls.Add(Me.picChristy)
        Me.Controls.Add(Me.picGreen)
        Me.Controls.Add(Me.listTeachers)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picArm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSelimovic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNipert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChristy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listTeachers As ListBox
    Friend WithEvents picGreen As PictureBox
    Friend WithEvents picChristy As PictureBox
    Friend WithEvents picNipert As PictureBox
    Friend WithEvents picSelimovic As PictureBox
    Friend WithEvents lblSel As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblArm As Label
    Friend WithEvents lblChristy As Label
    Friend WithEvents lblNIpery As Label
    Friend WithEvents picArm As PictureBox
End Class
