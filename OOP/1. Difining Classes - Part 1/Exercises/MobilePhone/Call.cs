using System;
using System.Linq;

namespace MobilePhone
{
    public class Call
    {
        //Create a class Call to hold a call performed through a GSM.
        //It should contain date, time, dialed phone number and duration (in seconds).        
        private DateTime time;
        private string dialedNumber;
        private int duration;

        public Call(DateTime time, string dialedNumber, int duration)
        {
            this.time = time;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }
        
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public string DialedNumber 
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
