use sqlpractice 
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Product') 
DROP TABLE Product 
GO

CREATE TABLE Product
(
    SerialNumber VARCHAR(30) 
	CONSTRAINT PK_Product_SerialNumber PRIMARY KEY,
	ProductName VARCHAR(30),
	BrandName VARCHAR(30), 
	ProductType VARCHAR(30),
	ProductDescription VARCHAR(30), 
	Price INT
)
GO

CREATE PROC prcProductAdd
					@SerialNumber VARCHAR(30),
					@ProductName VARCHAR(30),
					@BrandName VARCHAR(30),
					@ProductType VARCHAR(30),
					@ProductDescription VARCHAR(30),
					@Price INT

AS
BEGIN
	INSERT INTO Product VALUES(@SerialNumber,@ProductName,@BrandName,@ProductType,
				@ProductDescription,@Price)
END
GO
