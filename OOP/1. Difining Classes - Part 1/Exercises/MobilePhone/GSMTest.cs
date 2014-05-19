using System;

namespace MobilePhone
{
    class GSMTest
    {        
        public void Testing()
        {
            //Write a class GSMTest to test the GSM class.
            //Create an array of few instances of the GSM class.
            GSM[] devices = new GSM[3];
            GSM device1 = new GSM("One X", "HTC", 589.99m, "MPP");
            devices[0] = device1;
            GSM device2 = new GSM("Lumia 810", "Nokia");
            device2.Price = 499.99M;
            device2.Owner = "OVI Store";
            device2.Battery.BatType = BatteryType.LiIon;
            devices[1] = device2;
            GSM device3 = GSM.IPhone4S;
            devices[2] = device3;
            //Display the information about the GSMs in the array.
            //Display the information about the static property IPhone4S.
            for (int i = 0; i < devices.Length; i++)
            {
                Console.WriteLine("Device {0}============", (i + 1));
                Console.WriteLine(devices[i]);
                Console.WriteLine();
            }
        }        
    }
}
