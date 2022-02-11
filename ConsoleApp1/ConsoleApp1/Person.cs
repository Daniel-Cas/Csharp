using System;

namespace ConsoleApp1
{
    public class Person : BankAcount // Simply herency
    {
        public int Edad { get; set; }
        public string Nacionaliad { get; private set; }
        public string Ciudad { get; set; }
        public DateTime  ColorPelo { get; set; }

        public Person()
        {
            
        }
        // Destructor
        ~Person()
        {
            
        }

        public void getYears()
        {
            Console.WriteLine("Tengo " + this.Edad + " años");
        }
    }
}