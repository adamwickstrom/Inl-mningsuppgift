using System;

namespace inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();
            int rand = generator.Next(1, 100);
            Console.WriteLine(rand);
            Console.WriteLine("gissa ett tal mellan 1 och 100!: ");
            int svar = Console.ReadLine();
            if (svar == rand) ;
        }
    }
}
