ALTER TABLE FOURNISSEUR
	ALTER COLUMN FRN_BEXP_INTERNET int
GO
UPDATE CONSTANTES SET CST_VERSION_BD = '5.5'
GO