// See https://aka.ms/new-console-template for more information
using System;

namespace KolekcjeZadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzę tablicę z 10 dowolnymi liczbami
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // 1. Wypisuje liczby używając pętli for
            Console.WriteLine("Pętla for:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Liczba: " + numbers[i]);
            }
            Console.WriteLine();
            // 2. Wypisujemy liczby używając pętli foreach
            Console.WriteLine("Pętla foreach:");
            foreach (int number in numbers)
            {
                Console.WriteLine("Liczba: " + number);
            }
            Console.WriteLine();
            // 3. Wypisuję liczby używając pętli while
            Console.WriteLine("Pętla while:");
            int index = 0;
            while (index < numbers.Length)
            {
                Console.WriteLine("Liczba: " + numbers[index]);
                index++;
            }
            Console.ReadKey();
        }
    }
}

