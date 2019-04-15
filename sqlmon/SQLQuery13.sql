IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcEmpOutCall')
DROP PROC prcEmpOutCall
GO

CREATE PROC prcEmpOutCall 
					@empno INT
AS
BEGIN
	DECLARE
		@Nam VARCHAR(30),
		@Dept VARCHAR(30),
		@Desig VARCHAR(30),
		@Basic INT,
		@res INT
	BEGIN
		EXEC @res=prcEmpOut @empno,@Nam OUTPUT,@Dept OUTPUT,@Desig OUTPUT,
						@Basic OUTPUT 
		IF @res=1
		BEGIN
			PRINT 'Name ' +@nam 
			PRINT 'DEPT ' +@Dept
		END
		ELSE 
		BEGIN
			PRINT 'Record Not Found'
		END
	END
END
GO

EXEC prcEmpOutCall 555