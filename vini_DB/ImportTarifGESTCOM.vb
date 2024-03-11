Imports Microsoft.Office.Interop
Imports vini_DB
Imports System.IO

Public Class ImportTarifGESTCOM
    Inherits Observable

    Private m_FileName As String
    Private m_numColTarifA As Integer
    Private m_numColTarifB As Integer
    Private m_numColTarifC As Integer
    Private m_numColTarifD As Integer
    Private m_numColCode As Integer
    Public Sub New(pFileName As String, pNumColCode As Integer, pNumColTarifA As Integer, pNumColTarifB As Integer, pNumColTarifC As Integer, pNumColTarifD As Integer)
        m_FileName = pFileName
        m_numColCode = pNumColCode - 1
        m_numColTarifA = pNumColTarifA - 1
        m_numColTarifB = pNumColTarifB - 1
        m_numColTarifC = pNumColTarifC - 1
        m_numColTarifD = pNumColTarifD - 1

    End Sub
    Public Overrides ReadOnly Property shortResume As String
        Get
            Return "Import Tarif Gestcom"
        End Get
    End Property

    Private _Message As String
    Public Property message() As String
        Get
            Return _Message
        End Get
        Set(ByVal value As String)
            _Message = value
        End Set
    End Property
    Public Function getNbreLignes() As Integer
        Dim nReturn As Integer = 0
        Dim nFile As Integer
        Dim strLine As String

        Try
            If IO.File.Exists(m_FileName) Then
                nFile = FreeFile()
                FileOpen(nFile, m_FileName, OpenMode.Input, OpenAccess.Read)
                'Calcul du nombre de lignes à traiter
                Dim bPremiereLigneLue As Boolean = False
                While Not EOF(nFile)
                    If Not bPremiereLigneLue Then
                        bPremiereLigneLue = True
                    Else
                        nReturn = nReturn + 1
                        strLine = LineInput(nFile)

                    End If
                End While
                FileClose(nFile)
            End If

        Catch ex As Exception
            nReturn = 0
        End Try
        Return nReturn
    End Function
    Public Function ImportTarif() As Boolean
        Dim bReturn As Boolean = False
        Dim nFile As Integer
        Dim strLine As String
        Dim tab As String()
        Dim nRow As Integer = 0
        Try
            If IO.File.Exists(m_FileName) Then
                nFile = FreeFile()
                FileOpen(nFile, m_FileName, OpenMode.Input, OpenAccess.Read)
                'Calcul du nombre de lignes à traiter
                Dim bPremiereLigneLue As Boolean = False
                While Not EOF(nFile)
                    If Not bPremiereLigneLue Then
                        bPremiereLigneLue = True
                    Else
                        nRow = nRow + 1
                        strLine = LineInput(nFile)

                        tab = strLine.Split(";")
                        If Not String.IsNullOrEmpty(tab(m_numColCode)) Then
                            Me.message = tab(m_numColCode)
                            Notifier()
                            Dim oProduit As Produit
                            oProduit = Produit.createandloadbyKey(tab(m_numColCode), pbLoadByCodeStat:=True)

                            If oProduit IsNot Nothing Then
                                Try
                                    Dim tarif As Decimal
                                    If m_numColTarifA <> -1 Then
                                        tarif = Convert.ToDecimal(tab(m_numColTarifA).Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                        oProduit.TarifA = tarif
                                    End If
                                    If m_numColTarifB <> -1 Then
                                        tarif = Convert.ToDecimal(tab(m_numColTarifB).Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                        oProduit.TarifB = tarif
                                    End If
                                    If m_numColTarifC <> -1 Then
                                        tarif = Convert.ToDecimal(tab(m_numColTarifC).Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                        oProduit.TarifC = tarif
                                    End If
                                    If m_numColTarifD <> -1 Then
                                        tarif = Convert.ToDecimal(tab(m_numColTarifD).Replace(",", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(".", System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                                        oProduit.TarifD = tarif
                                    End If
                                    oProduit.save()
                                    Me.message = "Ligne " & nRow & ":" & oProduit.code
                                Catch ex As Exception
                                    setError("ImportTarifGestCom.importTarif ERR " & ex.Message)
                                End Try
                            End If

                        End If
                    End If
                End While
                FileClose(nFile)


            End If
        Catch ex As Exception
            bReturn = False
        End Try
        Return bReturn
    End Function



End Class
