-- Question 4
-- Display all columns from ProductCostHistory
-- modified on June 17, 2003.

SELECT *
FROM Production.ProductCostHistory
WHERE CAST(ModifiedDate AS DATE) = '2003-06-17';