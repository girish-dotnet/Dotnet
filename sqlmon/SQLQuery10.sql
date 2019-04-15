IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='prcEmpUpdate')
DROP PROC prcEmpUpdate
GO

CREATE PROC prcEmpUpdate
					@Empno INT,
					@Nam varchar(30),
					@Dept varchar(30),
					@Desig varchar(30),
					@Basic INT
AS
BEGIN 
	UPDATE EMP SET Nam=ISNULL(@Nam,Nam),
				   Dept=ISNULL(@Dept,Dept),
				   Desig=ISNULL(@Desig,Desig),
				   Basic=ISNULL(@Basic,Basic)
	WHERE EMPNO=@Empno 
END
GO

exec prcEmpUpdate 1,null,null,null,88244 
GO 
exec prcEmpUpdate 3,'Anusha','Dotnet','Programmer',88211 
GO

