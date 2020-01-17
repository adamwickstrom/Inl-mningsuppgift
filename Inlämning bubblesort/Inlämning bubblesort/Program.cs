using System;

namespace BubbleSort
{
    class MySort
    {
        static void Main(string[] args)
        {
            int[] size = { 100, 1000, 10000 };
            int[] lista = randomNummer(size[1]);
            BubbleSort(lista);
        }
        static void BubbleSort(int[] lista)
        {
            DateTime starttid = DateTime.Now;
            for (int i = lista.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int high = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = high;
                    }
                }
            }
            TimeSpan tid = DateTime.Now - starttid;

            for(int f = 0; f < lista.Length; f++)
            {
                Console.WriteLine(lista[f]);
            }

            Console.WriteLine($"{tid.TotalSeconds}s");
        }
        static int[] randomNummer(int size)
        {
            Random slump = new Random();
            int[] nummer = new int[size];
            for (int i = 0; i < nummer.Length; i++) {
                nummer[i] = slump.Next(nummer.Length);
            }
            return nummer;          
        }

    }

   
}