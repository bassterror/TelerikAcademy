using System;
using System.Linq;
using System.Threading;

namespace MobilePhone
{
    class GSMCallHistoryTest
    {
        //Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        public void Testing()
        {
            //Create an instance of the GSM class.
            GSM device = new GSM("One X", "HTC");
            //Add few calls.
            device.AddCall(DateTime.Now, "0888888888", 569);
            device.AddCall(new DateTime(2013, 2, 16), "0899999999", 158);
            device.AddCall(new DateTime(2013, 2, 12), "0878777777", 65);
            device.AddCall(new DateTime(2013, 2, 13), "0878555555", 38);
            device.AddCall(new DateTime(2013, 2, 14), "0886444444", 147);
            device.AddCall(new DateTime(2013, 2, 14), "0899222222", 253);
            Console.WriteLine(device.ToString());
            //Display the information about the calls.
            device.ShowCallHistory();
            //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            device.CalcTotalCallPrice(0.37M);
            //Remove the longest call from the history and calculate the total price again.
            device.RemoveLongestCall();
            device.CalcTotalCallPrice(0.37M);
            //Finally clear the call history and print it.
            Console.WriteLine("Clearing call history:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("-");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            device.ClearHistory();
            device.ShowCallHistory();
        }
    }
}
