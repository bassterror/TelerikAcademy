using System;

namespace MobilePhone
{
    public enum BatteryType
    {
        //Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
        Unknown,LiIon,NiMH,NiCd
    }
    public class Battery
    {
        //Define a class that holds information about battery characteristics (model, hours idle and hours talk)        
        private string model;
        private int idle;
        private int talk;
        //Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
        private BatteryType batType = new BatteryType();

        //Define several constructors for the defined classes that take different sets of arguments 
        //(the full information for the class or part of it).
        public Battery(string model, int idle, int talk, BatteryType batType)
        {
            this.model = model;
            this.idle = idle;
            this.talk = talk;
            this.batType = batType;
        }
        public Battery(string model, int idle, int talk)
            : this(model, idle, talk, new BatteryType())
        {            
        }
        public Battery(string model, int idle)
            : this(model, idle, 0, new BatteryType())
        {
        }
        public Battery(string model)
            : this(model, 0, 0, new BatteryType())
        {
        }
        public Battery()
            : this(null, 0, 0, new BatteryType())
        {
        }

        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
        //Ensure all fields hold correct data at any given time.
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Idle
        {
            get { return this.idle; }
            set { this.idle = value; }
        }
        public int Talk
        {
            get { return this.talk; }
            set { this.talk = value; }
        }
        public BatteryType BatType
        {
            get { return this.batType; }
            set { this.batType = value; }
        }

        //Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            return string.Format("Battery model: {0}\nBattery idle hours: {1}\nBattery talk hours: {2}\nBattery type: {3}",
                    this.model, this.idle, this.talk, this.batType);
        }
    }
}
