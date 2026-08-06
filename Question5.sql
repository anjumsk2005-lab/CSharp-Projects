-- Question 5
-- Display employees who are NOT
-- Research and Development Engineer.

SELECT BusinessEntityID,
       LoginID,
       JobTitle
FROM HumanResources.Employee
WHERE JobTitle <> 'Research and Development Engineer';