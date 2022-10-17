Imports System.Collections.Generic
Imports System.IO
Imports System.Xml.Serialization
<Serializable>
Public Class LogImportWooList
    Public ListItems As New List(Of ItemLogImportWoo)
End Class
<Serializable>
Public Class LogImportWoo
    Public Shared Fichier As String = "LOGS/ImportWoo.xml"

    Public Shared ListItems As New LogImportWooList


    Public Shared Sub AjoutLigne(pDateImport As String, pNomFichier As String, pNumWooCmd As String, pDateCmd As String, pImport As Boolean, pCmdCode As String, pMotif As String)
        Dim oItem As New ItemLogImportWoo()
        oItem.DateImport = pDateImport

        oItem.NomFichier = pNomFichier
        oItem.NumCdeWooCommerce = pNumWooCmd
        oItem.datecmd = pDateCmd
        oItem.pImport = pImport
        oItem.CmdCode = pCmdCode
        oItem.motif = pMotif

        ListItems.ListItems.Add(oItem)
    End Sub
    Public Shared Function writeXml() As Boolean
        Dim bReturn As Boolean
        Dim objStreamWriter As StreamWriter = Nothing

        Try
            If Not Directory.Exists("LOGS") Then
                Directory.CreateDirectory("LOGS")
            End If
            Dim ns As New XmlSerializerNamespaces()
            ns.Add("", "")

            objStreamWriter = New StreamWriter(Fichier)
            Dim x As New XmlSerializer(GetType(LogImportWooList))
            x.Serialize(objStreamWriter, ListItems, ns)
            objStreamWriter.Close()
            bReturn = True
        Catch ex As Exception
            Debug.Print("LogImportWoo.WriteXML: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                Debug.Print("LogImportWoo.WriteXML: " & ex.InnerException.Message)
            End If
            bReturn = False
            If objStreamWriter IsNot Nothing Then
                objStreamWriter.Close()
            End If


        End Try
        Return bReturn
    End Function

    Public Shared Function ReadXml() As Boolean
        Dim bReturn As Boolean
        Dim objStreamReader As StreamReader = Nothing
        Dim oReturn As New LogImportWooList
        Try

            objStreamReader = New StreamReader(Fichier)
            Dim x As New XmlSerializer(GetType(LogImportWooList))
            oReturn = x.Deserialize(objStreamReader)
            ListItems.ListItems.AddRange(oReturn.ListItems)
            bReturn = True
        Catch ex As Exception
            Debug.Print("LogImportWoo.ReadXML: " & ex.Message)
            If ex.InnerException IsNot Nothing Then
                Debug.Print("LogImportWoo.ReadXML: " & ex.InnerException.Message)
            End If
            bReturn = False
        End Try
        If objStreamReader IsNot Nothing Then
            objStreamReader.Close()
        End If
        Return bReturn
    End Function


End Class
<Serializable>
Public Class ItemLogImportWoo
    Private _dateImport As String
    Private _nomFichier As String
    Private _numCdeWooCommerce As String
    Private _datecmd As String
    Private _pImport As Boolean
    Private _cmdCode As String
    Private _motif As String

    <XmlAttribute("dateImport")>
    Public Property DateImport As String
        Get
            Return _dateImport
        End Get
        Set(value As String)
            _dateImport = value
        End Set
    End Property

    <XmlAttribute("NomFichier")>
    Public Property NomFichier As String
        Get
            Return _nomFichier
        End Get
        Set(value As String)
            _nomFichier = value
        End Set
    End Property

    <XmlAttribute("NumCdeWoo")>
    Public Property NumCdeWooCommerce As String
        Get
            Return _numCdeWooCommerce
        End Get
        Set(value As String)
            _numCdeWooCommerce = value
        End Set
    End Property

    <XmlAttribute("dateCmd")>
    Public Property Datecmd As String
        Get
            Return _datecmd
        End Get
        Set(value As String)
            _datecmd = value
        End Set
    End Property

    <XmlAttribute("pImport")>
    Public Property PImport As Boolean
        Get
            Return _pImport
        End Get
        Set(value As Boolean)
            _pImport = value
        End Set
    End Property

    <XmlAttribute("CmdCode")>
    Public Property CmdCode As String
        Get
            Return _cmdCode
        End Get
        Set(value As String)
            _cmdCode = value
        End Set
    End Property

    <XmlAttribute("Motif")>
    Public Property Motif As String
        Get
            Return _motif
        End Get
        Set(value As String)
            _motif = value
        End Set
    End Property
End Class
