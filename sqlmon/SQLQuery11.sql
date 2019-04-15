IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcEmpDelete')
DROP PROC prcEmpDelete
GO

CREATE PROC prcEmpDelete
					@empno INT
AS
BEGIN
	IF EXISTS(SELECT * FROM EMP WHERE EMPNO=@empno) 
	BEGIN
		DELETE FROM EMP WHERE Empno=@Empno 
	END
	ELSE 
	BEGIN
		PRINT 'Record Not Found...'
	END
END
GO

EXEC prcEmpDelete 5
GO