Option Explicit On
Public Class FrmMain

    Dim FartLength As String

    Private Sub PlayFart(Btn As Button)

        LblPic1.Visible = False
        LblPic2.Visible = False
        PicFartImage.Image = Nothing

        PbrFartDuration.Visible = True
        TimFartLength.Enabled = True

        Select Case Btn.Name
            Case "BtnFart1"
                PicFartImage.Image = My.Resources.Fart1
                My.Computer.Audio.Play(My.Resources.Fart, AudioPlayMode.Background)
                FartLength = GetExtendedFileProperty(AppDomain.CurrentDomain.BaseDirectory & "Fart.Wav", "Length")
            Case "BtnFart2"
                PicFartImage.Image = My.Resources.Bean_Fart1
                My.Computer.Audio.Play(My.Resources.Bean_Fart, AudioPlayMode.Background)
                FartLength = GetExtendedFileProperty(AppDomain.CurrentDomain.BaseDirectory & "Bean Fart.wav", "Length")
            Case "BtnFart3"
                PicFartImage.Image = My.Resources.Common_Fart1
                My.Computer.Audio.Play(My.Resources.Common_Fart, AudioPlayMode.Background)
                FartLength = GetExtendedFileProperty(AppDomain.CurrentDomain.BaseDirectory & "Common Fart.wav", "Length")
            Case "BtnFart4"
                PicFartImage.Image = My.Resources.Long_Fart1
                My.Computer.Audio.Play(My.Resources.Long_Fart, AudioPlayMode.Background)
                FartLength = GetExtendedFileProperty(AppDomain.CurrentDomain.BaseDirectory & "Long Fart.wav", "Length")
        End Select

    End Sub

    Private Sub BtnFart1_Click(sender As Object, e As EventArgs) Handles BtnFart1.Click

        PlayFart(BtnFart1)

    End Sub

    Private Sub BtnFart2_Click(sender As Object, e As EventArgs) Handles BtnFart2.Click

        PlayFart(BtnFart2)

    End Sub

    Private Sub BtnFart3_Click(sender As Object, e As EventArgs) Handles BtnFart3.Click

        PlayFart(BtnFart3)

    End Sub

    Private Sub BtnFart4_Click(sender As Object, e As EventArgs) Handles BtnFart4.Click

        PlayFart(BtnFart4)

    End Sub

    Private Sub TimFartLength_Tick(sender As Object, e As EventArgs) Handles TimFartLength.Tick

        Try

            Dim X As Double = 100 / Strings.Right(FartLength, 1)

            TxtCounter.Text += 1
            If PbrFartDuration.Value < 100 Then
                PbrFartDuration.Value = PbrFartDuration.Value + X - 1
            End If

        Catch ex As Exception

        Finally

            If Val(TxtCounter.Text) = Strings.Right(FartLength, 1) Then
                If PbrFartDuration.Value < 100 Then PbrFartDuration.Value = 100
            End If

            If Val(TxtCounter.Text) = Strings.Right(FartLength, 1) + 1 Then
                PicFartImage.Image = Nothing
                LblPic1.Visible = True
                LblPic2.Visible = True
                TimFartLength.Enabled = False
                PbrFartDuration.Value = 0
                TxtCounter.Text = 0
                PbrFartDuration.Visible = False
            End If

        End Try

    End Sub

End Class
