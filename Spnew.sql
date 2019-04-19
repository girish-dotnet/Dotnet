IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcEmpSearch') 
DROP PROC prcEmpSearch 
GO

CREATE PROC prcEmpSearch 
					@empno INT
AS
BEGIN
	SELECT * FROM Emp WHERE EMPNO=@empno
END
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcAgentSearch') 
DROP PROC prcAgentSearch 
GO

CREATE PROC prcAgentSearch 
					@agentId INT
AS
BEGIN
	SELECT * FROM Agent WHERE AgentId=@agentId
END
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcEmpInsert') 
DROP PROC prcEmpInsert 
GO

CREATE PROC prcEmpInsert 
					@empno INT,
					@name VARCHAR(30),
					@dept VARCHAR(30),
					@desig VARCHAR(30),
					@basic INT
AS
BEGIN
	INSERT INTO EMp VALUES(@empno,@name,@dept,@desig,@basic)
END
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcEmpOut') 
DROP PROC prcEmpOut 
GO
CREATE PROC [dbo].[prcEmpOut] 
					@empno INT,
					@Nam VARCHAR(30) OUTPUT,
					@Dept VARCHAR(30) OUTPUT,
					@Desig VARCHAR(30) OUTPUT,
					@Basic INT OUTPUT
AS
BEGIN
	IF EXISTS(SELECT * FROM EMP WHERE Empno=@empno) 
	BEGIN
		 SELECT @Nam=Nam,@Dept=Dept,@Desig=Desig,@Basic=BASIC
		 FROM EMP WHERE EMPNO=@empno
		 RETURN 1
	END
	ELSE 
	BEGIN
		RETURN 0
	END 
END
GO
