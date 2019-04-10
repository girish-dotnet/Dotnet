use sqlpractice 

/* Display list of tables available in current db */  

SELECT * FROM INFORMATION_SCHEMA.TABLES

/* Display info about EMP Table */ 

SP_HELP EMP 

/* Display all records from EMP Table */

SELECT * FROM EMP 

/* Display Empno, Nam and Basic from EMP Table */ 

/* Example for Project OPERATOR */ 

SELECT
	EMPNO,
	Nam, 
	Basic 
FROM EMP 

/* Example for Project OPERATOR */ 

/* Where clause : Used to display the restricted records */ 

/* Example of RESTRICT Operator */ 

SELECT * FROM EMP WHERE EMPNO=1

SELECT * FROM EMP WHERE EMPNO > 10

SELECT * FROM EMP WHERE DEPT='DOTNET'

SELECT * FROM EMP WHERE DEPT='JAVA'

SELECT * FROM EMP WHERE NAM='Ashima'

/* Between...And : used to display records from given range */ 

SELECT * FROM EMP 
WHERE BASIC BETWEEN 30000 AND 50000

SELECT * FROM EMP
WHERE BASIC NOT BETWEEN 30000 AND 50000

/* In : This clause used to display records for 
multiple values of particular attribute */ 

SELECT * FROM EMP 
WHERE DEPT IN('Java','Sql')

SELECT * FROM EMP 
WHERE DEPT NOT IN('Java','SQL')

SELECT * FROM EMP 
WHERE NAM IN('Kiran','Satish','Ashima')

SELECT * FROM EMP 
WHERE EMPNO IN(1,16,543,802)

/* Like : THis operator allows you to display recrods w.r.t Wild cards */

/* Display all records whose name starts with 'a' */ 

SELECT * FROM EMP 
WHERE NAM LIKE 'A%'

/* Display all records whose name ends with 'h' */ 

SELECT * FROM EMP 
WHERE NAM LIKE '%h'

/* Display all records whose name start with a and ends with h */ 

SELECT * FROM EMP 
WHERE NAM LIKE 'a%h'

/* Order By : Used to display data on specific field(s) in 
ascending or descending order */ 

SELECT * FROM EMP 
ORDER BY DEPT 

SELECT * FROM EMP 
ORDER BY BASIC DESC 

SELECT * FROM EMP 
ORDER BY DEPT,NAM 

SELECT * FROM EMP
ORDER BY DEPT,NAM DESC 

/* Top : Used to display top no.of records based on condition */ 

SELECT TOP 3 * FROM EMP 
ORDER BY BASIC DESC 

