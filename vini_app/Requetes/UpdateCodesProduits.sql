UPDATE PRODUIT 
SET PRODUIT.PRD_BARCHIVE = iif(_CodesProduits.prd_bArchive='FAUX',0,1)
From _CodesProduits
where PRODUIT.prd_id = _CodesProduits.PRD_ID
GO
UPDATE PRODUIT 
SET PRODUIT.PRD_DISPO = iif(_CodesProduits.prd_Dispo='FAUX',0,1)
From _CodesProduits
where PRODUIT.prd_id = _CodesProduits.PRD_ID
GO
UPDATE PRODUIT 
SET PRODUIT.PRD_MIL = _CodesProduits.PRD_MIL
From _CodesProduits
where PRODUIT.prd_id = _CodesProduits.PRD_ID
GO
UPDATE PRODUIT 
SET PRODUIT.PRD_CODE_STAT = PRODUIT.PRD_CODE
GO
UPDATE PRODUIT 
SET PRODUIT.PRD_CODE = _CodesProduits.NOUVEAU_CODE
From _CodesProduits
where PRODUIT.prd_id = _CodesProduits.PRD_ID AND NOT Nouveau_code is null
