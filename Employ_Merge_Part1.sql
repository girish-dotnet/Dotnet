IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='EmployDetails')
DROP TABLE EmployDetails 
GO

CREATE TABLE EmployDetails
(
	Empno INT PRIMARY KEY,
	Name VARCHAR(30),
	Salary INT
)
GO

INSERT INTO EmployDetails VALUES(1,'Arun',82333),
				(2,'Ravitha',28424),
				(3,'Priya',12444),
				(4,'Bhargav',88233),
				(5,'Sangeetha',88423)

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='EmployAppraisal')
DROP TABLE EmployAppraisal 
GO

CREATE TABLE EmployAppraisal
(
	Empno INT PRIMARY KEY,
	Name VARCHAR(30),
	Salary INT
)
GO

INSERT INTO EmployAppraisal VALUES(1,'Arun',82333),
				(2,'Ravitha',77666),
				(3,'Priya',56789),
				(4,'Bhargav',99888),
				(5,'Sangeetha',88423),
				(6,'Siva',88231),
				(7,'Jitu',88113)
GO

