Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class x

    Dim WebUri As String = "https://app.ceriakid.id/api"
    Dim userToken As LoginResult

    Public Sub logOut()
        userToken = New LoginResult
    End Sub

    Private Sub inputPassword_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputPassword.ButtonClick
        If inputPassword.PasswordChar = "*" Then
            inputPassword.PasswordChar = ""
        Else
            inputPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        MetroProgressBar1.Visible = True

        Dim PostLogin = "/login?email=" + inputEmail.Text + "&password=" + inputPassword.Text

        Dim http As New Chilkat.Http
        http.SetRequestHeader("Accept", "application/json")
        Dim resp As Chilkat.HttpResponse
        Dim jsonText As String = ""
        resp = http.PostJson2(WebUri + PostLogin, "application/json", jsonText)


        If (http.LastMethodSuccess <> True) Then
            MetroProgressBar1.Visible = False
            Debug.WriteLine(http.LastErrorText)
            MsgBox(http.LastErrorText.ToString, MsgBoxStyle.Critical, "Error Connection")
            Exit Sub
        Else
            MetroProgressBar1.Visible = False
            ' Display the JSON response.
            Debug.WriteLine(resp.BodyStr)

            userToken = New LoginResult

            Dim ser As JObject = JObject.Parse(resp.BodyStr)

            If ser.ContainsKey("success") Then
                userToken.success = ser.Item("success")
            End If



            If userToken.success = False Then
                If ser.ContainsKey("messages") Then
                    userToken.messages = ser.Item("messages")
                End If
                MessageBox.Show(userToken.messages)
                Exit Sub
            Else
                inputEmail.Text = ""
                inputPassword.Text = ""
                If ser.ContainsKey("token") Then
                    userToken.token = ser.Item("token").Item("token")
                End If

                Dim ScannerForm As New FrmScanner
                ScannerForm.user = userToken
                ScannerForm.Show()
                Me.Hide()
            End If

            jsonText = ""
            http.SetRequestHeader("Accept", "application/json")
            http.AuthToken = userToken.token
            resp = http.PostJson2(WebUri + "/order?page=1", "application/json", jsonText)


            If (http.LastMethodSuccess <> True) Then
                Debug.WriteLine(http.LastErrorText)
                MsgBox(http.LastErrorText.ToString, MsgBoxStyle.Critical, "Error Connection")
            Else
                ' Display the JSON response.
                Debug.WriteLine(resp.BodyStr)

            End If

        End If
    End Sub


    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MetroProgressBar1.Visible = False
    End Sub
End Class
