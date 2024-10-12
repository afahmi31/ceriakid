Imports Newtonsoft.Json.Linq
Imports System.Media

Public Class FrmScanner
    Dim WebUri As String = "https://app.ceriakid.id/api"
    Public Property user As LoginResult


    Private Sub FrmScanner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmScanner_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        x.logOut()
        x.Show()
    End Sub

    Private Sub inputScanner_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inputScanner.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            MetroProgressBar1.Visible = True
            MetroPanel1.Enabled = False
            MetroLabel1.Text = "Barcode " + inputScanner.Text + vbNewLine

            Dim PostData = ""
            Dim resp As Chilkat.HttpResponse
            Dim jsonText As String = ""

            Dim http As New Chilkat.Http
            http.SetRequestHeader("Accept", "application/json")
            http.AuthToken = user.token
            resp = http.PostJson2(WebUri + "/order/create?order_no=" + inputScanner.Text, "application/json", jsonText)


            If (http.LastMethodSuccess <> True) Then
                MetroProgressBar1.Visible = False
                MetroPanel1.Enabled = True
                inputScanner.SelectAll()
                inputScanner.Focus()
                Debug.WriteLine(http.LastErrorText)
                MsgBox("Failed Connect To Server", MsgBoxStyle.Critical, "Error Connection")
                Exit Sub
            Else
                MetroProgressBar1.Visible = False
                MetroPanel1.Enabled = True
                inputScanner.Text = ""
                inputScanner.Focus()
                Dim ser As JObject = JObject.Parse(resp.BodyStr)
                Dim success As String = ""
                Dim messages As String = ""

                success = ser.Item("success")
                messages = ser.Item("messages")
                If success.Contains("False") Then
                    Dim notifi As New SoundPlayer(My.Resources.nightlife)
                    notifi.Play()
                    notifi.Dispose()
                End If

                MetroLabel1.Text = MetroLabel1.Text + vbNewLine + messages
            End If
        End If
    End Sub
End Class