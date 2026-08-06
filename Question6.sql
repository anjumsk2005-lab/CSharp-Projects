-- Question 6
-- Join Employee and Person tables.

SELECT
E.JobTitle,
E.BirthDate,
P.FirstName,
P.LastName
FROM HumanResources.Employee E
INNER JOIN Person.Person P
ON E.BusinessEntityID = P.BusinessEntityID;