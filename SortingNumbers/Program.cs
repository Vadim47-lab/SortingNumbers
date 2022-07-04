using System;

namespace SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Добро пожаловать в программу: Сортировка чисел!");

            Random random = new Random();
            int initialNumber = 0;
            int finitNumber = 20;
            int[] numbers = new int[finitNumber];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(initialNumber, finitNumber);
            }

            Console.WriteLine("\n Неотсортированный массив, состоящий из " + numbers.Length + " чисел numbers = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int t = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = t;
                    }
                }
            }

            Console.WriteLine("\n\n Отсортированный массив, состоящий из " + numbers.Length + " чисел numbers = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" " + numbers[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}