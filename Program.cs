using System;
using System.Net;

namespace Lab1
{
    class ProgramLab1
    {
        static void Main()
        {
            Console.WriteLine("Выберите способ ввода массивас:");
            Console.WriteLine("0:Ввод массива вручную;");
            Console.WriteLine("1:Чтение массива из файла");
            
            int value = Convert.ToInt32(Console.ReadLine());


            int n = 9, min, max, even = 0;        

            int[] arr = new int[10];
            int[] evenArr = new int[10];
            
            for (int i = 0; i < arr.Length; i++) //Ввод массива
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < arr.Length; i++) //Вывод массива
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            
            min = arr[0];
            for (int i = 0; i < 10; i++) //Поиск min
            {
                if (arr[i] <= min)
                {
                    min = arr[i];
                    n = i;
                }
            }
            Console.WriteLine("Минимум:");
            Console.WriteLine($"arr[{n}] = {min}");

            max = arr[0];
            for (int i = 0; i < 10; i++) //Поиск max
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                    n = i;
                }
            }
            Console.WriteLine("Максимум");
            Console.WriteLine($"arr[{n}] = {max}");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[even] = arr[i];
                    even++;
                }
            }
            //TODO: сюда 3ий пункт 

            for (int i = 0; i < arr.Length; i++)
            {
                if (evenArr[i] != 0)
                {
                    Console.WriteLine($"evenArr[{i}] = {evenArr[i]}");
                }
            }


        }

    }
}