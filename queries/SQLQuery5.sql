/* String functions */ 

charindex() : used to display the first occurrence of given string 

select charindex('e','sangeetha') 

select nam,charindex('a',nam) from Emp 

SELECT FirstName,CHARINDEX('a',FirstName) 
FROM Agent

LEN() : Displays total no.of chars 

select LEN('Aruna') 

SELECT NAM,LEN(NAM) FROM EMP 

SELECT FIRSTNAME,
LEN(FIRSTNAME) 
FROM AGENT 

LEFT() : Displays No.of Left-side chars 
RIGHT() : Displays No.of Right-Side chars 

SELECT LEFT(FIRSTNAME,4) 'First Four',
RIGHT(FirstName,4) 'Last Four',FirstName 
FROM AGENT 

substring() : used to display part of string 

select substring('Jitendra',3,5) 

--from 3rd char it prints 5 chars 

Replace() : used to replace old word/char with new word/char in all occurrences 

select replace('Java Training','Java','Dotnet') 

-- Display the last occurrence of given char. 
ex : name sangeetha find out last occurrence of 'e'

-- in word 'misissipi' count no.of i's 

-- Display your name in sentence case : 

-- vishal output to be displayed as Vishal 

select NAM + DEPT FROM EMP 

select 'aruna' + ' ' + 'reddy' 

select MaritalStatus from Agent 

SELECT 
   MaritalStatus, 
   CASE MaritalStatus
	WHEN 0 THEN 'Unmarried'
	WHEN 1 THEN 'Married'
   END 'Status'
FROM AGENT

/* Distinct : Used to eliminate duplicate values at time of display */ 

select dept from Emp 

SELECT DISTINCT Dept FROM EMP 

-- Write a Query, display headName as If Dept is 'Dotnet' then 'Ram'
--If Dept is 'Java' then 'Kalyan' If Dept is 'SQL' THEN 'Anil' else unknown 


select PayMentModelID From Policy
if 1 then 'yearly' 2 hal-yearly 3 quarterly else unknown 


SELECT
  PolicyID,
  ModalPremium
FROM POLICY 