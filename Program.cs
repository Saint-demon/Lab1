using System;
using System.Collections.Generic;
using System.Net;

namespace Lab1
{
    class ProgramLab1
    {
        private static void Main()
        {
            Console.WriteLine("Выберите способ ввода массива:");
            Console.WriteLine("0:Ввод массива вручную;");
            Console.WriteLine("1:Чтение массива из файла");
            //TODO: размер массива
            int value = Convert.ToInt32(Console.ReadLine());


            int n = 9, min, max, even = 0;

            int[] arr = new int[10];
            int[] evenArr = new int[10];
            if (value == 0)
            {
                for (int i = 0; i < arr.Length; i++) //Ввод массива
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else if (value == 1)
            {
                //TODO: ввод из  файла
            }

            for (int i = 0; i < arr.Length; i++) //Вывод массива
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }

            min = arr[0];
            for (int i = 0; i < arr.Length; i++) //Поиск min
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
            for (int i = 0; i < arr.Length; i++) //Поиск max
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                    n = i;
                }
            }

            Console.WriteLine("Максимум");
            Console.WriteLine($"arr[{n}] = {max}");
            int sort;
            for (int i = 0; i < arr.Length; i++)//сортировка прямая
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sort = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sort;
                    }
                }
            }


            for (int i = 0; i < arr.Length; i++)//сортировка обратная
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        sort = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sort;
                    }
                }
            }

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    evenArr[even] = i;
                    even++;
                }

            }


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