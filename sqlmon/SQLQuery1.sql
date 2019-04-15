use sqlpractice 
Go

CREATE VIEW vwEmp
AS
	SELECT 
		 Empno,
		 Nam,
		 Basic 
	FROM EMP 

SELECT * FROM vwEmp 
GO


