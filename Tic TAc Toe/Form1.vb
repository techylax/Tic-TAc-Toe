
Public Class Form1

    Public ply1, ply2 As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Tic Tac Toe Game by Techylax")
        ply1 = InputBox("Enter Name of Player 1 ", "Name of Player 1")
        ply2 = InputBox("Enter Name of Player 2 ", "Name of Player 2")
        If ply1 = "" Then
            ply1 = "Player 1"
            ply2 = "Player 2"
        End If
        Label1.Text = ply1 + Label1.Text
        Label2.Text = ply2 + Label2.Text
        Label3.Text = ply1 + Label3.Text
        Label4.Text = ply2 + Label4.Text
        Label2.Visible = False

    End Sub
    Private Sub txt_chk()
        'Player 1's Win chnces
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            MsgBox("Congratulation " & ply2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
            'Player2's Win Chances
        ElseIf (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            MsgBox("Congratulation " & ply1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label1.Visible = True Then
            Button1.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button1.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label1.Visible = True Then
            Button2.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button2.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button2.Enabled = False

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Label1.Visible = True Then
            Button3.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button3.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button3.Enabled = False

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Label1.Visible = True Then
            Button4.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button4.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button4.Enabled = False

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Label1.Visible = True Then
            Button5.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button5.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button5.Enabled = False

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Label1.Visible = True Then
            Button6.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button6.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button6.Enabled = False

    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Label1.Visible = True Then
            Button7.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button7.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button7.Enabled = False

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Label1.Visible = True Then
            Button8.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button8.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button8.Enabled = False

    End Sub



    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Label1.Visible = True Then
            Button9.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            Button9.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000

        End If

50000:  Button9.Enabled = False

    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button1.Enabled = True
        Button2.Text = ""
        Button2.Enabled = True
        Button3.Text = ""
        Button3.Enabled = True
        Button4.Text = ""
        Button4.Enabled = True
        Button5.Text = ""
        Button5.Enabled = True
        Button6.Text = ""
        Button6.Enabled = True
        Button7.Text = ""
        Button7.Enabled = True
        Button8.Text = ""
        Button8.Enabled = True
        Button9.Text = ""
        Button9.Enabled = True
      
    End Sub


    Private Sub PictureBox36_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox36.Click
        Process.Start("https://github.com/techylax")
    End Sub
End Class



