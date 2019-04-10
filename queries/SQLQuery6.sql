-- Date Functions 

SELECT GETDATE() 

SELECT CONVERT(VARCHAR,GETDATE(),1)

DATEPART : used to display the specific portion of given date 

SELECT DATEPART(DD,GETDATE()) 

SELECT DATEPART(MM,GETDATE())

SELECT DATEPART(YY,GETDATE())

DW -> 
DY -> 
QQ -> 
WK -> 
HH -> 
MI -> 
SS -> 
MS -> 

DATENAME() : Displays given portion as string. 

SELECT DATENAME(DW,GETDATE())

SELECT DATENAME(MM,GETDATE())

DATEADD() : used to add no.of months/years/days to the given date 

SELECT DATEADD(DD,3,GETDATE())
SELECT DATEADD(YY,3,GETDATE())
SELECT DATEADD(MM,3,GETDATE())

YEAR() : Used to display the year num. 

SELECT YEAR(GETDATE()) 

SELECT DOB,YEAR(DOB) 'year' FROM AGENT 

MONTH() : Used to display the Month Num. 

SELECT MONTH(GETDATE()) 

SELECT DOB,MONTH(DOB) FROM AGENT 

DAY() : Displays Day Num. 

SELECT DOB, DAY(DOB) FROM AGENT 

DATEDiff -> Used to Display difference between two dates. 

SELECT DATEDIFF(DD,'06/15/2019','04/24/2019')
SELECT DATEDIFF(MM,'06/15/2019','04/24/2019')
SELECT DATEDIFF(YY,'06/15/2019','04/24/2020')

Aggregate Functions : 
_______________________

1) SUM : Used to generate sum on given table field. 

SELECT SUM(BASIC) FROM EMP 

SELECT 
SELECT AnnualPremium
FROM Policy
FROM Policy

2) AVG : Used to generate Avg on the Given Field. 

SELECT AVG(BASIC) FROM EMP 

SELECT AVG(AnnualPremium)
FROM Policy

3) MAX : Displays max value 

SELECT MAX(BASIC) FROM EMP 
SELECT MAX(AnnualPremium)
FROM Policy

4) MIN : Displays Min Value 

SELECT MIN(BASIC) FROM EMP 

5) COUNT(*) : Displays Total no.of records of the given table. 

SELECT COUNT(*) FROM EMP 

SELECT 
	MAX(BASIC) 'Max Sal',
	MIN(BASIC) 'Min Sal',
	SUM(BASIC) 'Total Sal',
	AVG(BASIC) 'Avg Sal',
	COUNT(*) 'Total Records'
FROM EMP


SELECT DEPT, COUNT(*) 
FROM EMP 
GROUP BY DEPT 

SELECT DEPT, MAX(BASIC),
	   MIN(BASIC),
	   AVG(BASIC),
	   COUNT(*)
FROM EMP
GROUP BY DEPT

SELECT * FROM AGENT 

-- Display Count of Agents based on Year part of DOB 
-- Having : used to filter records of aggregate field. 

SELECT DEPT, MAX(BASIC),
	   MIN(BASIC),
	   AVG(BASIC),
	   COUNT(*)
FROM EMP
GROUP BY DEPT
HAVING COUNT(*) > 2
ORDER BY DEPT DESC


SELECT YEAR(DOB),COUNT(*)
FROM AGENT 
GROUP BY YEAR(DOB)
HAVING COUNT(*) > 2
ORDER BY COUNT(*) DESC


