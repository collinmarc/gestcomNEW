﻿ALTER TABLE PRODUIT
ADD  PRD_FACTURECOLISAGE BIT
GO
UPDATE PRODUIT SET PRD_FACTURECOLISAGE = PRD_STOCK
GO