using System;
using System.Collections.Generic;
using System.Linq;

namespace MobilePhone
{
    public class GSM
    {
        #region Fields
        //Define a class that holds information about a mobile phone device: 
        //model, manufacturer, price, owner and instances of the classes Battery and Display.
        private string model;
        private string manufacturer;                        
        private decimal price;
        private string owner;
        private Battery battery = new Battery();
        private Display display = new Display();                
        //Try to use the system class List<Call>.
        private List<Call> callHistory = new List<Call>();
        //Add a static field IPhone4S in the GSM class to hold the information about iPhone 4S.
        private static GSM iPhone4S = new GSM("Iphone 4S", "Apple", 999.99m, "Apple Store");
        #endregion

        #region Constructors
        //Define several constructors for the defined classes that take different sets of arguments 
        //(the full information for the class or part of it). Assume that model and manufacturer are 
        //mandatory (the others are optional). All unknown data fill with null.        
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, new Display())
        { 
        }
        public GSM(string model, string manufacturer ,decimal price, string owner)
            : this(model, manufacturer, price, owner, new Battery(), new Display())
        {
        }
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null, new Battery(), new Display())
        {
        }
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0m, null, new Battery(), new Display())
        {
        }
        #endregion  

        #region Properties
        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
        //Ensure all fields hold correct data at any given time.
        public string Model
        {
            get { return this.model; }
            set 
            {
                if (value.Length > 0 || value == null)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set 
            {
                if (value.Length > 0 || value == null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length > 0 || value == null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set 
            {
                if (value > 0 && value < decimal.MaxValue || value == null)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        //Add a static property IPhone4S.
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        //Add a property CallHistory in the GSM class to hold a list of the performed calls.
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
        #endregion

        #region Methods
        //Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            return string.Format("Model: {0}\nManufucturer: {1}\nOwner: {2}\nPrice: {3}\n{4}\n{5}",
                    this.model, this.manufacturer, this.owner, this.price, this.battery, this.display);
        }
        //Add methods in the GSM class for adding and deleting calls from the calls history.
        public void AddCall(DateTime time, string dialedNumber, int duration)
        {
            Call call = new Call(time, dialedNumber, duration);
            callHistory.Add(call);
        }
        public void RemoveCall(int index=0)
        {
            callHistory.RemoveAt(index);
        }
        //Remove the longest call from the history.
        public void RemoveLongestCall()
        {
            int longestCall = callHistory.Max(call => call.Duration);
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].Duration == longestCall)
                {
                    RemoveCall(i);
                }
            }
        }
        //Add a method to clear the call history.
        public void ClearHistory()
        {
            callHistory.Clear();
        }
        //Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
        public decimal CalcTotalCallPrice(decimal callPrice)
        {
            decimal total = 0;
            foreach (var call in callHistory)
            {
                total += (call.Duration / 60) * callPrice;
            }
            return total;
        }
        //Display the information about the calls.
        public void ShowCallHistory()
        {
            Console.WriteLine("Call history:");
            if (callHistory.Count == 0)
            {
                Console.WriteLine("Empty!");
            }
            else
            {                
                for (int i = 0; i < callHistory.Count; i++)
                {
                    Console.WriteLine("Call {0}: {1} - @{2} with {3} seconds duration",i + 1,callHistory[i].DialedNumber, callHistory[i].Time, callHistory[i].Duration);
                }    
            }
        }
        #endregion
    }
}
