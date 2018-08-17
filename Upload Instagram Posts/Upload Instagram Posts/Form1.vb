Imports System.IO
Imports System.Text
Imports System.Net

Public Class Form1
    Private pic() As Byte
    Dim cs, csrftoken As String

    Private Function timestamp() As String
        Dim micro = Split(((DateTime.Now - New DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds), ".")
        Return micro(0)
    End Function
    Private Function upload(ByVal time As String, ByVal pic As String, ByVal cookie As String, ByVal csrftoken As String, ByVal caption As String) As Boolean
        Try
            ServicePointManager.CheckCertificateRevocationList = False
            ServicePointManager.DefaultConnectionLimit = 300
            ServicePointManager.UseNagleAlgorithm = False
            ServicePointManager.Expect100Continue = False

            Using wc As New WebClient


                wc.Headers.Add("User-Agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1")
                wc.Headers.Add("Accept: */*")
                wc.Headers.Add("accept-language: en-US,en;q=0.5")
                wc.Headers.Add("Cookie", cookie)
                wc.Headers.Add("Content-Type: multipart/form-data; boundary=---------------------------" & time)
                wc.Headers.Add("x-csrftoken", csrftoken)
                wc.Headers.Add("x-instagram-ajax: 1")
                wc.Headers.Add("x-requested-with: XMLHttpRequest")


                Dim sb As New StringBuilder
                sb.AppendLine("-----------------------------" & time)
                sb.AppendLine("Content-Disposition: form-data; name=""upload_id""")
                sb.AppendLine("")
                sb.AppendLine(time)
                sb.AppendLine("-----------------------------" & time)
                sb.AppendLine("Content-Disposition: form-data; name=""photo""; filename=""photo.jpg""")
                sb.AppendLine("Content-Type: image/jpeg")
                sb.AppendLine("")
                sb.AppendLine(pic)
                sb.AppendLine("-----------------------------" & time)
                sb.AppendLine("Content-Disposition: form-data; name=""media_type""")
                sb.AppendLine("1")
                sb.AppendLine("-----------------------------" & time & "--")



                wc.UploadString("https://www.instagram.com/create/upload/photo/", sb.ToString)

            End Using

            Using wc2 As New WebClient


                wc2.Headers.Add("User-Agent", ": Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1")
                wc2.Headers.Add("Accept: */*")
                wc2.Headers.Add("accept-language: en-US,en;q=0.5")
                wc2.Headers.Add("Cookie", cookie)
                wc2.Headers.Add("Content-Type: application/x-www-form-urlencoded")
                wc2.Headers.Add("x-csrftoken", csrftoken)
                wc2.Headers.Add("x-instagram-ajax: 1")
                wc2.Headers.Add("x-requested-with: XMLHttpRequest")


                wc2.UploadString("https://www.instagram.com/create/configure/", "upload_id=" & time & "&caption=" & caption)

            End Using

            Return True
        Catch ex As WebException
            Return False
        End Try
    End Function

    Private Function Login(ByVal username As String, ByVal password As String) As Boolean
        Try

            Dim request As HttpWebRequest = HttpWebRequest.Create("https://www.instagram.com/accounts/login/ajax/")
            request.CookieContainer = New CookieContainer
            request.Method = "POST"
            request.Accept = "*/*"
            request.UserAgent = "Mozilla/5.0 (iPhone; CPU iPhone OS 12_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1"
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8"
            request.Headers.Add("X-CSRFToken", "missing")
            request.Headers.Add("Accept-Language", ": ar,en-US;q=0.9,en;q=0.8")
            request.Headers.Add("X-Requested-With: XMLHttpRequest")



            Dim postData As String = "username=" & username & "&password=" & password
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As HttpWebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()


            For Each cookie In response.Cookies
                If Not cookie.ToString = "csrftoken=""""" Then If cookie.ToString.Contains("csrftoken") Then csrftoken = cookie.ToString.Replace("csrftoken=", "")
                cs += cookie.ToString & ";"
            Next

            If responseFromServer.Contains("authenticated"": false") Then Return False Else Return True
        Catch ex As WebException
            Return False
        End Try
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ImportImageButton.Click
        Dim op As New OpenFileDialog
        op.Filter = "JPG|*.jpg"
        If op.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(op.FileName)
            pic = File.ReadAllBytes(op.FileName)
            CaptionGroupBox.Enabled = True
        End If
    End Sub

  
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If Login(UsernameTextBox.Text, PasswordTextBox.Text) = True Then
            ImageGroupBox.Enabled = True
        Else
            MsgBox("Username/Password incorrect", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub PostButton_Click(sender As Object, e As EventArgs) Handles PostButton.Click
        If upload(timestamp(), Encoding.Default.GetString(pic), cs, csrftoken, (CaptionTextBox.Text).Replace(vbCrLf, "%0A.%0A").Replace(" ", "+")) Then
            MsgBox("Your post has been uploaded", MsgBoxStyle.Information)
        Else
            MsgBox("Can't upload the post", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
