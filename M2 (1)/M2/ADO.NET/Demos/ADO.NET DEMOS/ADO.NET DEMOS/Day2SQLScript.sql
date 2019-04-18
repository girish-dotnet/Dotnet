Use Northwind

-- Database objects for Transaction Demo
-- Scenario
-- Whenever a new employee is added in the EmployeeDetails Table
-- the EmployeePostion Table also should get updated.
-- In EmployeePosition Table the current strength of a corresponding 
-- PositionCode should be incremented at the same time.

Create Table EmployeeDetails
(
	EmpId int identity(1,1) Primary Key,
	FirstName varchar(20),
	LastName varchar(20),
	PostionCode int references EmployeePosition(PositionCode),
	Gender char(10),
	Age int,
	Address varchar(20)
)

Create Table EmployeePosition
(
	PositionCode int identity(1,1) Primary Key,
	PositionName varchar(20),
	CurrentStrength int,
	BudgetedStrength int
)

Insert EmployeePosition
Values('Software Engineer',0,30)
Insert EmployeePosition
Values('Business Analyst',0,30)
Insert EmployeePosition
Values('Team Lead',0,30)
Insert EmployeePosition
Values('DBA',0,30)

Insert EmployeeDetails
Values('John','Smith',1,'Male',25,'CA')

Update EmployeePosition
Set CurrentStrength=CurrentStrength+1
Where PositionCode = 1

Select * From EmployeeDetails
Select * From EmployeePosition