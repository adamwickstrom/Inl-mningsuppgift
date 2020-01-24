using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämning_bubblesort
{
    class Bubblesort
    {
        public static void BubbleSort(int[] lista)
        {
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
        }
    }
}
