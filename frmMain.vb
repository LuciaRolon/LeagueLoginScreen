Imports System.IO
Imports System.Threading
Public Class frmMain
    Private filePath, selectedLogin As String
    Private configPath, gamePath As String
    Private signInEnabled As Boolean = False
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Configuration Load
        configPath = Application.StartupPath + "\config.cfg"
        LoadConfiguration()

        'Style Definition
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        lblCut.ForeColor = Color.FromArgb(32, 35, 37)
        lblPatch.ForeColor = Color.FromArgb(59, 63, 67)

        'Login Screen Media Loader  
        StartVideo()
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

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        ChangeSignIn()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        ChangeSignIn()
    End Sub

    Private Sub pbSignIn_Click(sender As Object, e As EventArgs) Handles pbSignIn.Click
        SignIn()
    End Sub

    Private Sub ChangeSignIn()
        If txtUser.TextLength > 2 And txtPass.TextLength > 2 Then
            pbSignIn.BackgroundImage = My.Resources.SignInEnabled
            pbSignIn.Cursor = Cursors.Hand
            signInEnabled = True
        Else
            pbSignIn.BackgroundImage = My.Resources.SignInDisabled
            pbSignIn.Cursor = Cursors.Default
            signInEnabled = False
        End If
    End Sub

    Private Sub SignIn()
        If signInEnabled = True Then
            My.Computer.Audio.Play(My.Resources.LoginSound, AudioPlayMode.Background)
            Process.Start("C:\Riot Games\Riot Client\RiotClientServices.exe", "--launch-product=league_of_legends --launch-patchline=live")
            Thread.Sleep(2000)
            Application.Exit()
        End If
    End Sub

    Private Sub LoadConfiguration()
        If Not File.Exists(configPath) Then
            Dim writer As StreamWriter = New StreamWriter(configPath)
            writer.WriteLine("Path=C:\Riot Games\Riot Client\RiotClientServices.exe")
            writer.WriteLine("LoginScreen=Current")
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

        reader.Close()
    End Sub

    Private Sub ChangeOptions(Visibility As Boolean, ModifyValues As Boolean)
        'If Done button has been pressed
        If ModifyValues = True Then
            'Get Selected Options
            selectedLogin = cbLogin.SelectedItem
            gamePath = txtPath.Text

            'Write Selected Options in Config
            File.Delete(configPath)
            Dim writer As StreamWriter = New StreamWriter(configPath)
            writer.WriteLine("Path=" + gamePath)
            writer.WriteLine("LoginScreen=" + selectedLogin)
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
        txtPath.Text = gamePath
        cbLogin.Text = selectedLogin

        If ModifyValues = True Then
            StartVideo()
        End If
    End Sub

    Private Sub StartVideo()
        If selectedLogin = "Current" Then
            selectedLogin = "Lillia"
        End If

        filePath = Application.StartupPath + "\LoginScreens\" + selectedLogin + ".mp4"
        wmpLogin.uiMode = "none"
        wmpLogin.stretchToFit = True
        'If Not File.Exists(filePath) Then
        'File.WriteAllBytes(filePath, My.Resources.Lillia)
        'End If
        wmpLogin.URL = filePath
        wmpLogin.Ctlcontrols.play()
    End Sub

    Private Sub lblSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSignIn.LinkClicked
        Process.Start("https://recovery.riotgames.com/en?region=NA1")
    End Sub

    Private Sub lblCreate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreate.LinkClicked
        Process.Start("https://signup.na.leagueoflegends.com/en/signup/index#/")
    End Sub

    Private Sub lblVaank_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblVaank.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCkkTTVsztYaqPTcZAgnt0Xg")
    End Sub

    Private Sub pbDone_Click(sender As Object, e As EventArgs) Handles pbDone.Click
        ChangeOptions(False, True)
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            SignIn()
        End If
    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            SignIn()
        End If
    End Sub
End Class
