select agentid from Agent 
INTERSECT
SELECT AGENTID FROM AGENTPOLICY

SELECT POLICYID FROM POLICY 
INTERSECT 
SELECT POLICYID FROM AGENTPOLICY 

/* Example for INNER JOIN */

SELECT
   Agent.AgentID,FirstName,LastName,City,SSN,
   Policy.PolicyID,AppNumber,ModalPremium,PayMentModelID,ModalPremium
FROM 
AGENT INNER JOIN AgentPolicy 
ON Agent.AgentID=AgentPolicy.AgentID 
INNER JOIN Policy 
ON Policy.PolicyID=AgentPolicy.PolicyID


SELECT
   A.AgentID,FirstName,LastName,City,SSN,
   P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
FROM 
AGENT A INNER JOIN AgentPolicy AP
ON A.AgentID=AP.AgentID 
INNER JOIN Policy P
ON P.PolicyID=AP.PolicyID

/* LEFT JOIN */

SELECT
   A.AgentID,FirstName,LastName,City,SSN,
   P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
FROM 
AGENT A LEFT JOIN AgentPolicy AP
ON A.AgentID=AP.AgentID 
LEFT JOIN Policy P
ON P.PolicyID=AP.PolicyID

/* Right Join */

SELECT
   A.AgentID,FirstName,LastName,City,SSN,
   P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
FROM 
AGENT A RIGHT JOIN AgentPolicy AP
ON A.AgentID=AP.AgentID 
RIGHT JOIN Policy P
ON P.PolicyID=AP.PolicyID

/* Full Join */

SELECT
   A.AgentID,FirstName,LastName,City,SSN,
   P.PolicyID,AppNumber,ModalPremium,PayMentModelID,AnnualPremium
FROM 
AGENT A FULL JOIN AgentPolicy AP
ON A.AgentID=AP.AgentID 
FULL JOIN Policy P
ON P.PolicyID=AP.PolicyID

SELECT * FROM AGENT CROSS JOIN AgentPolicy

SELECT * FROM POLICY CROSS JOIN AgentPolicy

select 
   E1.Empno 'Mgr No',
   E2.Empno 'Emp No',
   E1.Nam 'Mgr Name',
   E2.Nam 'Emp Name'
FROM EmpMgr E1 INNER JOIN EmpMgr E2 
ON E1.Empno=E2.MgrNo

select 
   E1.Empno 'Mgr No',
   E2.Empno 'Emp No',
   E1.Nam 'Mgr Name',
   E2.Nam 'Emp Name'
FROM EmpMgr E1 RIGHT JOIN EmpMgr E2 
ON E1.Empno=E2.MgrNo