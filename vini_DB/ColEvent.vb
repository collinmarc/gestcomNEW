'===================================================================================================================================
'Projet : Vinicom
'Auteur : Marc Collin 
'Cr�ation : 23/06/04
'===================================================================================================================================
' Classe : colEvent
' Description : Collection qui gere l'evenment Updated
'===================================================================================================================================
'Membres de Classes
'==================
'Public
'Protected
'Private
'Membres d'instances
'==================
'Public
'   toString()      : Rend 'objet sous forme de chaine
'   Equals()        : Test l'�quivalence d'instance
'Protected
'Private
'===================================================================================================================================
'Historique :
'============
'
'===================================================================================================================================

Public Class ColEvent
    Inherits racine
    Private m_col As Collection

    '=======================================================================
    'Fonction : Add()
    'Description : Ajoute un Element � la collection et arme l'Event HandlerUpdated
    'D�tails    :  
    'Retour : 
    '=======================================================================
    Public Sub Add(ByVal obj As racine, Optional ByVal sKey As String = "")
        If Trim(sKey) = "" Then
            sKey = CStr(m_col.Count + 1)
        End If
        m_col.Add(obj, sKey)
        AddHandler obj.Updated, AddressOf MyHandler
        RaiseUpdated()
    End Sub
    '=======================================================================
    'Fonction : Count()
    'Description : Rend le nombre d'�lement dans la collection
    'D�tails    :  
    'Retour : une Chaine
    '=======================================================================
    Public Function Count() As Integer
        Return m_col.Count
    End Function

    Public ReadOnly Property col As Collection
        Get
            Return m_col
        End Get
    End Property
    '=======================================================================
    'Fonction : Item()
    'Description : Rend l'objet index�
    'D�tails    :  
    'Retour : une objet
    '=======================================================================
    Default Public ReadOnly Property Item(ByVal index As Object) As racine
        Get
            Return m_col.Item(index)
        End Get
    End Property

    '=======================================================================
    'Fonction : Remove()
    'Description : Supprime l'objet de la collection et d�sarme l'EventHandler
    'D�tails    :  
    'Retour : une Chaine
    '=======================================================================
    Public Function Remove(ByVal index As Integer) As Boolean
        Dim bReturn As Boolean
        Dim obj As racine
        Try
            obj = m_col(index)
            RemoveHandler obj.Updated, AddressOf MyHandler
            m_col.Remove(index)
            RaiseUpdated()
            bReturn = True
        Catch ex As Exception
            bReturn = False
        End Try
        Return bReturn
    End Function
    '=======================================================================
    'Fonction : Remove()
    'Description : Supprime l'objet de la collection et d�sarme l'EventHandler
    'D�tails    :  
    'Retour : une Chaine
    '=======================================================================
    Public Function Remove(ByVal index As String) As Boolean
        Dim bReturn As Boolean
        Dim obj As racine
        Try
            obj = m_col(index)
            RemoveHandler obj.Updated, AddressOf MyHandler
            m_col.Remove(index)
            RaiseUpdated()
            bReturn = True
        Catch ex As Exception
            bReturn = False
        End Try
        Return bReturn
    End Function
    '=======================================================================
    'Fonction : MyHandler()
    'Description : EventHandler qui d�clenche l'�v�nement Updated
    'D�tails    :  
    'Retour : 
    '=======================================================================
    Private Sub MyHandler()
        RaiseUpdated()
    End Sub

    Public Sub New()
        m_col = New Collection
    End Sub
    Public Function GetEnumerator() As IEnumerator
        GetEnumerator = m_col.GetEnumerator
    End Function

    Public Overrides Function toString() As String
        Dim objRacine As racine
        Dim str As String
        str = "{"
        For Each objRacine In m_col
            str = str & "," & objRacine.toString()
        Next
        str = str & "}"
        Return str
    End Function 'ToString

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim objRacine As racine
        Dim bReturn As Boolean
        bReturn = True
        For Each objRacine In m_col
            bReturn = bReturn & objRacine.Equals(obj)
        Next
        Return bReturn
    End Function 'Equals


    Public Function clear() As Boolean
        Dim bReturn As Boolean
        bReturn = True
        While m_col.Count > 0
            Remove(1)
        End While
    End Function 'Clear

    Public Overrides ReadOnly Property shortResume() As String
        Get
            Return "colEvent" & Count() & "items"
        End Get
    End Property

    Public Function keyExists(ByVal strkey As Object) As Boolean
        Return m_col.Contains(strkey)
    End Function
End Class
