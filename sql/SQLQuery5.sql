IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='STUDENT') 
DROP TABLE STUDENT 

CREATE TABLE STUDENT
(
  SNO INT,
  NAME VARCHAR(30),
  SUB1 INT,
  SUB2 INT,
  SUB3 INT
)

/* ALTER COMMAND : USED to add/modify/drop columns or constraints from the 
given table */ 

/* Add the following Columsn to the Table */ 

--Total INT,
--AVEG Numeric(9,2),
--City varchar(30) 
--InsertedOn DateTime,
--InsertedBy varchar(30) 

ALTER TABLE STUDENT ADD Total INT
GO

ALTER TABLE STUDENT ADD AVEG NUMERIC(9,2)
GO

ALTER TABLE STUDENT ADD CITY VARCHAR(30) 
GO

ALTER TABLE STUDENT ADD INSERTEDON DATETIME
GO

ALTER TABLE STUDENT ADD INSERTEDBY VARCHAR(30)
GO

/* Modify Name and City as 15 chars instead of 30 */ 

ALTER TABLE STUDENT ALTER COLUMN NAME VARCHAR(15)
GO

ALTER TABLE STUDENT ALTER COLUMN CITY VARCHAR(15)
GO

/* DROP COLUMN CITY FROM TABLE STUDENT */ 

ALTER TABLE STUDENT 
DROP COLUMN CITY
GO

/* ADD PRIMARY KEY ON SNO FIELD */

ALTER TABLE STUDENT
ALTER COLUMN SNO INT NOT NULL
GO

ALTER TABLE STUDENT
ADD CONSTRAINT PK_STUDENT_SNO
PRIMARY KEY(SNO)
GO

/* ADD THE DEFAULT CONSTRAINT ON INSERTEDON FIELD */ 


ALTER TABLE STUDENT
DROP CONSTRAINT DEF_STUDENT_INSON


Alter Table student 
Add constraint def_student_Inson 
default convert(VARCHAR,getdate(),1) for InsertedOn 

SELECT SYSTEM_USER 
Alter Table Student 
Add constraint def_student_InsertedBy 
default system_user for InsertedBy 
   
ALTER TABLE STUDENT
DROP CONSTRAINT DEF_STUDENT_INSERTEDBY


ALTER TABLE STUDENT
ALTER COLUMN INSERTEDBY VARCHAR(MAX)

Alter Table Student 
Add constraint def_student_InsertedBy 
default system_user for InsertedBy 

INSERT INTO STUDENT(SNO,NAME) 
VALUES(1,'ARUN')

SELECT * FROM STUDENT 


















