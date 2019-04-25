use sqlpractice 
GO

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='Certificates') 
DROP TABLE Certificates 
GO

CREATE TABLE Certificates
(
    VourcherNumber VARCHAR(30) 
	CONSTRAINT PK_Certificates_VourcherNumber PRIMARY KEY,
	ParticipantName VARCHAR(30),
	Technology VARCHAR(30), 
	CertificationCode VARCHAR(30),
	CertificaionName VARCHAR(30), 
	CertificationDate DATETIME
)
GO

CREATE PROC prcCertificationSearch
					@VourcherNumber VARCHAR(30)

AS
BEGIN
	IF EXISTS(SELECT * FROM Certificates WHERE VourcherNumber=@VourcherNumber )
	BEGIN 
		SELECT * FROM Certificates WHERE VourcherNumber=@VourcherNumber
	END
END
GO

INSERT INTO Certificates VALUES('1234-1234-1234','JITU','JAVA','OCJP','CoreJava','12-12-2000'),
								('1234-1234-1235','JITU','JAVA','OCJP','CoreJava','12-12-2000')
GO