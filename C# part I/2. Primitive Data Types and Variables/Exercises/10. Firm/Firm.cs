using System;

class Firm
{
    static void Main()
    {
        string FirstName = "Miroslav";
        string FamilyName = "Petrov";
        byte age = 27;
        char sex = 'm';
        int idNumber = 124568974;
        int emplNumber = 27560048;
        Console.WriteLine("{0} {1} has the following firm credentials:\nage: {2}\nsex: {3}\nID Number: {4}\nUnique employee number: {5}", FirstName, FamilyName, age, sex, idNumber, emplNumber);
    }
}
