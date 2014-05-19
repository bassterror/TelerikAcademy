using System;
using System.Linq;

namespace MobilePhone
{
    class MobilePhoneTest
    {
        static void Main()
        {
            Console.WriteLine("Which test do you want to perform?");
            Console.Write("Enter 1 for \"GSMTest\" and 2 for \"GSMCallHistoryTest\": ");
            byte input = byte.Parse(Console.ReadLine());
            if (input == 1)
            {
                GSMTest test1 = new GSMTest();
                test1.Testing();
                Console.WriteLine();
                Console.WriteLine("===============================================");
                Console.Write("Do you want to perform the other test?(y/n): ");
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'y')
                {
                    GSMCallHistoryTest test2 = new GSMCallHistoryTest();
                    test2.Testing();
                }
            }
            else if (input == 2)
            {
                GSMCallHistoryTest test2 = new GSMCallHistoryTest();
                test2.Testing();
                Console.WriteLine();
                Console.WriteLine("===============================================");
                Console.Write("Do you want to perform the other test?(y/n): ");
                char answer = char.Parse(Console.ReadLine());
                if (answer == 'y')
                {
                    GSMTest test1 = new GSMTest();
                    test1.Testing();
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
                Main();
            }
        }
    }
}
