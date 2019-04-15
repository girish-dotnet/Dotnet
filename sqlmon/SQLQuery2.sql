IF EXISTS(SELECT * FROM SYSOBJECTS WHERE NAME='vwAgentPolicy')
DROP VIEW vwAgentPolicy
GO

CREATE VIEW vwAgentPolicy
AS
SELECT
	A.AgentID,
	FirstName, 
	LastName,
	CITY,
	SSN,
	P.PolicyID,
	AppNumber,
	ModalPremium,
	AnnualPremium
FROM AGENT A FULL JOIN AGENTPOLICY AP 
ON A.AgentID=AP.AgentID 
FULL JOIN POLICY P
ON P.PolicyID=AP.PolicyID
GO

SELECT * FROM vwAgentPolicy
GO
