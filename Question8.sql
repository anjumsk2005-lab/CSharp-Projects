-- Question 8

SELECT
    C.CustomerID,
    P.LastName,
    P.FirstName,
    C.StoreID,
    SOH.SalesOrderID
FROM Sales.Customer C
INNER JOIN Person.Person P
    ON C.PersonID = P.BusinessEntityID
INNER JOIN Sales.SalesOrderHeader SOH
    ON C.CustomerID = SOH.CustomerID;