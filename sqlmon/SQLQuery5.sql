IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcSayHello')
DROP PROC prcSayHello
GO


CREATE PROC prcSayHello
AS
BEGIN
	PRINT 'Welcome to Stored Procedure'
END
GO


-- To execute the store procedure 

EXEC prcSayHello
GO
