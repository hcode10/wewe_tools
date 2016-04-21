Option Strict On
Option Explicit On

Public Class Form1

    Dim pin() As Boolean = {False, False, False, False, False, False, False, False, False}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Computer.Network.Ping(TextBox1.Text) Then
            ToolStripStatusLabel1.ForeColor = Color.LightGreen
            get_etats()
        Else
            ToolStripStatusLabel1.ForeColor = Color.Red
        End If
    End Sub

    Sub get_etats()
        Dim wc As New Net.WebClient
        Dim result As String = wc.DownloadString("http://" & TextBox1.Text)
        Dim decoupe As String() = result.Split(CType(";", Char()))
        For Each e As String In decoupe
            Dim array_r As String() = e.Split(CType(":", Char()))
            If array_r(0) = "D0" Then
                set_etats(Pic_D0, Label_D0, CInt(array_r(1)))
                pin(0) = CBool(array_r(1))
            End If
            If array_r(0) = "D1" Then
                set_etats(Pic_D1, Label_D1, CInt(array_r(1)))
                pin(1) = CBool(array_r(1))
            End If
            If array_r(0) = "D2" Then
                set_etats(Pic_D2, Label_D2, CInt(array_r(1)))
                pin(2) = CBool(array_r(1))
            End If
            If array_r(0) = "D3" Then
                set_etats(Pic_D3, Label_D3, CInt(array_r(1)))
                pin(3) = CBool(array_r(1))
            End If
            If array_r(0) = "D4" Then
                set_etats(Pic_D4, Label_D4, CInt(array_r(1)))
                pin(4) = CBool(array_r(1))
            End If
            If array_r(0) = "D5" Then
                set_etats(Pic_D5, Label_D5, CInt(array_r(1)))
            End If
            If array_r(0) = "D6" Then
                set_etats(Pic_D6, Label_D6, CInt(array_r(1)))
            End If
            If array_r(0) = "D7" Then
                set_etats(Pic_D7, Label_D7, CInt(array_r(1)))
            End If
            If array_r(0) = "D8" Then
                set_etats(Pic_D8, Label_D8, CInt(array_r(1)))
                pin(8) = CBool(array_r(1))
            End If
        Next
    End Sub


    Sub set_etats(picture As PictureBox, label_pin As Label, etats As Integer)
        picture.SizeMode = PictureBoxSizeMode.CenterImage
        If etats = 1 Then
            picture.Image = My.Resources.high
            label_pin.ForeColor = Color.LightGreen
        Else
            picture.Image = My.Resources.low
            label_pin.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Pic_D0_Click(sender As Object, e As EventArgs, Optional ByVal etats As String = "") Handles Pic_D0.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If etats = "" Then
            If pin(0) = True Then
                fin = "0"
                pin(0) = False
            ElseIf pin(0) = False Then
                fin = "1"
                pin(0) = True
            End If
        Else
            fin = etats
        End If
        Pic_D0.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D0=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D1_Click(sender As Object, e As EventArgs) Handles Pic_D1.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(1) = True Then
            fin = "0"
            pin(1) = False
        ElseIf pin(1) = False Then
            fin = "1"
            pin(1) = True
        End If
        Pic_D1.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D1=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D2_Click(sender As Object, e As EventArgs) Handles Pic_D2.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(2) = True Then
            fin = "0"
            pin(2) = False
        ElseIf pin(2) = False Then
            fin = "1"
            pin(2) = True
        End If
        Pic_D2.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D2=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D3_Click(sender As Object, e As EventArgs) Handles Pic_D3.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(3) = True Then
            fin = "0"
            pin(3) = False
        ElseIf pin(3) = False Then
            fin = "1"
            pin(3) = True
        End If
        Pic_D3.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D3=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D4_Click(sender As Object, e As EventArgs) Handles Pic_D4.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(4) = True Then
            fin = "0"
            pin(4) = False
        ElseIf pin(4) = False Then
            fin = "1"
            pin(4) = True
        End If
        Pic_D4.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D4=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D5_Click(sender As Object, e As EventArgs) Handles Pic_D5.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(5) = True Then
            fin = "0"
            pin(5) = False
        ElseIf pin(5) = False Then
            fin = "1"
            pin(5) = True
        End If
        Pic_D5.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D5=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D6_Click(sender As Object, e As EventArgs) Handles Pic_D6.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(6) = True Then
            fin = "0"
            pin(6) = False
        ElseIf pin(6) = False Then
            fin = "1"
            pin(6) = True
        End If
        Pic_D6.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D6=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D7_Click(sender As Object, e As EventArgs) Handles Pic_D7.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(7) = True Then
            fin = "0"
            pin(7) = False
        ElseIf pin(7) = False Then
            fin = "1"
            pin(7) = True
        End If
        Pic_D7.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D7=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Pic_D8_Click(sender As Object, e As EventArgs) Handles Pic_D8.Click
        Dim wc As New Net.WebClient
        Dim fin As String = "1"
        If pin(8) = True Then
            fin = "0"
            pin(8) = False
        ElseIf pin(8) = False Then
            fin = "1"
            pin(8) = True
        End If
        Pic_D8.Image = My.Resources.refresh
        Application.DoEvents()
        wc.DownloadString("http://" & TextBox1.Text & "/nawak.php?D8=" & fin)
        wc.Dispose()
        get_etats()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For Each line As String In RichTextBox1.Lines
                Label1.Text = line
                Dim lines() As String = Split(line, ":")

                If lines(0).Substring(0, 1) = "D" Then
                    If (lines(0) = "D0") Then
                        Pic_D0_Click(Nothing, EventArgs.Empty, lines(1).ToString)
                    End If
                    If (lines(0) = "D1") Then
                        Pic_D1_Click(Nothing, EventArgs.Empty)
                    End If
                    If (lines(0) = "D2") Then
                        Pic_D2_Click(Nothing, EventArgs.Empty)
                    End If


                End If
                If lines(0).Substring(0, 2) = "WA" Then
                    delay(CInt(lines(1)))
                    Application.DoEvents()
                End If
            Next

        Catch

        End Try
    End Sub


    Private Sub delay(duree As Integer)
        System.Threading.Thread.Sleep(duree)
    End Sub
End Class