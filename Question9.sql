-- Question 9

SELECT
    P.ProductID,
    P.Name,
    SOD.SalesOrderID
FROM Production.Product P
LEFT JOIN Sales.SalesOrderDetail SOD
    ON P.ProductID = SOD.ProductID;