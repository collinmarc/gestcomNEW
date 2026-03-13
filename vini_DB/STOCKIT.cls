Imports System.Collections.Generic
Imports System.IO

Public Class STOCKIT
    Private _filename As String
    Public Sub New(pFilename As String)
        _filename = pFilename
    End Sub

    Public Function getCodeClientVINIDIS() As String
        Dim oLine As List(Of String)
        oLine = getLigneFR()
        Return oLine(1)
    End Function
    Public Function getCodeTiers() As String
        Dim oLine As List(Of String)
        oLine = getLigneCL()
        Return oLine(1)
    End Function
    Public Function getNumBL() As String
        Dim oLine As List(Of String)
        oLine = getLigneBL()
        Return oLine(1)
    End Function
    ''' <summary>
    ''' somme des champs 21  des lignes DT
    ''' </summary>
    ''' <returns></returns>
    Public Function getNbrecolisTotal() As Decimal
        Dim oReturn As Decimal = 0
        Dim ncolis As Decimal = 0
        Dim olst As List(Of List(Of String)) = getLignesDT()
        For Each oLine As List(Of String) In olst
            Dim nColisLigne As Decimal
            Try
                nColisLigne = CDec(oLine(21))
            Catch ex As Exception
                nColisLigne = 0
            End Try
            ncolis = ncolis + nColisLigne

        Next
        oReturn = ncolis
        Return oReturn
    End Function

    Private Function getLigneFR() As List(Of String)
        Dim olstreturn As List(Of String)
        olstreturn = getLignes("FR")(0)
        Return olstreturn
    End Function
    Private Function getLigneCL() As List(Of String)
        Dim olstreturn As List(Of String)
        olstreturn = getLignes("CL")(0)
        Return olstreturn
    End Function
    Private Function getLigneST() As List(Of String)
        Dim olstreturn As List(Of String)
        olstreturn = getLignes("ST")(0)
        Return olstreturn
    End Function
    Public Function getLigneBL() As List(Of String)
        Dim olstreturn As List(Of String)
        olstreturn = getLignes("BL")(0)
        Return olstreturn
    End Function
    Private Function getLignesDT() As List(Of List(Of String))
        Dim olstreturn As List(Of List(Of String))
        olstreturn = getLignes("DT")
        Return olstreturn
    End Function
    Private Function getLignes(pTypeLigne As String) As List(Of List(Of String))
        Dim olstreturn As New List(Of List(Of String))
        Dim olstLines As New List(Of String)
        Dim olstFields As New List(Of String)
        If File.Exists(_filename) Then
            olstLines.AddRange(File.ReadAllLines(_filename))
            For Each oLine As String In olstLines
                If oLine.StartsWith(pTypeLigne & "|") Then
                    olstFields = New List(Of String)
                    olstFields.AddRange(Split(oLine, "|"))
                    olstreturn.Add(olstFields)
                    'Exit For
                End If
            Next
        End If
        Return olstreturn
    End Function
End Class
