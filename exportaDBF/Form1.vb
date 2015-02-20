Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.Data.Odbc
Imports Aspose.Cells

Public Class Form1
    Private Sub btnDBF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDBF.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Archivo DBF (*.DBF)|*.dbf|Archivo Excel (*.xls)|*.xls*"
        OpenFileDialog1.ShowDialog()
        txtDBF.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOUT.Click
        SaveFileDialog1.FileName = "salida"
        SaveFileDialog1.Filter = "Archivo de texto (*.TXT)|*.txt"
        SaveFileDialog1.DefaultExt = ".txt"
        SaveFileDialog1.ShowDialog()
        txtOUT.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Cursor = Cursors.WaitCursor
        Dim sdoc, nDias As Integer
        Dim sNombre, scod, sCodPostal, sDomicilio, sLocalidad, sProvincia As String
        If chkCopppel.Checked Or chkNaldo.Checked Then
            Dim license As License = New License()
            license.SetLicense(System.AppDomain.CurrentDomain.BaseDirectory() & "License.config")
            Dim wb As New Workbook
            wb.Open(txtDBF.Text)
            Dim sheet As Worksheet = wb.Worksheets(0)
            Dim y As Integer = 2
            Dim archOut As New System.IO.StreamWriter(txtOUT.Text)
            If chkCopppel.Checked Then
                archOut.WriteLine("MOROSOSSIISAV3")

                While ((Not (sheet.Cells(y, 0).Value Is Nothing)) AndAlso sheet.Cells(y, 0).Value <> "") _
                    Or ((Not (sheet.Cells(y + 1, 0).Value Is Nothing)) AndAlso sheet.Cells(y + 1, 0).Value <> "")
                    If (Not sheet.Cells(y, 0).Value Is Nothing) AndAlso (Not sheet.Cells(y, 1).Value Is Nothing) AndAlso sheet.Cells(y, 1).Value.ToString.Length < 9 Then
                        sdoc = sheet.Cells(y, 1).Value
                        sNombre = sheet.Cells(y, 0).Value
                        If sNombre.Length > 25 Then sNombre = sNombre.Substring(0, 25)
                        scod = "0"
                        Dim fechIngreso As New Date(sheet.Cells(y, 8).Value.ToString.Substring(0, 4), sheet.Cells(y, 8).Value.ToString.Substring(4, 2), sheet.Cells(y, 8).Value.ToString.Substring(6, 2))
                        If fechIngreso.Year < 1901 Or fechIngreso.Year > 2020 Then
                            fechIngreso = Now()
                        End If
                        Dim diferencia As Int32 = DateDiff(DateInterval.Day, fechIngreso, Now())
                        Select Case diferencia
                            Case Is < 31
                                scod = 1
                                Exit Select
                            Case Is < 91
                                scod = 2
                                Exit Select
                            Case Is < 121
                                scod = 3
                                Exit Select
                            Case Is > 120
                                scod = 4
                        End Select
                        sCodPostal = sheet.Cells(y, 14).Value
                        sDomicilio = sheet.Cells(y, 9).Value & " " & sheet.Cells(y, 10).Value & IIf(sheet.Cells(y, 11).Value = "0", "", " piso " & sheet.Cells(y, 11).Value) & ", " & sheet.Cells(y, 12).Value
                        If sDomicilio.Length > 50 Then sDomicilio = sDomicilio.Substring(0, 50)
                        sLocalidad = sheet.Cells(y, 12).Value
                        If (Not sLocalidad Is Nothing) AndAlso sLocalidad.Length > 25 Then sLocalidad = sLocalidad.Substring(0, 25)
                        sProvincia = sheet.Cells(y, 13).Value
                        Dim sCuil As String = "00000000000"
                        Dim sCapital As String = sheet.Cells(y, 6).Value
                        Dim sInteres As String = "00000"
                        Dim sFechaMora As String = Format(fechIngreso, "yyyyMMdd")
                        Dim sOrigen As String = "00"
                        Dim sTel As String = sheet.Cells(y, 19).Value
                        If sTel = "0" Then sTel = ""
                        'archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                        'archOut.Write(FillWithChar(sNombre, 25, False, " "))
                        'archOut.Write(scod)
                        'archOut.Write("00000000000")
                        'archOut.Write(FillWithChar(sCodPostal, 4, False, " "))
                        'archOut.Write("          ")
                        'archOut.Write(FillWithChar(sDomicilio, 110, False, " "))
                        archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                        archOut.Write(FillWithChar(sNombre, 25, True, " "))
                        archOut.Write(sCuil)
                        archOut.Write(FillWithChar(sCapital, 5, False, "0"))
                        archOut.Write(sInteres)
                        archOut.Write(sFechaMora)
                        archOut.Write(sOrigen)
                        archOut.Write(FillWithChar(sTel, 15, True, " "))
                        archOut.Write(FillWithChar(sDomicilio, 50, True, " "))
                        archOut.Write(FillWithChar(sCodPostal, 8, True, " "))
                        archOut.WriteLine()
                    End If
                    y += 1
                End While
            Else
                y = 0
                archOut.WriteLine("MOROSOSSIISAV3")

                While Not (sheet.Cells(y, 0).Value Is Nothing)
                    If sheet.Cells(y, 0).Value <> "LOCALIDAD" Then
                        sdoc = sheet.Cells(y, 2).Value
                        sNombre = sheet.Cells(y, 1).Value
                        If sNombre.Length > 25 Then sNombre = sNombre.Substring(0, 25)
                        scod = "0"

                        sCodPostal = ""
                        sDomicilio = sheet.Cells(y, 3).Value & " " & sheet.Cells(y, 4).Value & " , BUENOS AIRES"
                        If sDomicilio.Length > 50 Then sDomicilio = sDomicilio.Substring(0, 50)
                        sLocalidad = sheet.Cells(y, 0).Value
                        If (Not sLocalidad Is Nothing) AndAlso sLocalidad.Length > 25 Then sLocalidad = sLocalidad.Substring(0, 25)
                        sProvincia = "BUENOS AIRES"
                        Dim sCuil As String = "00000000000"
                        Dim sCapital As String = "00000"
                        Dim sInteres As String = "00000"
                        Dim sFechaMora As String = "00000000"
                        Dim sOrigen As String = "00"
                        Dim sTel As String = ""
                        archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                        archOut.Write(FillWithChar(sNombre, 25, True, " "))
                        archOut.Write(sCuil)
                        archOut.Write(FillWithChar(sCapital, 5, False, "0"))
                        archOut.Write(sInteres)
                        archOut.Write(sFechaMora)
                        archOut.Write(sOrigen)
                        archOut.Write(FillWithChar(sTel, 15, True, " "))
                        archOut.Write(FillWithChar(sDomicilio, 50, True, " "))
                        archOut.Write(FillWithChar(sCodPostal, 8, True, " "))
                        archOut.WriteLine()
                    End If
                    y += 1
                End While
            End If
            archOut.Close()
        Else
            If txtDBF.Text = "" Or txtOUT.Text = "" Then Exit Sub
            Dim dbfPath As String = IO.Path.GetDirectoryName(txtDBF.Text)
            Dim dbfFile As String = IO.Path.GetFileNameWithoutExtension(txtDBF.Text)
            Dim oCmd As New OdbcCommand
            Dim oDr As OdbcDataReader
            Dim archOut As New System.IO.StreamWriter(txtOUT.Text)
            oCmd.CommandType = CommandType.Text
            oCmd.Connection = ConnectDBF(dbfPath)
            oCmd.CommandText = "select * from " & dbfFile
            oDr = oCmd.ExecuteReader

            If chk557.Checked Or chkEico.Checked Then
                archOut.WriteLine("MOROSOSSIISAV3")
            End If

            While oDr.Read
                If False Then
                    If IsNumeric(oDr!dni) Then
                        sdoc = oDr!dni
                        sNombre = oDr!apellido.ToString.Substring(0, 25).Trim
                        scod = "0"
                        'nDias = DateDiff("d", oDr!Fe_ingreso, Now)
                        'If nDias <= 60 Then
                        '    scod = "1"
                        'ElseIf nDias <= 90 Then
                        '    scod = "2"
                        'ElseIf nDias <= 120 Then
                        '    scod = "3"
                        'Else
                        '    scod = "4"
                        'End If
                        sCodPostal = ""
                        sDomicilio = oDr!direccion.ToString.Trim '.ToString.Substring(0, 50)
                        sLocalidad = oDr!Localidad.ToString.Trim '.ToString.Substring(0, 25)
                        sProvincia = ""
                        archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                        archOut.Write(FillWithChar(sNombre, 25, False, " "))
                        archOut.Write(scod)
                        archOut.WriteLine()
                    End If
                Else
                    If chkEico.Checked Then
                        If IsNumeric(oDr!dni) Then
                            sdoc = oDr!dni
                            sNombre = (oDr!apellido).ToString.Substring(0, 25).Trim
                            scod = "0"
                            Dim fechIngreso As Date = oDr!fe_ingreso
                            If fechIngreso.Year < 1901 Or fechIngreso.Year > 2020 Then
                                fechIngreso = Now()
                            End If
                            Dim diferencia As Int32 = DateDiff(DateInterval.Day, fechIngreso, Now())
                            Select Case diferencia
                                Case Is < 31
                                    scod = 1
                                    Exit Select
                                Case Is < 91
                                    scod = 2
                                    Exit Select
                                Case Is < 121
                                    scod = 3
                                    Exit Select
                                Case Is > 120
                                    scod = 4
                            End Select
                            sCodPostal = ""
                            sDomicilio = oDr!direccion.ToString.Trim & ", " & oDr!localidad.Trim & ", Buenos Aires"
                            If sDomicilio.Length > 50 Then sDomicilio = sDomicilio.Substring(0, 50)
                            sLocalidad = oDr!localidad.ToString.Trim
                            If sLocalidad.Length > 25 Then sLocalidad = sLocalidad.Substring(0, 25)
                            sProvincia = ""
                            Dim sCuil As String = "00000000000"
                            Dim sCapital As String = "00000"
                            Dim sInteres As String = "00000"
                            Dim sFechaMora As String = Format(fechIngreso, "yyyyMMdd")
                            Dim sOrigen As String = "00"
                            Dim sTel As String = "               "
                            'archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                            'archOut.Write(FillWithChar(sNombre, 25, False, " "))
                            'archOut.Write(scod)
                            'archOut.Write("00000000000")
                            'archOut.Write(FillWithChar(sCodPostal, 4, False, " "))
                            'archOut.Write("          ")
                            'archOut.Write(FillWithChar(sDomicilio, 110, False, " "))
                            archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                            archOut.Write(FillWithChar(sNombre, 25, False, " "))
                            archOut.Write(sCuil)
                            archOut.Write(sCapital)
                            archOut.Write(sInteres)
                            archOut.Write(sFechaMora)
                            archOut.Write(sOrigen)
                            archOut.Write(sTel)
                            archOut.Write(FillWithChar(sDomicilio, 50, False, " "))
                            archOut.Write(FillWithChar(sCodPostal, 8, False, " "))
                            archOut.WriteLine()
                        End If
                    ElseIf chk557.Checked Then
                        sdoc = oDr!NRO_DOCUME
                        sNombre = oDr!AYN.ToString.Substring(0, 25).Trim
                        Dim sCuil As String = "00000000000"
                        Dim sCapital As String = "00000"
                        Dim sInteres As String = "00000"
                        Dim sFechaMora As String = oDr!FEC_MORA.ToString.Substring(6, 4) & oDr!FEC_MORA.ToString.Substring(3, 2) & oDr!FEC_MORA.ToString.Substring(0, 2)
                        nDias = oDr!D_ATRASO
                        If nDias <= 60 Then
                            scod = "1"
                        ElseIf nDias <= 90 Then
                            scod = "2"
                        ElseIf nDias <= 120 Then
                            scod = "3"
                        Else
                            scod = "4"
                        End If
                        Dim sOrigen As String = "00"
                        Dim sTel As String = "               "
                        sCodPostal = oDr!CPOSTAL.ToString.Trim
                        If sCodPostal.Length > 8 Then
                            sCodPostal = sCodPostal.Substring(0, 8)
                        End If
                        sDomicilio = oDr!DOMICILIO.ToString.Trim
                        If sDomicilio.Length > 50 Then sDomicilio = sDomicilio.Substring(0, 50)
                        sLocalidad = oDr!LOCALIDAD.ToString.Trim
                        If sLocalidad.Length > 25 Then sLocalidad = sLocalidad.Substring(0, 25)
                        sProvincia = oDr!PROVINCIA
                        archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                        archOut.Write(FillWithChar(sNombre, 25, False, " "))
                        archOut.Write(sCuil)
                        archOut.Write(sCapital)
                        archOut.Write(sInteres)
                        archOut.Write(sFechaMora)
                        archOut.Write(sOrigen)
                        archOut.Write(sTel)
                        archOut.Write(FillWithChar(sDomicilio, 50, False, " "))
                        archOut.Write(FillWithChar(sCodPostal, 8, False, " "))
                        archOut.WriteLine()
                    ElseIf IsNumeric(oDr!NRO_DOCUME) Then
                        sdoc = oDr!NRO_DOCUME
                        sNombre = oDr!AYN.ToString.Substring(0, 25).Trim
                        'nDias = oDr!D_ATRASO
                        'If nDias <= 60 Then
                        '    scod = "1"
                        'ElseIf nDias <= 90 Then
                        '    scod = "2"
                        'ElseIf nDias <= 120 Then
                        '    scod = "3"
                        'Else
                        '    scod = "4"
                        'End If
                        scod = "0"
                        sCodPostal = oDr!CPOSTAL
                        sDomicilio = oDr!DOMICILIO.ToString.Trim
                        If sDomicilio.Length > 50 Then sDomicilio = sDomicilio.Substring(0, 50)
                        sLocalidad = oDr!LOCALIDAD.ToString.Trim
                        If sLocalidad.Length > 25 Then sLocalidad = sLocalidad.Substring(0, 25)
                        sProvincia = oDr!PROVINCIA
                        archOut.Write(FillWithChar(sdoc.ToString, 8, False, "0"))
                        archOut.Write(FillWithChar(sNombre, 25, False, " "))
                        archOut.Write(scod)
                        archOut.Write("00000000000")
                        archOut.Write(FillWithChar(sCodPostal, 4, False, " "))
                        archOut.Write("          ")
                        archOut.Write(FillWithChar(sDomicilio, 110, False, " "))
                        archOut.WriteLine()
                    End If
                End If
            End While
            oDr.Close()
            archOut.Close()

            oCmd.Connection.Close()
        End If
        Cursor = Cursors.Default
        MsgBox("Proceso finalizado con éxito")
    End Sub

    Function connect(ByRef path As String) As OdbcConnection
        Dim con As New OdbcConnection
        con.ConnectionString = "Driver={Microsoft Visual FoxPro Driver}; SourceType=DBF; SourceDB=" & path & ";"
        con.Open()
        Return con
    End Function

    Private Function ConnectDBF(ByRef path As String) As System.Data.Odbc.OdbcConnection
        Dim ConnectionString As String
        Dim dBaseConnection As New System.Data.Odbc.OdbcConnection

        Try
            'ConnectionString = "User ID=;DSN=;Collating Sequence=MACHINE;Data Source=""" & FolderBrowserDialog1.SelectedPath & """;Password=;Provider=""VFPOLEDB.1"";Cache Authentication=False;Mask Password=False;Mode=Share Deny None;Extended Properties=;Encrypt Password=False"
            ConnectionString = "Driver={Microsoft Visual FoxPro Driver}; SourceType=DBF; SourceDB=" & path & ";"
            dBaseConnection = New System.Data.Odbc.OdbcConnection(ConnectionString)
            dBaseConnection.Open()
            Return dBaseConnection
        Catch ex As Exception
            MsgBox(ex.Source & " - " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Function

    Public Function FillWithChar(ByVal cTexto As String, ByVal nLong As Integer, ByVal der As Boolean, ByVal fill As String) As String
        Dim contador As Integer = cTexto.Length
        If der Then
            While contador < nLong
                cTexto = cTexto & fill
                contador = contador + 1
            End While
        Else
            While contador < nLong
                cTexto = fill & cTexto
                contador = contador + 1
            End While
        End If
        Return cTexto
    End Function

End Class
