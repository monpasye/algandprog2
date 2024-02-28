﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"List
    1. Add
    2. AddRange
    3. BinarySearch
    4. CopyTo
    5. Contains
    6. Clear
    7. Exists
    8. FindAll
    9. IndexOf
    10. GetRange
    11. InsertRange
    12. Remove
    13. RemoveRange
    14. RemoveAll
    15. Reverse
    16. Sort
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            List<string> list = new List<string>() { "www", "0", "$", "#", "&", "3.14", "*", "@", "1", "^", "abc", "2.7", "%", "Aa", "", "-" };
            switch (number) {

                case 1:     //Add
                    Print("Old ", list);
                    list.Add(Console.ReadLine());
                    Print("New ", list);
                    Ok();
                    break;

                case 2:     //AddRange
                    Print("Old ", list);
                    list.AddRange(Console.ReadLine().Split());
                    Print("New ", list);
                    Ok();
                    break;

                case 3:     //BinarySearch
                    list.Sort();
                    Print("", list);
                    Console.WriteLine($"{list.BinarySearch("1")}");
                    Ok();
                    break;

                case 4:     //CopyTo
                    Print("", list);
                    var copy = new string[list.Count];
                    list.CopyTo(copy);
                    print("", copy);
                    Ok();
                    break;

                case 5:     //Contains
                    Print("", list);
                    Console.WriteLine(list.Contains(Console.ReadLine()));;
                    Ok();
                    break;

                case 6:     //Clear
                    Print("Old ", list);
                    list.Clear();
                    Print("New ", list);
                    Ok();
                    break;

                case 7:     //Exists
                    Print("", list);
                    string ex = Console.ReadLine();
                    Console.WriteLine(list.Exists(x => x == ex));
                    Ok();
                    break;

                case 8:     //FindAll
                    Print("Old ", list);
                    string fa = Console.ReadLine();
                    var find = list.FindAll(x => x == fa);
                    Print("New ", find);
                    Ok();
                    break;

                case 9:     //IndexOf
                    Print("", list);
                    Console.WriteLine(list.IndexOf(Console.ReadLine()));
                    Ok();
                    break;

                case 10:     //GetRange
                    Print("Old ", list);
                    Console.Write("Индекс: ");
                    int gr = int.Parse(Console.ReadLine());
                    Console.Write("Количество: ");
                    Print("New ", list.GetRange(gr, int.Parse(Console.ReadLine())));
                    Ok();
                    break;

                case 11:     //InsertRange
                    Print("Old ", list);
                    Console.Write("Индекс: ");
                    int ir = int.Parse(Console.ReadLine());
                    list.InsertRange(ir, Console.ReadLine().Split());
                    Print("New ", list);
                    Ok();
                    break;

                case 12:     //Remove
                    Print("Old ", list);
                    Console.WriteLine(list.Remove(Console.ReadLine()));
                    Print("New ", list);
                    Ok();
                    break;

                case 13:     //RemoveRange
                    Print("Old ", list);
                    Console.Write("Индекс: ");
                    int rr = int.Parse(Console.ReadLine());
                    Console.Write("Количество удаляемых элементов: ");
                    list.RemoveRange(rr,int.Parse(Console.ReadLine()));
                    Print("New ", list);
                    Ok();
                    break;

                case 14:     //RemoveAll
                    Print("Old ", list);
                    string ra = Console.ReadLine();
                    Console.WriteLine($"Количество удаленных элементов: {list.RemoveAll(x => x == ra)}");
                    Print("New ", list);
                    Ok();
                    break;

                case 15:     //Reverse
                    Print("Old ", list);
                    list.Reverse();
                    Print("New ", list);
                    Ok();
                    break;

                case 16:     //Sort
                    Print("Old ", list);
                    list.Sort();
                    Print("New ", list);
                    Ok();
                    break;

                case 0:     //Exit
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
    static void Print(string Age, List<string> Inp) {
        Console.WriteLine($"{Age}List: \n{String.Join(", ", Inp)}");
    }
    static void print(string Age, string[] Inp) {
        Console.WriteLine($"{Age}Array: \n{String.Join(", ", Inp)}");
    }
}