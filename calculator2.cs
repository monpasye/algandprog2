﻿using System;
class HelloWorld
{
    delegate double Nums(double x, double y, double z);
    static Nums Min = (x, y, z) => Math.Min(x, Math.Min(y, z));
    static Nums Max = (x, y, z) => Math.Max(x, Math.Max(y, z));
    static Nums Sum = (x, y, z) => x + y + z;
    static Nums Mean = (x, y, z) => (x + y + z) / 3;
    static Nums Prod = (x, y, z) => x * y * z;
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите 3 числа: ");
            try
            {
                var inp = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);
                Console.WriteLine(@"
Найти:
1. Минимальное число
2. Максимальное число
3. Сумму чисел
4. Произведение чисел
5. Среднее арифметическое
");
                var find = Console.ReadLine();
                switch (find)
                {
                    case "1":
                        Console.WriteLine($"min = {Min(inp[0], inp[1], inp[2])}");
                        break;

                    case "2":
                        Console.WriteLine($"max = {Max(inp[0], inp[1], inp[2])}");
                        break;

                    case "3":
                        Console.WriteLine($"sum = {Sum(inp[0], inp[1], inp[2])}");
                        break;

                    case "4":
                        Console.WriteLine($"prod = {Prod(inp[0], inp[1], inp[2])}");
                        break;

                    case "5":
                        Console.WriteLine($"mean = {Mean(inp[0], inp[1], inp[2])}");
                        break;
                }
            }
            catch (Exception) 
            { 
                Console.WriteLine("Некорректный ввод"); 
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
}