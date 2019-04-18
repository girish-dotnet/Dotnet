Use training

Create Table Customer
(
	CustomerId VARCHAR(10),
	FName VARCHAR(20),
	LName VARCHAR(20),
	Address VARCHAR(20),
	City VARCHAR(20),
	Country VARCHAR(20),
	Phone VARCHAR(20)
)

Select * from Customer

Create Procedure prcInsertCustomer @CID VARCHAR(10),@FName VARCHAR(20),@LName VARCHAR(20),@Address VARCHAR(20),@City VARCHAR(20),@Country VARCHAR(20),@Phone VARCHAR(20)
As
	Insert Customer
	Values(@CID,@FName,@LName,@Address,@City,@Country,@Phone)
	 
Create PROCEDURE RegionFind(@RegionDescription NCHAR(50) OUTPUT,
            @RegionID INTEGER )
AS
        SELECT @RegionDescription =RegionDescription from Region where RegionID=@RegionID

Create Table DNStudent
(
	RollNo int,
	FirstName varchar(20),
	LastName varchar(20),
	Gender char(1),
	Age int,
	Address varchar(20)
)
select * from DNStudent
Create Proc prcStudentDetails @RollNo int
As
	Select  FirstName,
	LastName,
	Gender,
	Age,
	Address From DNStudent 
	where RollNo=@RollNo


Create Table DNEmployee
(
	EmpId int identity(1,1) Primary Key,
	FirstName varchar(20),
	LastName varchar(20),
	Gender char(10),
	Age int,
	Address varchar(20)
)
