IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Customer') 
DROP TABLE Customer 
GO

CREATE TABLE Customer
(
  CustID INT PRIMARY KEY,
  CustName VARCHAR(30),
  Premium INT,
  Installment INT,
  Comments VARCHAR(30)
)
GO