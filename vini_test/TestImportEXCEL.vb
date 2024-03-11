Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports vini_DB
Imports System.Collections.Generic
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data
<TestClass()> Public Class TestImportEXcel
    Inherits test_Base
    Private _TestContext As TestContext
    Public Property NewProperty() As TestContext
        Get
            Return _TestContext
        End Get
        Set(ByVal value As TestContext)
            _TestContext = value
        End Set
    End Property

    <TestInitialize()> Public Overrides Sub TestInitialize()
        MyBase.TestInitialize()

        'If System.IO.File.Exists("./testImportEXCEL.xlsx") Then
        '    System.IO.File.Delete("./testImportEXCEL.xlsx")
        'End If
        'Dim objApp As New Microsoft.Office.Interop.Excel.Application()
        'Try
        '    objApp.Workbooks().Add()
        '    Dim oSheet As Excel.Worksheet
        '    Dim oWB As Excel.Workbook
        '    oWB = objApp.Workbooks(1)
        '    oSheet = oWB.Sheets(1)
        '    oSheet.Cells(1, 2) = "Colonne2"
        '    oSheet.Cells(1, 19) = "ColonneS"
        '    Dim n As Integer
        '    For n = 10 To 15
        '        oSheet.Cells(n, 2).Value = "9999" & n
        '        oSheet.Cells(n, 19).Value = "123.45"
        '    Next
        '    oSheet.Cells(n + 1, 2).Value = "999910"
        '    oSheet.Cells(n + 1, 2).Value = "TESTVALEURINCONNUE"

        '    oSheet.Cells(n + 2, 2).Value = "999910"
        '    objApp.Workbooks(1).SaveAs(Environment.CurrentDirectory & "/testImportExcel.xlsx")
        '    Console.WriteLine("fichier créé en " & Environment.CurrentDirectory & "/testImportExcel.xlsx")
        'Catch ex As Exception
        '    Console.WriteLine("Erreur en ecriture du fichier EXCEL" & ex.Message)

        'End Try
        'objApp.Quit

    End Sub
    <TestCleanup()> Public Overrides Sub TestCleanup()

        MyBase.TestCleanup()

    End Sub
    ''' <summary>
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()>
    Public Sub T101_ImportTarif()
        Dim oFRN As New Fournisseur("FRNTEST", "TEST")
        oFRN.Save()
        Dim oProduit As New Produit("999910", oFRN, "2017")
        oProduit.TarifA = 741.85
        oProduit.TarifB = 852.96
        oProduit.TarifC = 963.74
        oProduit.save()
        Dim idProduit As Integer
        idProduit = oProduit.id

        Dim oProduit2 As New Produit("999915M17", oFRN, "2017")
        oProduit2.codeStat = "999915"
        oProduit2.TarifA = 741.85
        oProduit2.TarifB = 852.96
        oProduit2.TarifC = 963.74
        oProduit2.save()
        Dim idProduit2 As Integer
        idProduit2 = oProduit2.id

        Dim oImport As New ImportTarifGESTCOM("testImportTarif.csv", 1, 2, 3, 4, 5)

        oImport.ImportTarif()
        oProduit = Produit.createandload(idProduit)

        Assert.AreEqual(2.9D, oProduit.TarifA)
        Assert.AreEqual(2.9D, oProduit.TarifB)
        Assert.AreEqual(3D, oProduit.TarifC)
        Assert.AreEqual(3.6D, oProduit.TarifD)

        oProduit2 = Produit.createandload(idProduit2)

        Assert.AreEqual(7.8D, oProduit2.TarifA)
        Assert.AreEqual(7.8D, oProduit2.TarifB)
        Assert.AreEqual(8.7D, oProduit2.TarifC)
        Assert.AreEqual(10.3D, oProduit2.TarifD)


    End Sub
    <TestMethod()>
    Public Sub T101_ImportTarifTarifD()
        Dim oProduit As Produit
        Dim oFRN As New Fournisseur("FRNTEST", "TEST")
        oFRN.Save()


        oProduit = Produit.createandloadbyKey("123002H")
        If oProduit IsNot Nothing Then
            oProduit.delete()
        End If
        oProduit = Produit.createandloadbyKey("156001H")
        If oProduit IsNot Nothing Then
            oProduit.delete()
        End If

        oProduit = New Produit("123002H", oFRN, "2017")
        oProduit.TarifA = 741.85D
        oProduit.TarifB = 852.96D
        oProduit.TarifC = 963.74D
        oProduit.TarifD = 741.12D
        oProduit.save()
        Dim idProduit As Integer
        idProduit = oProduit.id

        Dim oProduit2 As New Produit("156001H", oFRN, "2017")
        oProduit2.TarifA = 741.85D
        oProduit2.TarifA = 852.96D
        oProduit2.TarifA = 963.74D
        oProduit2.TarifA = 123.45D
        oProduit2.save()
        Dim idProduit2 As Integer
        idProduit2 = oProduit2.id

        Dim oImport As New ImportTarifGESTCOM(pFileName:=Environment.CurrentDirectory & "/tarif import Gescom.csv", pNumColCode:=1, pNumColTarifA:=2, pNumColTarifB:=3, pNumColTarifC:=4, pNumColTarifD:=5)

        oImport.ImportTarif()
        oProduit = Produit.createandload(idProduit)

        Assert.AreEqual(2.9D, oProduit.TarifA)
        Assert.AreEqual(2.9D, oProduit.TarifB)
        Assert.AreEqual(3D, oProduit.TarifC)
        Assert.AreEqual(3.6D, oProduit.TarifD)

        oProduit2 = Produit.createandload(idProduit2)

        Assert.AreEqual(7.8D, oProduit2.TarifA)
        Assert.AreEqual(7.8D, oProduit2.TarifB)
        Assert.AreEqual(8.7D, oProduit2.TarifC)
        Assert.AreEqual(10.3D, oProduit2.TarifD)

        oProduit = Produit.createandload(idProduit)
        oProduit.TarifD = 1.1D
        oProduit.TarifB = 1.2D
        oProduit.TarifC = 1.3D
        oProduit.TarifD = 1.4D
        oProduit.save()
        'Import en ommetant les Col B et D
        oImport = New ImportTarifGESTCOM(pFileName:=Environment.CurrentDirectory & "/tarif import Gescom.csv", pNumColCode:=1, pNumColTarifA:=2, pNumColTarifB:=0, pNumColTarifC:=4, pNumColTarifD:=0)
        oImport.ImportTarif()
        oProduit = Produit.createandload(idProduit)

        Assert.AreEqual(2.9D, oProduit.TarifA)
        Assert.AreEqual(1.2D, oProduit.TarifB)
        Assert.AreEqual(3D, oProduit.TarifC)
        Assert.AreEqual(1.4D, oProduit.TarifD)


        oProduit.delete()
        oProduit2.delete()
        oFRN.delete()

    End Sub
    <TestMethod()>
    Public Sub T101_GetNbreLignes()

        Dim oImport As New ImportTarifGESTCOM(Environment.CurrentDirectory & "/tarif import Gescom.csv", 1, 0, 0, 0, 0)

        Assert.AreNotEqual(0, oImport.getNbreLignes())

    End Sub


End Class