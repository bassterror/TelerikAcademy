using System;

namespace MobilePhone
{
    public class Display
    {
        //Define a class that holds information about display characteristics (size and number of colors).
        private int size; //example: 5.7
        private string colors; //example: 16M

        //Define several constructors for the defined classes that take different sets of arguments 
        //(the full information for the class or part of it).
        public Display(int size, string colors)
        {
            this.size = size;
            this.colors = colors;
        }
        public Display(int size)
            : this(size, null)
        { 
        }
        public Display()
            : this(0, null)
        { 
        }

        //Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
        //Ensure all fields hold correct data at any given time.
        public int Size
        {
            get { return this.size; }
            set 
            {
                if (value > 0 && value < int.MaxValue || value == null)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input!");
                }
            }
        }
        public string Colors
        {
            get { return this.colors; }
            set 
            {
                if (value.Length > 0 || value == null)
                {
                    this.colors = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input!");
                }
            }
        }

        //Add a method in the GSM class for displaying all information about it. Try to override ToString().
        public override string ToString()
        {
            return string.Format("Display size: {0}\nDisplay colors: {1}",
                    this.size, this.colors);
        }
    }
}
