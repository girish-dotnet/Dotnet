IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcEmpShow') 
DROP PROC prcEmpShow 
GO

CREATE PROC prcEmpShow 
AS
BEGIN
	SELECT * FROM Emp 
END
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcAgentShow') 
DROP PROC prcAgentShow 
GO

CREATE PROC prcAgentShow 
AS
BEGIN
	SELECT * FROM Agent  
END
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcCustomerShow') 
DROP PROC prcCustomerShow 
GO

CREATE PROC prcCustomerShow 
AS
BEGIN
	SELECT * FROM Customer  
END
GO

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

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='prcCustomerSearch') 
DROP PROC prcCustomerSearch 
GO

CREATE PROC prcCustomerSearch 
					@custId INT
AS
BEGIN
	SELECT * FROM Customer WHERE CustId=@custId
END
GO

