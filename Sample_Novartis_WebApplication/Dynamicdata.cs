using System;

namespace dddata
{
    public class Dynamicdata
    {
        
        public string nofusers()
        {

            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            return month.ToString();
        }
        public Dynamicdata() { Console.WriteLine("Constructor Test"); }


    }
}
