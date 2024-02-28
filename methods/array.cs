using System;
class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine("Array\n\n" +
                "1. Length\n" +
                "2. Rank\n" +
                "3. BinarySearch\n" +
                "4. Clear\n" +
                "5. Copy\n" +
                "6. FindAll\n" +
                "7. Reverse\n" +
                "8. Sort\n" +
                "9. Выход\n");
            Array nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Array sort = new int[10] { 9, 0, 5, 4, 2, 7, 8, 6, 1, 3 };
            
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (number) {

                case 1:     //Length
                    Print(nums);
                    Console.WriteLine($"Длина массива равна {nums.Length}");
                    Ok();
                    break;

                case 2:     //Rank
                    Print(nums);
                    Console.WriteLine($"Размерность массива равна {nums.Rank}");
                    Ok();
                    break;

                case 3:     //BinarySearch
                    Console.Write("Найти элемент: ");
                    int BS = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Индекс найденного элемента равен {Array.BinarySearch(nums, BS)}");
                    Ok();
                    break;

                case 4:     //Clear
                    Console.Write("Исходный ");
                    Print(nums);
                    Array.Clear(nums);
                    Console.Write("Новый ");
                    Print(nums);
                    Ok();
                    break;

                case 5:     //Copy
                    Array copy = new int[10];
                    Console.Write("Исходный ");
                    Print(nums);
                    nums.CopyTo(copy, 0);
                    Console.Write("Новый ");
                    Print(copy);
                    Ok();
                    break;

                case 6:     //FindAll
                    Print(nums);
                    Console.Write("Найти элементы больше: ");
                    int inp = int.Parse(Console.ReadLine());
                    Array find = Array.FindAll((int[]) nums, x => x > inp);
                    Print(find);
                    Ok();
                    break;

                case 7:     //Reverse
                    Console.Write("Исходный ");
                    Print(nums);
                    Array.Reverse(nums);
                    Console.Write("Новый ");
                    Print(nums);
                    Ok();
                    break;

                case 8:     //Sort
                    Console.Write("Исходный ");
                    Print(sort);
                    Array.Sort(nums);
                    Console.Write("Новый ");
                    Print(nums);
                    Ok();
                    break;

                case 9:     //Выход
                    Menu = false;
                    break;

            }
            Console.Clear();
        } while (Menu);
    }
    static void Ok() {
        Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
        Console.ReadKey();
    }
    static void Print(Array Inp) {
        Console.WriteLine("Массив: ");
        foreach (int e in Inp) {
            Console.Write(e + " ");
        }
        Console.WriteLine();
    }
}