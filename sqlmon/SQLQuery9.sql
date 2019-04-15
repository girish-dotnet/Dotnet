IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcEmpInsert')
DROP PROC prcEmpInsert
GO

CREATE PROC prcEmpInsert
					@Empno INT,
					@Nam varchar(30),
					@Dept varchar(30),
					@Desig varchar(30),
					@Basic INT
AS
BEGIN
	INSERT INTO EMP VALUES(@Empno,@Nam,@Dept,@Desig,@Basic)
END
GO
EXEC prcEmpInsert 88,'Ram','Dotnet','SWE',28834 