
/****** Object:  StoredProcedure [dbo].[CONTROLE_SCMD]    Script Date: 22/06/2021 15:15:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CONTROLE_SCMD] 
(@dateDeb DateTime, @datefin DateTime)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT    DISTINCT  COMMANDE.CMD_CODE
FROM         PRODUIT INNER JOIN
                      LIGNE_COMMANDE INNER JOIN
                      COMMANDE ON LIGNE_COMMANDE.LGCM_CMD_ID = COMMANDE.CMD_ID ON 
                      PRODUIT.PRD_ID = LIGNE_COMMANDE.LGCM_PRD_ID LEFT OUTER JOIN
                      SOUSCOMMANDE ON LIGNE_COMMANDE.LGCM_SCMD_ID = SOUSCOMMANDE.SCMD_ID
WHERE     (LIGNE_COMMANDE.LGCM_SCMD_ID <> 0) AND (SOUSCOMMANDE.SCMD_ETAT IS NULL) AND CMD_ETAT = 3
AND CMD_DATE >= @datedeb and CMD_DATE <= @datefin
END
GO

/****** Object:  StoredProcedure [dbo].[GETNEXTNUM_BA]    Script Date: 22/06/2021 15:16:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Marc Collin
-- Create date: 02/2/2008
-- Description: Retourne le prochain numéro de Bon D'appro en incrémentant la table constante
-- =============================================
CREATE PROCEDURE [dbo].[GETNEXTNUM_BA]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
	DECLARE @C1 as int

BEGIN TRANSACTION T1
	-- Lecture du Numéro
	SELECT @C1 = CST_DERN_NUM_BA FROM CONSTANTES
    -- Mise à jout de la base
	UPDATE CONSTANTES SET CST_DERN_NUM_BA = (@C1+1)
    -- Retour de la valeur
	SELECT @C1 as CODE 
COMMIT TRANSACTION T1

END
GO



/****** Object:  StoredProcedure [dbo].[GETNEXTNUM_CMD_CLT]    Script Date: 22/06/2021 15:16:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Marc Collin
-- Create date: 02/2/2008
-- Description: Retourne le prochain numéro de commande client en incrémentant la table constante
-- =============================================
CREATE PROCEDURE [dbo].[GETNEXTNUM_CMD_CLT]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
	DECLARE @C1 as int

BEGIN TRANSACTION T1
	-- Lecture du Numéro
	SELECT @C1 = CST_DERN_NUM_CMD_CLT FROM CONSTANTES
    -- Mise à jout de la base
	UPDATE CONSTANTES SET CST_DERN_NUM_CMD_CLT = (@C1+1)
    -- Retour de la valeur
	SELECT @C1 as CODE 
COMMIT TRANSACTION T1

END
GO

/****** Object:  StoredProcedure [dbo].[GETNEXTNUM_FACTCOL]    Script Date: 22/06/2021 15:16:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Marc Collin
-- Create date: 02/2/2008
-- Description: Retourne le prochain numéro de Facture de colisage en incrémentant la table constante
-- =============================================
CREATE PROCEDURE [dbo].[GETNEXTNUM_FACTCOL] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
	DECLARE @C1 as int

BEGIN TRANSACTION T1
	-- Lecture du Numéro
	SELECT @C1 = CST_DERN_NUM_FACT_COLISAGE FROM CONSTANTES
    -- Mise à jout de la base
	UPDATE CONSTANTES SET CST_DERN_NUM_FACT_COLISAGE = (@C1+1)
    -- Retour de la valeur
	SELECT @C1 as CODE 
COMMIT TRANSACTION T1

END
GO



/****** Object:  StoredProcedure [dbo].[GETNEXTNUM_FACTCOM]    Script Date: 22/06/2021 15:17:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Marc Collin
-- Create date: 02/2/2008
-- Description: Retourne le prochain numéro de Facture de commision en incrémentant la table constante
-- =============================================
CREATE PROCEDURE [dbo].[GETNEXTNUM_FACTCOM]	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
	DECLARE @C1 as int

BEGIN TRANSACTION T1
	-- Lecture du Numéro
	SELECT @C1 = CST_DERN_NUM_FACTCOM FROM CONSTANTES
    -- Mise à jout de la base
	UPDATE CONSTANTES SET CST_DERN_NUM_FACTCOM = (@C1+1)
    -- Retour de la valeur
	SELECT @C1 as CODE 
COMMIT TRANSACTION T1

END
GO


/****** Object:  StoredProcedure [dbo].[GETNEXTNUM_FACTHBV]    Script Date: 22/06/2021 15:18:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETNEXTNUM_FACTHBV]	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
	DECLARE @C1 as int

BEGIN TRANSACTION T1
	-- Lecture du Numéro
	SELECT @C1 = CST_DERN_NUM_FACT_HBV FROM CONSTANTES
    -- Mise à jout de la base
	UPDATE CONSTANTES SET CST_DERN_NUM_FACT_HBV = (@C1+1)
    -- Retour de la valeur
	SELECT @C1 as CODE 
COMMIT TRANSACTION T1

END
GO


/****** Object:  StoredProcedure [dbo].[GETNEXTNUM_FACTTRP]    Script Date: 22/06/2021 15:18:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETNEXTNUM_FACTTRP]	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
	DECLARE @C1 as int

BEGIN TRANSACTION T1
	-- Lecture du Numéro
	SELECT @C1 = CST_DERN_NUM_FACT_TRP FROM CONSTANTES
    -- Mise à jout de la base
	UPDATE CONSTANTES SET CST_DERN_NUM_FACT_TRP = (@C1+1)
    -- Retour de la valeur
	SELECT @C1 as CODE 
COMMIT TRANSACTION T1

END
GO


/****** Object:  StoredProcedure [dbo].[GETNEXTNUM_SCMD]    Script Date: 22/06/2021 15:18:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GETNEXTNUM_SCMD]	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON
	DECLARE @C1 as int

BEGIN TRANSACTION T1
	-- Lecture du Numéro
	SELECT @C1 = CST_DERN_NUM_SCMD FROM CONSTANTES
    -- Mise à jout de la base
	UPDATE CONSTANTES SET CST_DERN_NUM_SCMD = (@C1+1)
    -- Retour de la valeur
	SELECT @C1 as CODE 
COMMIT TRANSACTION T1

END
GO

/****** Object:  StoredProcedure [dbo].[SELECT_SCMD_SANSLIGNE]    Script Date: 22/06/2021 15:19:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Liste des SousCommande Sans lignes
-- =============================================
CREATE PROCEDURE [dbo].[SELECT_SCMD_SANSLIGNE] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT     DISTINCT COMMANDE.CMD_CODE as 'Code Commande', COMMANDE.CMD_DATE as 'Date Commande', 
                      COMMANDE.CMD_ETAT as 'Etat Comamnde'
FROM         SOUSCOMMANDE INNER JOIN
                      COMMANDE ON SOUSCOMMANDE.SCMD_CMD_ID = COMMANDE.CMD_ID LEFT OUTER JOIN
                      LIGNE_COMMANDE ON SOUSCOMMANDE.SCMD_ID = LIGNE_COMMANDE.LGCM_SCMD_ID
GROUP BY SOUSCOMMANDE.SCMD_ID, SOUSCOMMANDE.SCMD_CODE, COMMANDE.CMD_ID, COMMANDE.CMD_CODE, COMMANDE.CMD_DATE, 
                      COMMANDE.CMD_ETAT
HAVING      (COUNT(LIGNE_COMMANDE.LGCM_ID) = 0) AND CMD_DATE > '01/01/2009'

END
GO

/****** Object:  StoredProcedure [dbo].[SUPPR_SCMD_CMD]    Script Date: 22/06/2021 15:19:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	Suppression des SousCommandes sans lignes d'une commande
-- =============================================
CREATE PROCEDURE [dbo].[SUPPR_SCMD_CMD] 
(@CmdCode varchar(10))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
DELETE FROM SOUSCOMMANDE WHERE SCMD_CMD_ID = (SELECT CMD_ID FROM COMMANDE WHERE COMMANDE.CMD_CODE = @CmdCode AND COMMANDE.CMD_CODE in (Select COMMANDE.CMD_CODE FROM SOUSCOMMANDE INNER JOIN
                      COMMANDE ON SOUSCOMMANDE.SCMD_CMD_ID = COMMANDE.CMD_ID LEFT OUTER JOIN
                      LIGNE_COMMANDE ON SOUSCOMMANDE.SCMD_ID = LIGNE_COMMANDE.LGCM_SCMD_ID
GROUP BY SOUSCOMMANDE.SCMD_ID, SOUSCOMMANDE.SCMD_CODE, COMMANDE.CMD_ID, COMMANDE.CMD_CODE, COMMANDE.CMD_DATE, 
                      COMMANDE.CMD_ETAT
HAVING      (COUNT(LIGNE_COMMANDE.LGCM_ID) = 0) AND CMD_DATE > '01/01/2009'
))
END
GO