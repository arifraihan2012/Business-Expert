Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class RptPrintBarcode

    Public Function Encode(ByVal chaine As String) As String

        Dim ind As Integer = 1
        Dim checksum As Integer = 0
        Dim mini As Integer
        Dim dummy As Integer
        Dim tableB As Boolean
        Dim code128 As String
        Dim longueur As Integer

        code128 = ""
        longueur = chaine.Length

        If longueur = 0 Then
            Console.WriteLine("\n chaine vide")
        Else
            For ind = 0 To longueur - 1
                If Asc(chaine(ind)) < 32 Or Asc(chaine(ind)) > 126 Then
                    Console.WriteLine("\n chaine invalide")
                End If
            Next
        End If

        tableB = True
        ind = 0

        While ind < longueur

            If tableB = True Then

                If ind = 0 Or (ind + 3) = longueur - 1 Then
                    mini = 4
                Else
                    mini = 6
                End If
                mini = mini - 1

                If (ind + mini) <= (longueur - 1) Then
                    While mini >= 0

                        If Asc(chaine(ind + mini)) < 48 Or Asc(chaine(ind + mini)) > 57 Then
                            Console.WriteLine("\n exit")
                            Exit While
                        End If
                        mini = mini - 1
                    End While
                End If

                If mini < 0 Then
                    If ind = 0 Then
                        code128 = Char.ToString(Chr(205))
                    Else
                        code128 = code128 & Char.ToString(Chr(199))
                    End If
                    tableB = False
                Else

                    If ind = 0 Then
                        code128 = Char.ToString(Chr(204))
                    End If
                End If

            End If

            If tableB = False Then
                mini = 2
                mini = mini - 1
                If (ind + mini) < longueur Then
                    While mini >= 0
                        If Asc(chaine(ind + mini)) < 48 Or Asc(chaine(ind)) > 57 Then
                            Exit While
                        End If
                        mini = mini - 1
                    End While
                End If
                If mini < 0 Then
                    dummy = Int32.Parse(chaine.Substring(ind, 2))
                    Console.WriteLine("\n  dummy ici : " & dummy)
                    If dummy < 95 Then
                        dummy = dummy + 32
                    Else
                        dummy = dummy + 100
                    End If
                    code128 = code128 & Chr(dummy)
                    ind = ind + 2
                Else
                    code128 = code128 & Char.ToString(Chr(200))
                    tableB = True
                End If
            End If


            If tableB = True Then
                code128 = code128 & chaine(ind)
                ind = ind + 1
            End If

        End While

        For ind = 0 To code128.Length - 1
            dummy = Asc(code128(ind))
            Console.WriteLine("\n  et voila dummy : " & dummy)
            If dummy < 127 Then
                dummy = dummy - 32
            Else
                dummy = dummy - 100
            End If
            If ind = 0 Then
                checksum = dummy
            End If
            checksum = (checksum + (ind) * dummy) Mod 103
        Next

        If checksum < 95 Then
            checksum = checksum + 32
        Else
            checksum = checksum + 100
        End If
        code128 = code128 & Char.ToString(Chr(checksum)) & Char.ToString(Chr(206))

        Return code128



    End Function



    Private Sub RptCashFlow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim MyFormName As Form = CType(sender, Form)



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = '" + MyFormName.Text + "' And  [Update Delete Permission]='Yes'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If Not dr.HasRows Then



            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try








    End Sub

   


    Sub ShowInvoice()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table


            Dim CodeBarre As String
            CodeBarre = Encode(TextBox1.Text)

          


            cryRpt.Load("" + FrmHome.ReportLocation + "" & "BarcodePrint.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With

            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")


            cryRpt.SetParameterValue("Product ID", Me.TxtProductID.Text)

            cryRpt.SetParameterValue("NumberToPrint", Me.TextBox1.Text)
            cryRpt.SetParameterValue("Barcode", Encode(Me.TxtBarcode.Text))


            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False


            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

            Next

            cryRpt.PrintOptions.PrinterName = "Xpert Label Printer"
            Me.CrystalReportViewer1.ReportSource = cryRpt


            Me.CrystalReportViewer1.Refresh()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click



        ShowInvoice()

    End Sub
End Class