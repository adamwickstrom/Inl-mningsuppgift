using System;

namespace inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();
            int rand = generator.Next(1, 100), gissningar = 0;
            Console.WriteLine("gissa ett tal mellan 1 och 100!: ");
            int tal = Convert.ToInt32(Console.ReadLine());
            while (tal != rand)
            {
                if (tal < rand) 


                {
                    Console.WriteLine("För lågt!");
                }

                else if (tal > rand) 


                {
                    Console.WriteLine("för stort!");
                }

                tal = Convert.ToInt32(Console.ReadLine());
                gissningar++;

            }

            Console.WriteLine("Du gissade rätt!");
            Console.WriteLine("Du gissade " + gissningar + " gånger");
        }   

    }
}
