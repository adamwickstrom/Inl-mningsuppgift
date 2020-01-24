using System;
using System.Diagnostics; //tidtagarur

namespace Inlämning_bubblesort
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] bubble10 = new int[10]; //skapar en array med 10 element
            int[] bubble1000 = new int[1000];//skapar en array med 1000 element
            int[] bubble100000 = new int[100000];//skapar en array med 100000 element

            int[] insertion10 = new int[10];
            int[] insertion1000 = new int[1000];
            int[] insertion100000 = new int[100000];

            int[] merge10 = new int[10];
            int[] merge1000 = new int[1000];
            int[] merge100000 = new int[100000];

            int[] quick10 = new int[10];
            int[] quick1000 = new int[1000];
            int[] quick100000 = new int[100000];

            Random tal = new Random(); // skapar en random generator

            Stopwatch sw = new Stopwatch(); // skapar tidtagarur

            double frequency = Stopwatch.Frequency;
            double nanosecPerTick = (1000 * 1000 * 1000) / frequency;

            for (int i = 0; i < 10; i++)
            {
                bubble10[i] = tal.Next(0, 1000000); // slumpar ut talen
                insertion10[i] = tal.Next(0, 1000000);
                merge10[i] = tal.Next(0, 1000000);
                quick10[i] = tal.Next(0, 1000000);
            }

            for (int i = 0; i < 1000; i++)
            {
                bubble1000[i] = tal.Next(0, 1000000);
                insertion1000[i] = tal.Next(0, 1000000);
                merge1000[i] = tal.Next(0, 1000000);
                quick1000[i] = tal.Next(0, 1000000);
            }

            for (int i = 0; i < 100000; i++)
            {
                bubble100000[i] = tal.Next(0, 1000000);
                insertion100000[i] = tal.Next(0, 1000000);
                merge100000[i] = tal.Next(0, 1000000);
                quick100000[i] = tal.Next(0, 1000000);
            }

            
            Console.WriteLine("Bubblesort med 10 nummer"); //skriver ut vad som har testats 
            sw.Start();//startar tiden
            Bubblesort.BubbleSort(bubble10); //(klassnamn.metodnamn(arraynamn))
            sw.Stop();//stoppar tiden
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s"); //skriver ut tiden
            sw.Reset();//resetar tiden
            Console.ReadLine(); // Kräver enter för att gå vidare

            Console.WriteLine("Insertionsort med 10 nummer");
            sw.Start();
            Insertionsort.InsertionSort(insertion10);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort med 10 nummer");
            sw.Start();
            Mergesort.MergeSort(merge10);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Quicksort med 10 nummer");
            sw.Start();
            Quicksort.QuickSort(quick10);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Bubblesort med 1000 nummer");
            sw.Start();
            Bubblesort.BubbleSort(bubble1000);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Insertionsort med 1000 nummer");
            sw.Start();
            Insertionsort.InsertionSort(insertion1000);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort med 1000 nummer");
            sw.Start();
            Mergesort.MergeSort(merge1000);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Quicksort med 1000 nummer");
            sw.Start();
            Quicksort.QuickSort(quick1000);
            sw.Stop();
            int[] e = new int[1000];
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Bubblesort med 100000 nummer");
            sw.Start();
            Bubblesort.BubbleSort(bubble100000);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Insertionsort med 100000 nummer");
            sw.Start();
            Insertionsort.InsertionSort(insertion100000);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Mergesort med 100000 nummer");
            sw.Start();
            Mergesort.MergeSort(merge100000);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();

            Console.WriteLine("Quicksort med 100000 nummer");
            sw.Start();
            Quicksort.QuickSort(quick100000);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds + " s");
            sw.Reset();
            Console.ReadLine();
        }
    }
}
