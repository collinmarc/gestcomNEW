﻿ALTER TABLE CONSTANTES ADD
	CST_DATE_UPDATE DateTime 
GO
UPDATE CONSTANTES SET CST_DATE_UPDATE = GETDATE()
GO
UPDATE CONSTANTES SET CST_VERSION_BD = '6.0.0.3'
GO