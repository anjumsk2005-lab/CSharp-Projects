-- Question 3
-- Display employees who have the job title
-- 'Research and Development Engineer'.

SELECT BusinessEntityID,
       LoginID,
       JobTitle
FROM HumanResources.Employee
WHERE JobTitle = 'Research and Development Engineer';