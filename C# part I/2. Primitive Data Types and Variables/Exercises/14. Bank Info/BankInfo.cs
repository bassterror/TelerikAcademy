using System;

class BankInfo
{
    static void Main()
    {
        string name1 = "Mirolsav";
        string name2 = "Plamenov";
        string name3 = "Petrov";
        string bankname = "FIBank";
        string IBAN = "BG80 BNBG 9661 1020 3456 78";
        string BIC = "FINVBGSF";
        string cc1 = "4111 1111 1111 1111";
        string cc2 = "4111 1111 1111 1112";
        string cc3 = "4111 1111 1111 1113";
        ulong balance = 70596158453;
        Console.WriteLine("{0} {1} {2} has an account in {3} with the following credentials:", name1, name2, name3, bankname);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("SWIFT or BIC Code: {0}", BIC);
        Console.WriteLine("Three credit cards with numbers:\n{0},\n{1},\n{2};", cc1, cc2, cc3);
        Console.WriteLine("Balance: {0}lv.", balance);
    }
}
