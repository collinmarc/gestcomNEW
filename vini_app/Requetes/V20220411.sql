ALTER TABLE PRODUIT
ADD  PRD_TARIFD FLOAT
GO
INSERT INTO [dbo].[EXPORTPARAM]
           ([EXP_TYPE]
           ,[EXP_NLIGNE]
           ,[EXP_NCHAMPS]
           ,[EXP_TYPECHAMPS]
           ,[EXP_VALEUR]
           ,[EXP_LONGUEUR]
           ,[EXP_DESCRIPTION])
     VALUES
           ('QFACT'
           ,1
           ,16
           ,'C'
           ,';'
           ,0
           ,'')
GO

INSERT INTO [dbo].[EXPORTPARAM]
           ([EXP_TYPE]
           ,[EXP_NLIGNE]
           ,[EXP_NCHAMPS]
           ,[EXP_TYPECHAMPS]
           ,[EXP_VALEUR]
           ,[EXP_LONGUEUR]
           ,[EXP_DESCRIPTION])
     VALUES
           ('QFACT'
           ,1
           ,17
           ,'V'
           ,'DATEFACTURE'
           ,0
           ,'Date de la Facture')
