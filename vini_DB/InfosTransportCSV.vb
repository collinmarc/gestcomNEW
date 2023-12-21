Imports System.Globalization
Imports System.IO
Imports CsvHelper
Imports CsvHelper.Configuration.Attributes
Imports System.Collections.Generic

Public Class InfosTransportCSV
    Public Shared Function Read(pCSVFile As String) As List(Of InfosTransportCSV)
        Dim oReturn As New List(Of InfosTransportCSV)
        Using reader As New StreamReader(pCSVFile)
            Using csvReader As New CsvReader(reader, My.Application.Culture)

                oReturn.AddRange(csvReader.GetRecords(Of InfosTransportCSV)())

            End Using
        End Using
        Return oReturn
    End Function



    Private _refCMD_BA As String
    <Index(0)>
    Public Property RefCMD_BA() As String
        Get
            Return _refCMD_BA
        End Get
        Set(ByVal value As String)
            _refCMD_BA = value
        End Set
    End Property
    Private _typeCMD_BA As String
    <Index(1)>
    Public Property typeCMD_BA() As String
        Get
            Return _typeCMD_BA
        End Get
        Set(ByVal value As String)
            _typeCMD_BA = value
        End Set
    End Property
    Private _LettreVoiture As String
    <Index(2)>
    Public Property LettreVoiture() As String
        Get
            Return _LettreVoiture
        End Get
        Set(ByVal value As String)
            _LettreVoiture = value
        End Set
    End Property
    Private _Cout As Decimal
    <Index(3)>
    Public Property Cout() As Decimal
        Get
            Return _Cout
        End Get
        Set(ByVal value As Decimal)
            _Cout = value
        End Set
    End Property
    Public ReadOnly Property coutstr() As String
        Get
            Return Cout.ToString().Replace(",", ".")
        End Get
    End Property
    Private _RefFactTrp As String
    <Index(4)>
    Public Property RefFactTrp() As String
        Get
            Return _RefFactTrp
        End Get
        Set(ByVal value As String)
            _RefFactTrp = value
        End Set
    End Property

End Class
