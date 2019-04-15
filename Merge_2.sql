--MERGE SQL statement - Part 1

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='PRODUCTS')
DROP TABLE PRODUCTS 
GO
--Create a target table
CREATE TABLE Products
(
   ProductID INT PRIMARY KEY,
   ProductName VARCHAR(100),
   Rate MONEY
) 
GO

--Insert records into target table
INSERT INTO Products
VALUES
   (1, 'Tea', 10.00),
   (2, 'Coffee', 20.00),
   (3, 'Muffin', 30.00),
   (4, 'Biscuit', 40.00)
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='UpdatedProducts')
DROP TABLE UpdatedProducts 
GO

--Create source table
CREATE TABLE UpdatedProducts
(
   ProductID INT PRIMARY KEY,
   ProductName VARCHAR(100),
   Rate MONEY
) 
GO

--Insert records into source table
INSERT INTO UpdatedProducts
VALUES
   (1, 'Tea', 10.00),
   (2, 'Coffee', 25.00),
   (3, 'Muffin', 35.00),
   (5, 'Pizza', 60.00)
GO

SELECT * FROM Products
SELECT * FROM UpdatedProducts
GO

--SQL Server Merge Command Key Points
--The MERGE SQL statement requires a semicolon (;) as a statement terminator. Otherwise Error 10713 is raised when a MERGE statement is executed without the statement terminator.
--When used after MERGE, @@ROWCOUNT returns the total number of rows inserted, updated, and deleted to the client.
--At least one of the three MATCHED clauses must be specified when using MERGE statement; the MATCHED clauses can be specified in any order. However a variable cannot be updated more than once in the same MATCHED clause.
--Of course, it's obvious, but just to mention, the person executing the MERGE statement should have SELECT permission on the SOURCE table and INSERT, UPDATE and DELETE permissions on the TARGET table.
--MERGE statement improves the performance as all the data is read and processed only once whereas in previous versions three different statements have to be written to process three different activities (INSERT, UPDATE or DELETE) in which case the data in both the source and target tables are evaluated and processed multiple times; at least once for each statement.
--MERGE statement takes the same kind of locks minus one Intent Shared (IS) Lock that was due to the SELECT statement in the 'IF EXISTS' as we did in previous versions of SQL Server.
--For every INSERT, UPDATE, or DELETE action specified in the MERGE statement, SQL Server fires any corresponding AFTER triggers defined on the target table, but does not guarantee which action to fire triggers first or last. Triggers defined for the same action honor the order you specify.