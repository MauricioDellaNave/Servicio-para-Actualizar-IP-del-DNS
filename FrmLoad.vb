Imports FrmACservice
Imports System.Net
Imports System.IO
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class FrmLoad

    Dim VariableFiltrada As String

#Region "Funciones y Metodos"

    Public Sub CrearHTML()
        TextBox1.Text = "<HTML><HEAD></HEAD><META HTTP-EQUIV=REFRESH CONTENT=""0; URL=http://PUBLICA:88""><BODY><center>Un momento por favor...</center><center><A HREF=""http://PUBLICA:88"">Haga click aquí si esta página no cambia...</a></center></BODY></HTML>"
        TextBox2.Text = TextBox1.Text.Replace("PUBLICA", txtIPPublica.Text)
        ' MsgBox(sourcecode.Split)

        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String

        Try

            If Directory.Exists("C:\DNSGratis") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory("C:\DNSGratis")
            End If

            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = "C:\DNSGratis\redir" & ".html"

            'verificamos si existe el archivo

            If File.Exists(PathArchivo) Then
                strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
            Else
                strStreamW = File.Create(PathArchivo) ' lo creamos
            End If

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura


            'escribimos en el archivo

            strStreamWriter.WriteLine(TextBox2.Text)


            strStreamWriter.Close() ' cerramos

        Catch ex As Exception
            MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
            strStreamWriter.Close() ' cerramos
        End Try
    End Sub


    Public Function QuitarCaracteres(ByVal cadena As String, ByVal chars As String)
        Dim i As Integer
        Dim nCadena As String
        ' On Local Error Resume Next 
        'Asignamos valor a la cadena de trabajo para
        'no modificar la que envía el cliente.
        nCadena = cadena
        For i = 1 To Len(chars)
            nCadena = Replace(nCadena, Mid(chars, i, 1), "")
        Next i
        'Devolvemos la cadena tratada
        QuitarCaracteres = nCadena
    End Function


    Function GetExternalIP() As String
        Try
            Dim lol As WebClient = New WebClient()
            Dim str As String = lol.DownloadString("http://checkip.dyndns.org")
            Return str

        Catch a As Exception
            MsgBox("No se pudo establecer conexion")
        End Try
        Return Nothing
    End Function

    Public Sub BuscarIP()
        VariableFiltrada = QuitarCaracteres(GetExternalIP, " :<>{}[]^+,;_-/*?¿!$%&/¨Ññ()='áéíóúÁÉÍÓÚ¡abcdefghijklmnñopqrstuvwxyzCIP A" + Chr(34))
        txtIPPublica.Text = VariableFiltrada
    End Sub

    Public Sub subirFichero()

        Dim miUri As String = "ftp://ftp.acservice.com.ar/public_html/redir.html"
        Dim miRequest As Net.FtpWebRequest = Net.WebRequest.Create(miUri)
        miRequest.Credentials = New Net.NetworkCredential("capetruz", "55fz0z1po0")
        miRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
        Try
            Dim bFile() As Byte = System.IO.File.ReadAllBytes("c:\DNSGratis\redir.html")
            Dim miStream As System.IO.Stream = miRequest.GetRequestStream()
            miStream.Write(bFile, 0, bFile.Length)
            miStream.Close()
            miStream.Dispose()
            MsgBox("Su direccion IP Publica ha sido actualizada", MsgBoxStyle.Information, "Cliente DNS")
        Catch ex As Exception
            Throw New Exception(ex.Message & ". El Archivo no pudo ser enviado.")
        End Try

    End Sub

#End Region

    Private Sub FrmLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuscarIP()
        Fecha.Text = Date.Now
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrearHTML()
        FechaWeb.Text = Date.Now
        subirFichero()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BuscarIP()
        Fecha.Text = Date.Now
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub
End Class
