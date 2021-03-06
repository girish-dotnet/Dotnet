--CREATE SEQUENCE STUDENT_SEQ START WITH 1 INCREMENT By 1

IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='STUDENT')
DROP TABLE STUDENT

CREATE TABLE STUDENT
(
   SNO INT
   CONSTRAINT PK_STUDENT_SNO PRIMARY KEY,
   NAME VARCHAR(30) NOT NULL,
   SUB1 INT,
   SUB2 INT,
   SUB3 INT,
   TOTAL INT,
   AVEG NUMERIC(9,2)
)
GO


INSERT INTO STUDENT(SNO,NAME,SUB1,SUB2,SUB3)
  VALUES(NEXT VALUE FOR STUDENT_SEQ,'SIVA',66,62,62),
	(NEXT VALUE FOR STUDENT_SEQ,'BHARGAV',54,45,62),
	(NEXT VALUE FOR STUDENT_SEQ,'RAJU',66,56,62),
	(NEXT VALUE FOR STUDENT_SEQ,'ARUN',66,56,62),
	(NEXT VALUE FOR STUDENT_SEQ,'POOJA',66,87,62)
GO

SELECT * FROM STUDENT 
GO

UPDATE STUDENT SET 
TOTAL=(SUB1+SUB2+SUB3), 
AVEG=(SUB1+SUB2+SUB3)/3 
WHERE SNO=11

