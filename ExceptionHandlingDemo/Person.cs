using System;
using System.Text.RegularExpressions;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new Exception("First Name should not be empty.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new Exception("Last Name should not be empty.");

        if (!Regex.IsMatch(firstName, "^[A-Za-z]+$"))
            throw new Exception("First Name should contain only alphabets.");

        if (!Regex.IsMatch(lastName, "^[A-Za-z]+$"))
            throw new Exception("Last Name should contain only alphabets.");

        FirstName = firstName;
        LastName = lastName;
    }
}