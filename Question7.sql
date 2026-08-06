-- Question 7
-- Join Customer and Person tables.

SELECT
C.CustomerID,
C.StoreID,
C.TerritoryID,
P.FirstName,
P.LastName
FROM Sales.Customer C
INNER JOIN Person.Person P
ON C.PersonID = P.BusinessEntityID;