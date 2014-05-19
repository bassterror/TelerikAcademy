using System;

class MyGender
{
    static void Main()
    {
        string mygender = "Male";
        string check = "Female";
        bool isFemale = (mygender == check);
        Console.WriteLine("Am I female?\n{0}", isFemale);

    }
}
