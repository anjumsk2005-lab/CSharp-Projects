-- Question 15

DELETE FROM dbo.demoCustomer
WHERE CustomerID IN
(
    SELECT C.CustomerID
    FROM dbo.demoCustomer C
    LEFT JOIN dbo.demoSalesOrderHeader H
        ON C.CustomerID = H.CustomerID
    GROUP BY C.CustomerID
    HAVING SUM(ISNULL(H.TotalDue,0)) < 1000
);