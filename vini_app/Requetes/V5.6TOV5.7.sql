--ALTER TABLE FOURNISSEUR
--	ALTER COLUMN FRN_BEXP_INTERNET int
--GO
--UPDATE CONSTANTES SET CST_VERSION_BD = '5.5'
--GO

-- Version 5.7 (Prestashop)
ALTER TABLE FOURNISSEUR
	ADD  FRN_IDPRESTASHOP int
GO
ALTER TABLE CLIENT
	ADD  CLT_IDPRESTASHOP int
GO
ALTER TABLE PRODUIT
	ADD  PRD_IDPRESTASHOP int
GO
ALTER TABLE PRODUIT
	ADD  PRD_IDPRESTASHOP int
GO
ALTER TABLE COMMANDE
	ADD CMD_IDPRESTASHOP int
GO
ALTER TABLE COMMANDE
	ADD CMD_NAMEPRESTASHOP nvarchar(50)
GO
UPDATE CONSTANTES SET CST_VERSION_BD = '5.7'
GO
