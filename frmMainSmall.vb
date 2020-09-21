Imports System.IO
Imports System.Threading
'On each Code Update:
'-Change the If in Load
'-Change ChangeSize()
'-Change the corresponding names of classes and calls to forms
Public Class frmMainSmall
    Private filePath, selectedLogin As String
    Private configPath, gamePath, gameLanguage As String
    Private signInEnabled As Boolean = False
    Private videoStarted As Boolean = False
    Private loginVolume As Integer = 50
    Private startLanguage, finalLanguage As String
    Private pos As Point
    Private currentSize, newSize As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configuration Load
        configPath = Application.StartupPath + "\config.cfg"
        LoadConfiguration()

        'Style Definition
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        lblCut.ForeColor = Color.FromArgb(32, 35, 37)
        lblPatch.ForeColor = Color.FromArgb(59, 63, 67)

        'Login Screen Media Loader
        If newSize = "Small" Then
            StartVideo()
        End If

        'Set Size
        cbSize.SelectedItem = currentSize

        signTimer.Start()
    End Sub

    Private Sub pbMinimize_MouseEnter(sender As Object, e As EventArgs) Handles pbMinimize.MouseEnter
        pbMinimize.BackgroundImage = My.Resources.MinimizeEnabled
    End Sub

    Private Sub pbMinimize_MouseLeave(sender As Object, e As EventArgs) Handles pbMinimize.MouseLeave
        pbMinimize.BackgroundImage = My.Resources.MinimizeDisabled
    End Sub

    Private Sub pbMinimize_Click(sender As Object, e As EventArgs) Handles pbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbOptions_MouseEnter(sender As Object, e As EventArgs) Handles pbOptions.MouseEnter
        pbOptions.BackgroundImage = My.Resources.OptionsEnabled
    End Sub

    Private Sub pbOptions_MouseLeave(sender As Object, e As EventArgs) Handles pbOptions.MouseLeave
        pbOptions.BackgroundImage = My.Resources.OptionsDisabled
    End Sub

    Private Sub pbOptions_Click(sender As Object, e As EventArgs) Handles pbOptions.Click
        ChangeOptions(True, False)
    End Sub

    Private Sub wmpLogin_Enter(sender As Object, e As EventArgs) Handles wmpLogin.Enter
        Me.ActiveControl = Nothing
    End Sub

    Private Sub pbClose_MouseEnter(sender As Object, e As EventArgs) Handles pbClose.MouseEnter
        pbClose.BackgroundImage = My.Resources.CloseEnabled
    End Sub

    Private Sub pbClose_MouseLeave(sender As Object, e As EventArgs) Handles pbClose.MouseLeave
        pbClose.BackgroundImage = My.Resources.CloseDisabled
    End Sub

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        Application.Exit()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs)
        ChangeSignIn()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs)
        ChangeSignIn()
    End Sub

    Private Sub pbSignIn_Click(sender As Object, e As EventArgs) Handles pbSignIn.Click
        SignIn()
    End Sub

    Private Sub ChangeSignIn()
        pbSignIn.BackgroundImage = My.Resources.SignInEnabled
        pbSignIn.Cursor = Cursors.Hand
        signInEnabled = True
    End Sub

    Private Sub SignIn()
        If signInEnabled = True Then
            finalLanguage = gameLanguage
            My.Computer.Audio.Play(My.Resources.LoginSound, AudioPlayMode.Background)
            'If the language was changed, change it in game launch
            If startLanguage <> finalLanguage Then
                Select Case cbLanguage.SelectedItem.ToString()
                    Case "English (US)"
                        gameLanguage = "en_US"
                    Case "English (UK)"
                        gameLanguage = "en_GB"
                    Case "Czech"
                        gameLanguage = "cs_CZ"
                    Case "French"
                        gameLanguage = "fr_FR"
                    Case "German"
                        gameLanguage = "de_DE"
                    Case "Greek"
                        gameLanguage = "el_GR"
                    Case "Italian"
                        gameLanguage = "it_IT"
                    Case "Japanese"
                        gameLanguage = "ja_JP"
                    Case "Polish"
                        gameLanguage = "pl_PL"
                    Case "Portuguese"
                        gameLanguage = "pt_BR"
                    Case "Russian"
                        gameLanguage = "ru_RU"
                    Case "Spanish (Spain)"
                        gameLanguage = "es_ES"
                    Case "Spanish (Latin America)"
                        gameLanguage = "es_MX"
                    Case "Turkish"
                        gameLanguage = "tr_TR"
                End Select
                Process.Start(gamePath, "--locale=" + gameLanguage)
            Else
                Process.Start(gamePath)
            End If

            Thread.Sleep(2000)
            Application.Exit()
        End If
    End Sub

    Private Sub LoadConfiguration()
        If Not File.Exists(configPath) Then
            Dim writer As StreamWriter = New StreamWriter(configPath)
            writer.WriteLine("Path=C:\Riot Games\League of Legends\LeagueClient.exe")
            writer.WriteLine("LoginScreen=Current")
            writer.WriteLine("Volume=50")
            writer.WriteLine("Language=English (US)")
            If Screen.PrimaryScreen.Bounds.Width < 1600 Or Screen.PrimaryScreen.Bounds.Height < 800 Then
                writer.WriteLine("WindowSize=Small")
            Else
                writer.WriteLine("WindowSize=Normal")
            End If

            writer.Close()
        End If

        Dim reader As StreamReader = New StreamReader(configPath)
        Dim currentCfg As String



        'Get Game Path
        currentCfg = reader.ReadLine()
        currentCfg = currentCfg.Replace("Path=", String.Empty)
        gamePath = currentCfg

        'Get Chosen Login Screen
        currentCfg = reader.ReadLine()
        currentCfg = currentCfg.Replace("LoginScreen=", String.Empty)
        selectedLogin = currentCfg

        'Get Volume
        currentCfg = reader.ReadLine()
        currentCfg = currentCfg.Replace("Volume=", String.Empty)
        loginVolume = Integer.Parse(currentCfg)

        'Get Language
        currentCfg = reader.ReadLine()
        currentCfg = currentCfg.Replace("Language=", String.Empty)
        gameLanguage = currentCfg
        startLanguage = gameLanguage

        'Get Window Size
        currentCfg = reader.ReadLine()
        currentCfg = currentCfg.Replace("WindowSize=", String.Empty)
        currentSize = currentCfg
        newSize = currentSize

        reader.Close()
    End Sub

    Private Sub ChangeOptions(Visibility As Boolean, ModifyValues As Boolean)
        'If Done button has been pressed
        If ModifyValues = True Then
            'Get Selected Options
            selectedLogin = cbLogin.SelectedItem
            gamePath = txtPath.Text
            gameLanguage = cbLanguage.SelectedItem
            newSize = cbSize.SelectedItem

            'Write Selected Options in Config
            File.Delete(configPath)
            Dim writer As StreamWriter = New StreamWriter(configPath)
            writer.WriteLine("Path=" + gamePath)
            writer.WriteLine("LoginScreen=" + selectedLogin)
            writer.WriteLine("Volume=" + loginVolume.ToString())
            writer.WriteLine("Language=" + gameLanguage)
            writer.WriteLine("WindowSize=" + newSize)
            writer.Close()
        End If

        'Hide/Show Menu
        pbOptionsMenu.Visible = Visibility
        lbLoginSelection.Visible = Visibility
        cbLogin.Visible = Visibility
        pbDone.Visible = Visibility
        lbPath.Visible = Visibility
        txtPath.Visible = Visibility
        pbPath.Visible = Visibility
        lbVolume.Visible = Visibility
        pbVolume.Visible = Visibility
        numVolume.Visible = Visibility
        lblLanguage.Visible = Visibility
        pbLanguage.Visible = Visibility
        cbLanguage.Visible = Visibility
        lblSize.Visible = Visibility
        cbSize.Visible = Visibility
        pbSize.Visible = Visibility

        'Set Values
        txtPath.Text = gamePath
        cbLogin.Text = selectedLogin
        numVolume.Value = loginVolume
        cbLanguage.Text = gameLanguage

        If newSize <> currentSize Then 'If the size has been changed, we want to change the size and nothing else
            ChangeSize()
        Else
            If ModifyValues = True Then
                StartVideo()
            End If
        End If
    End Sub

    Private Sub StartVideo()
        Dim selectedLoginURL As String
        If selectedLogin = "Current" Then
            selectedLoginURL = "Samira"
        Else
            selectedLoginURL = selectedLogin
        End If

        filePath = Application.StartupPath + "\LoginScreens\" + selectedLoginURL + ".mp4"
        wmpLogin.uiMode = "none"
        wmpLogin.stretchToFit = True
        'If Not File.Exists(filePath) Then
        'File.WriteAllBytes(filePath, My.Resources.Lillia)
        'End If
        wmpLogin.settings.volume = loginVolume

        If filePath <> wmpLogin.URL Then
            'A "low size (online) version" is possible by selecting the login screens directly from GitHub download.
            'This low size version will be slower for slow connection users though.
            wmpLogin.URL = filePath
            wmpLogin.Ctlcontrols.play()
        End If

        videoStarted = True
    End Sub

    Private Sub ChangeSize()
        If newSize = "Normal" Then
            frmMain.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lblSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSignIn.LinkClicked
        Process.Start("https://recovery.riotgames.com/en?region=NA1")
    End Sub

    Private Sub lblCreate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreate.LinkClicked
        Process.Start("https://signup.na.leagueoflegends.com/en/signup/index#/")
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SignIn()
        End If
    End Sub

    Private Sub lblVaank_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblVaank.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCkkTTVsztYaqPTcZAgnt0Xg")
    End Sub

    Private Sub numVolume_ValueChanged(sender As Object, e As EventArgs) Handles numVolume.ValueChanged
        loginVolume = numVolume.Value
        If videoStarted = True Then
            wmpLogin.settings.volume = loginVolume
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/IgnacioRolon/LeagueLoginScreen/releases")
    End Sub



    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles panMove.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub

    Private Sub wmpLogin_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles wmpLogin.PlayStateChange
        If e.newState = 8 Then
            wmpLogin.URL = filePath
            wmpLogin.Ctlcontrols.play()
        End If
    End Sub

    Private Sub txtPath_Click(sender As Object, e As EventArgs) Handles txtPath.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Select your LeagueClient.exe"
        fd.InitialDirectory = "C:\"
        fd.Filter = "LeagueClient.exe|LeagueClient.exe"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txtPath.Text = fd.FileName
        End If
    End Sub

    Private Sub signTimer_Tick(sender As Object, e As EventArgs) Handles signTimer.Tick
        ChangeSignIn()
        signTimer.Stop()
    End Sub

    Private Sub pbDone_Click(sender As Object, e As EventArgs) Handles pbDone.Click
        ChangeOptions(False, True)
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ChangeSize()
    End Sub
End Class
