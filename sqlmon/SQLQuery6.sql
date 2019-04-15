IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcCalc')
DROP PROC prcCalc
GO

CREATE PROC prcCalc
				@firstNo INT,
				@secondNo INT
AS
BEGIN
	DECLARE
		@res INT
	BEGIN
		SET @res=@firstNo+@secondNo 
		PRINT 'Sum is ' +CONVERT(varchar(10),@res)
	END
END
GO

EXEC prcCalc 12,5 
GO