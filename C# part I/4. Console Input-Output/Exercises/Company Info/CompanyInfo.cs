// A company has name, address, phone number, fax number, web site and manager.
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string cn = Console.ReadLine();
        Console.Write("Enter company adress: ");
        string ca = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string cpn = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string cfn = Console.ReadLine();
        Console.Write("Enter company web site: ");
        string cws = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string mfn = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string mln = Console.ReadLine();
        Console.Write("Enter manager age: ");
        string ma = Console.ReadLine();
        Console.Write("Enter manager phone number: ");
        string mpn = Console.ReadLine();
        string c = "Company";
        string m = "Manager";
        Console.WriteLine();
        
        Console.WriteLine("--------------------------{0}---------------------------", c);
        Console.WriteLine("Name: {0,54}", cn);
        Console.WriteLine("Adress: {0,52}", ca);
        Console.WriteLine("Phone number: {0,46}", cpn);
        Console.WriteLine("Fax number: {0,48}", cfn);
        Console.WriteLine("Web site: {0,50}", cws);
        Console.WriteLine();
        Console.WriteLine("--------------------------{0}---------------------------", m);
        Console.WriteLine("Name: {0,54}", mfn);
        Console.WriteLine("{0,60}", mln);
        Console.WriteLine("Age: {0,55}", ma);
        Console.WriteLine("Phone Number: {0,46}", mpn);
    }
}