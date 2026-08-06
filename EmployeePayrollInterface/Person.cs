using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person(string firstName, string lastName, string email, DateTime dob)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = email;
        DateOfBirth = dob;
    }

    public virtual void Display()
    {
        Console.WriteLine("First Name : " + FirstName);
        Console.WriteLine("Last Name : " + LastName);
        Console.WriteLine("Email : " + EmailAddress);
        Console.WriteLine("Date of Birth : " + DateOfBirth.ToShortDateString());
    }
}