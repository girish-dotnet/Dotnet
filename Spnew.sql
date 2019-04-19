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
