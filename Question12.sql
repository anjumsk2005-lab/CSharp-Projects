-- Question 12

UPDATE D
SET D.UnitPrice = P.ListPrice
FROM dbo.demoSalesOrderDetail D
INNER JOIN dbo.demoProduct P
ON D.ProductID = P.ProductID;