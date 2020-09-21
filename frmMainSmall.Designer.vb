<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainSmall
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainSmall))
        Me.wmpLogin = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pbMinimize = New System.Windows.Forms.PictureBox()
        Me.pbOptions = New System.Windows.Forms.PictureBox()
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbText1 = New System.Windows.Forms.PictureBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCut = New System.Windows.Forms.Label()
        Me.lblPatch = New System.Windows.Forms.Label()
        Me.pbSignIn = New System.Windows.Forms.PictureBox()
        Me.lblSignIn = New System.Windows.Forms.LinkLabel()
        Me.lblCreate = New System.Windows.Forms.LinkLabel()
        Me.lblVaank = New System.Windows.Forms.LinkLabel()
        Me.pbOptionsMenu = New System.Windows.Forms.PictureBox()
        Me.lbLoginSelection = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cbLogin = New System.Windows.Forms.ComboBox()
        Me.pbDone = New System.Windows.Forms.PictureBox()
        Me.lbPath = New System.Windows.Forms.Label()
        Me.pbPath = New System.Windows.Forms.PictureBox()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.signTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lbVolume = New System.Windows.Forms.Label()
        Me.pbVolume = New System.Windows.Forms.PictureBox()
        Me.numVolume = New System.Windows.Forms.NumericUpDown()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cbLanguage = New System.Windows.Forms.ComboBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.pbLanguage = New System.Windows.Forms.PictureBox()
        Me.pbSize = New System.Windows.Forms.PictureBox()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.panMove = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.wmpLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSignIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOptionsMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wmpLogin
        '
        Me.wmpLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wmpLogin.Enabled = True
        Me.wmpLogin.Location = New System.Drawing.Point(0, 0)
        Me.wmpLogin.Name = "wmpLogin"
        Me.wmpLogin.OcxState = CType(resources.GetObject("wmpLogin.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpLogin.Size = New System.Drawing.Size(975, 548)
        Me.wmpLogin.TabIndex = 10
        '
        'pbMinimize
        '
        Me.pbMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMinimize.BackColor = System.Drawing.Color.Transparent
        Me.pbMinimize.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.MinimizeDisabled
        Me.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMinimize.InitialImage = Nothing
        Me.pbMinimize.Location = New System.Drawing.Point(1071, -3)
        Me.pbMinimize.Name = "pbMinimize"
        Me.pbMinimize.Size = New System.Drawing.Size(26, 28)
        Me.pbMinimize.TabIndex = 1
        Me.pbMinimize.TabStop = False
        '
        'pbOptions
        '
        Me.pbOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbOptions.BackColor = System.Drawing.Color.Transparent
        Me.pbOptions.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.OptionsDisabled
        Me.pbOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbOptions.InitialImage = Nothing
        Me.pbOptions.Location = New System.Drawing.Point(1111, -3)
        Me.pbOptions.Name = "pbOptions"
        Me.pbOptions.Size = New System.Drawing.Size(26, 28)
        Me.pbOptions.TabIndex = 2
        Me.pbOptions.TabStop = False
        '
        'pbClose
        '
        Me.pbClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbClose.BackColor = System.Drawing.Color.Transparent
        Me.pbClose.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.CloseDisabled
        Me.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClose.InitialImage = Nothing
        Me.pbClose.Location = New System.Drawing.Point(1152, -2)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(26, 28)
        Me.pbClose.TabIndex = 12
        Me.pbClose.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.Logo
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLogo.Location = New System.Drawing.Point(1003, 50)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(151, 63)
        Me.pbLogo.TabIndex = 13
        Me.pbLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.Sign_IN
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(971, 149)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 24)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'pbText1
        '
        Me.pbText1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbText1.BackColor = System.Drawing.Color.Transparent
        Me.pbText1.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.TextBox
        Me.pbText1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbText1.Location = New System.Drawing.Point(989, 208)
        Me.pbText1.Name = "pbText1"
        Me.pbText1.Size = New System.Drawing.Size(179, 40)
        Me.pbText1.TabIndex = 15
        Me.pbText1.TabStop = False
        '
        'lblPass
        '
        Me.lblPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPass.Location = New System.Drawing.Point(984, 261)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(101, 16)
        Me.lblPass.TabIndex = 19
        Me.lblPass.Text = "Login Screens by"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.TextBox
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(989, 280)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 40)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'lblCut
        '
        Me.lblCut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCut.AutoSize = True
        Me.lblCut.BackColor = System.Drawing.Color.Transparent
        Me.lblCut.ForeColor = System.Drawing.Color.DimGray
        Me.lblCut.Location = New System.Drawing.Point(911, 509)
        Me.lblCut.Name = "lblCut"
        Me.lblCut.Size = New System.Drawing.Size(301, 13)
        Me.lblCut.TabIndex = 22
        Me.lblCut.Text = "_________________________________________________"
        '
        'lblPatch
        '
        Me.lblPatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPatch.AutoSize = True
        Me.lblPatch.BackColor = System.Drawing.Color.Transparent
        Me.lblPatch.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatch.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblPatch.Location = New System.Drawing.Point(1041, 526)
        Me.lblPatch.Name = "lblPatch"
        Me.lblPatch.Size = New System.Drawing.Size(61, 20)
        Me.lblPatch.TabIndex = 23
        Me.lblPatch.Text = "V10.18"
        '
        'pbSignIn
        '
        Me.pbSignIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbSignIn.BackColor = System.Drawing.Color.Transparent
        Me.pbSignIn.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.SignInDisabled
        Me.pbSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSignIn.Location = New System.Drawing.Point(989, 351)
        Me.pbSignIn.Name = "pbSignIn"
        Me.pbSignIn.Size = New System.Drawing.Size(179, 31)
        Me.pbSignIn.TabIndex = 24
        Me.pbSignIn.TabStop = False
        '
        'lblSignIn
        '
        Me.lblSignIn.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.lblSignIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lblSignIn.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblSignIn.Location = New System.Drawing.Point(987, 425)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(78, 15)
        Me.lblSignIn.TabIndex = 25
        Me.lblSignIn.TabStop = True
        Me.lblSignIn.Text = "Can't Sign In?"
        '
        'lblCreate
        '
        Me.lblCreate.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.lblCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreate.AutoSize = True
        Me.lblCreate.BackColor = System.Drawing.Color.Transparent
        Me.lblCreate.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.LinkColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblCreate.Location = New System.Drawing.Point(987, 450)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(104, 15)
        Me.lblCreate.TabIndex = 26
        Me.lblCreate.TabStop = True
        Me.lblCreate.Text = "Create an account"
        '
        'lblVaank
        '
        Me.lblVaank.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.lblVaank.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVaank.BackColor = System.Drawing.Color.Transparent
        Me.lblVaank.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVaank.LinkColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.lblVaank.Location = New System.Drawing.Point(987, 476)
        Me.lblVaank.Name = "lblVaank"
        Me.lblVaank.Size = New System.Drawing.Size(142, 41)
        Me.lblVaank.TabIndex = 27
        Me.lblVaank.TabStop = True
        Me.lblVaank.Text = "Check Vaank's channel for More Animations"
        '
        'pbOptionsMenu
        '
        Me.pbOptionsMenu.BackColor = System.Drawing.Color.Transparent
        Me.pbOptionsMenu.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.OptionsMenu
        Me.pbOptionsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbOptionsMenu.Location = New System.Drawing.Point(290, 104)
        Me.pbOptionsMenu.Name = "pbOptionsMenu"
        Me.pbOptionsMenu.Size = New System.Drawing.Size(368, 362)
        Me.pbOptionsMenu.TabIndex = 28
        Me.pbOptionsMenu.TabStop = False
        Me.pbOptionsMenu.Visible = False
        '
        'lbLoginSelection
        '
        Me.lbLoginSelection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLoginSelection.AutoSize = True
        Me.lbLoginSelection.BackColor = System.Drawing.Color.Transparent
        Me.lbLoginSelection.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLoginSelection.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbLoginSelection.Location = New System.Drawing.Point(346, 118)
        Me.lbLoginSelection.Name = "lbLoginSelection"
        Me.lbLoginSelection.Size = New System.Drawing.Size(82, 16)
        Me.lbLoginSelection.TabIndex = 30
        Me.lbLoginSelection.Text = "Login Screen:"
        Me.lbLoginSelection.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.TextBox
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(349, 137)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(231, 28)
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'cbLogin
        '
        Me.cbLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLogin.BackColor = System.Drawing.SystemColors.ControlText
        Me.cbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLogin.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLogin.ForeColor = System.Drawing.Color.DarkGray
        Me.cbLogin.FormattingEnabled = True
        Me.cbLogin.Items.AddRange(New Object() {"Current", "PsyOps", "Yone", "Lillia", "Sett", "Aphelios", "Qiyana", "Lucian", "Custom"})
        Me.cbLogin.Location = New System.Drawing.Point(352, 139)
        Me.cbLogin.Name = "cbLogin"
        Me.cbLogin.Size = New System.Drawing.Size(224, 24)
        Me.cbLogin.TabIndex = 31
        Me.cbLogin.Visible = False
        '
        'pbDone
        '
        Me.pbDone.BackColor = System.Drawing.Color.Transparent
        Me.pbDone.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.DoneButton
        Me.pbDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDone.Location = New System.Drawing.Point(421, 423)
        Me.pbDone.Name = "pbDone"
        Me.pbDone.Size = New System.Drawing.Size(121, 39)
        Me.pbDone.TabIndex = 32
        Me.pbDone.TabStop = False
        Me.pbDone.Visible = False
        '
        'lbPath
        '
        Me.lbPath.AutoSize = True
        Me.lbPath.BackColor = System.Drawing.Color.Transparent
        Me.lbPath.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPath.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbPath.Location = New System.Drawing.Point(346, 180)
        Me.lbPath.Name = "lbPath"
        Me.lbPath.Size = New System.Drawing.Size(74, 16)
        Me.lbPath.TabIndex = 34
        Me.lbPath.Text = "Game Path:"
        Me.lbPath.Visible = False
        '
        'pbPath
        '
        Me.pbPath.BackColor = System.Drawing.Color.Transparent
        Me.pbPath.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.TextBox
        Me.pbPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPath.Location = New System.Drawing.Point(349, 199)
        Me.pbPath.Name = "pbPath"
        Me.pbPath.Size = New System.Drawing.Size(231, 28)
        Me.pbPath.TabIndex = 33
        Me.pbPath.TabStop = False
        Me.pbPath.Visible = False
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.BackColor = System.Drawing.Color.Black
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPath.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPath.Location = New System.Drawing.Point(354, 204)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(222, 17)
        Me.txtPath.TabIndex = 35
        Me.txtPath.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(994, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Nachsacred"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(994, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Vaank"
        '
        'signTimer
        '
        Me.signTimer.Interval = 3000
        '
        'lbVolume
        '
        Me.lbVolume.AutoSize = True
        Me.lbVolume.BackColor = System.Drawing.Color.Transparent
        Me.lbVolume.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVolume.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbVolume.Location = New System.Drawing.Point(346, 239)
        Me.lbVolume.Name = "lbVolume"
        Me.lbVolume.Size = New System.Drawing.Size(53, 16)
        Me.lbVolume.TabIndex = 39
        Me.lbVolume.Text = "Volume:"
        Me.lbVolume.Visible = False
        '
        'pbVolume
        '
        Me.pbVolume.BackColor = System.Drawing.Color.Transparent
        Me.pbVolume.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.TextBox
        Me.pbVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbVolume.Location = New System.Drawing.Point(349, 259)
        Me.pbVolume.Name = "pbVolume"
        Me.pbVolume.Size = New System.Drawing.Size(53, 28)
        Me.pbVolume.TabIndex = 38
        Me.pbVolume.TabStop = False
        Me.pbVolume.Visible = False
        '
        'numVolume
        '
        Me.numVolume.BackColor = System.Drawing.SystemColors.ControlText
        Me.numVolume.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numVolume.ForeColor = System.Drawing.Color.DarkGray
        Me.numVolume.Location = New System.Drawing.Point(351, 261)
        Me.numVolume.Name = "numVolume"
        Me.numVolume.Size = New System.Drawing.Size(48, 24)
        Me.numVolume.TabIndex = 40
        Me.numVolume.Value = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numVolume.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(987, 400)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 15)
        Me.LinkLabel1.TabIndex = 41
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Check Github for Updates"
        '
        'cbLanguage
        '
        Me.cbLanguage.BackColor = System.Drawing.SystemColors.ControlText
        Me.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLanguage.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLanguage.ForeColor = System.Drawing.Color.DarkGray
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.Items.AddRange(New Object() {"English (US)", "English (UK)", "Czech", "French", "German", "Greek", "Italian", "Japanese", "Polish", "Portuguese", "Russian", "Spanish (Spain)", "Spanish (Latin America)", "Turkish"})
        Me.cbLanguage.Location = New System.Drawing.Point(352, 320)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(224, 24)
        Me.cbLanguage.TabIndex = 44
        Me.cbLanguage.Visible = False
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.BackColor = System.Drawing.Color.Transparent
        Me.lblLanguage.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLanguage.Location = New System.Drawing.Point(346, 299)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(102, 16)
        Me.lblLanguage.TabIndex = 43
        Me.lblLanguage.Text = "Game Language:"
        Me.lblLanguage.Visible = False
        '
        'pbLanguage
        '
        Me.pbLanguage.BackColor = System.Drawing.Color.Transparent
        Me.pbLanguage.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.TextBox
        Me.pbLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLanguage.Location = New System.Drawing.Point(349, 318)
        Me.pbLanguage.Name = "pbLanguage"
        Me.pbLanguage.Size = New System.Drawing.Size(231, 28)
        Me.pbLanguage.TabIndex = 42
        Me.pbLanguage.TabStop = False
        Me.pbLanguage.Visible = False
        '
        'pbSize
        '
        Me.pbSize.BackColor = System.Drawing.Color.Transparent
        Me.pbSize.BackgroundImage = Global.LeagueLoginScreen.My.Resources.Resources.TextBox
        Me.pbSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSize.Location = New System.Drawing.Point(349, 374)
        Me.pbSize.Name = "pbSize"
        Me.pbSize.Size = New System.Drawing.Size(231, 28)
        Me.pbSize.TabIndex = 45
        Me.pbSize.TabStop = False
        Me.pbSize.Visible = False
        '
        'cbSize
        '
        Me.cbSize.BackColor = System.Drawing.SystemColors.ControlText
        Me.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSize.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSize.ForeColor = System.Drawing.Color.DarkGray
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"Normal", "Small"})
        Me.cbSize.Location = New System.Drawing.Point(352, 376)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(224, 24)
        Me.cbSize.TabIndex = 47
        Me.cbSize.Visible = False
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.BackColor = System.Drawing.Color.Transparent
        Me.lblSize.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSize.Location = New System.Drawing.Point(346, 355)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(83, 16)
        Me.lblSize.TabIndex = 46
        Me.lblSize.Text = "Window Size:"
        Me.lblSize.Visible = False
        '
        'panMove
        '
        Me.panMove.BackColor = System.Drawing.Color.Transparent
        Me.panMove.Location = New System.Drawing.Point(933, -3)
        Me.panMove.Name = "panMove"
        Me.panMove.Size = New System.Drawing.Size(321, 26)
        Me.panMove.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("BeaufortforLOL-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(985, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Made by"
        '
        'frmMainSmall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1182, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.pbSize)
        Me.Controls.Add(Me.cbLanguage)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.pbLanguage)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.numVolume)
        Me.Controls.Add(Me.lbVolume)
        Me.Controls.Add(Me.pbVolume)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lbPath)
        Me.Controls.Add(Me.pbPath)
        Me.Controls.Add(Me.pbDone)
        Me.Controls.Add(Me.cbLogin)
        Me.Controls.Add(Me.lbLoginSelection)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pbOptionsMenu)
        Me.Controls.Add(Me.lblVaank)
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.pbSignIn)
        Me.Controls.Add(Me.lblPatch)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pbText1)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.pbClose)
        Me.Controls.Add(Me.pbOptions)
        Me.Controls.Add(Me.pbMinimize)
        Me.Controls.Add(Me.wmpLogin)
        Me.Controls.Add(Me.lblCut)
        Me.Controls.Add(Me.panMove)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainSmall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "League of Legends"
        CType(Me.wmpLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSignIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOptionsMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wmpLogin As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents pbMinimize As PictureBox
    Friend WithEvents pbOptions As PictureBox
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbText1 As PictureBox
    Friend WithEvents lblPass As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCut As Label
    Friend WithEvents lblPatch As Label
    Friend WithEvents pbSignIn As PictureBox
    Friend WithEvents lblSignIn As LinkLabel
    Friend WithEvents lblCreate As LinkLabel
    Friend WithEvents lblVaank As LinkLabel
    Friend WithEvents pbOptionsMenu As PictureBox
    Friend WithEvents lbLoginSelection As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cbLogin As ComboBox
    Friend WithEvents pbDone As PictureBox
    Friend WithEvents lbPath As Label
    Friend WithEvents pbPath As PictureBox
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents signTimer As Timer
    Friend WithEvents lbVolume As Label
    Friend WithEvents pbVolume As PictureBox
    Friend WithEvents numVolume As NumericUpDown
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cbLanguage As ComboBox
    Friend WithEvents lblLanguage As Label
    Friend WithEvents pbLanguage As PictureBox
    Friend WithEvents pbSize As PictureBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents lblSize As Label
    Friend WithEvents panMove As Panel
    Friend WithEvents Label3 As Label
End Class
