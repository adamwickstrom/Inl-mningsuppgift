using System;

namespace inlamningsuppgift_metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie = 2.4;
            Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
            Console.WriteLine("Cirkelns area: " + CirkelArea(radie));
        }


        static double CirkelOmkrets(double radie)
        {
           return (2 * radie * 3.14);  
        }
        
        static double CirkelArea(double radie)
        {
            return (radie * radie * 3.14);
        }




    }




}
