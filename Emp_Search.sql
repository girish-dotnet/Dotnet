IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcEmpSearch')
DROP PROC prcEmpSearch
GO

CREATE PROC prcEmpSearch
					@empno INT
AS
BEGIN
	DECLARE
		@nam VARCHAR(30),
		@dept VARCHAR(30),
		@desig VARCHAR(30),
		@basic INT
	IF EXISTS(SELECT * FROM EMP WHERE empno=@empno) 
	BEGIN
		SELECT 
			@nam=nam,
			@dept=Dept,
			@desig=DESIG,
			@basic=basic
			FROM EMP WHERE EMPNO=@empno
		PRINT 'Name is ' +@nam 
		PRINT 'Dept is ' +@dept 
		PRINT 'Desig is ' +@desig
		PRINT 'Salary is ' +CONVERT(VARCHAR(10),@basic)
	END
	ELSE
	BEGIN
		PRINT 'Empno Not Found'
	END
END
GO

EXEC prcEmpSearch 1 