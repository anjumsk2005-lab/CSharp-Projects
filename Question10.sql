-- Question 10

SELECT
    BusinessEntityID,
    FirstName,
    MiddleName,
    LastName
FROM Person.Person
WHERE MiddleName IN ('E', 'B');