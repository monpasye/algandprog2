﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine("ArrayList\n\n" +
                "1. Add\n" +
                "2. Clear\n" +
                "3. Contains\n" +
                "4. CopyTo\n" +
                "5. GetRange\n" +
                "6. IndexOf\n" +
                "7. Insert\n" +
                "8. LastIndexOf\n" +
                "9. Remove\n" +
                "10. RemoveAt\n" +
                "11. RemoveRange\n" +
                "12. Reverse\n" +
                "13. Sort\n" +
                "14. Выход\n");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            ArrayList list = new ArrayList() {"", 0, '$', 0, '#', '&', 3.14, '*', '@', 1,'^', "abc", 2.7, ' ', "%"};

            switch (number) {

                case 1:     //Add
                    Print("Old", list);
                    list.Add(Console.ReadLine());
                    Print("New", list);
                    Ok();
                    break;

                case 2:     //Clear
                    Print("Old", list);
                    list.Clear();
                    Print("New", list);
                    Ok();
                    break;

                case 3:     //Contains
                    Print("", list);
                    Str(list);
                    Console.WriteLine(list.Contains(Console.ReadLine()));
                    Ok();
                    break;

                case 4:     //CopyTo
                    Print("Old", list);
                    Str(list);
                    Array copy = new string[list.Count];
                    list.CopyTo(copy);
                    print("New", copy);
                    Ok();
                    break;

                case 5:     //GetRange
                    Print("Old", list);
                    ArrayList get = new ArrayList();
                    Console.WriteLine("GetRange: ");
                    Console.Write(" Start: ");
                    int getr = int.Parse(Console.ReadLine());
                    Console.Write(" Count: ");

                    get = list.GetRange(getr, int.Parse(Console.ReadLine()));
                    Print("New", get);
                    Ok();
                    break;

                case 6:     //IndexOf
                    Print("", list);
                    Str(list);
                    Console.Write("Index of: ");
                    Console.WriteLine(list.IndexOf(Console.ReadLine()));
                    Ok();
                    break;

                case 7:     //Insert
                    Print("Old", list);
                    Console.WriteLine("Insert: ");
                    Console.Write(" Index: ");
                    int ind = int.Parse(Console.ReadLine());
                    Console.Write(" Value: ");

                    list.Insert(ind, Console.ReadLine());
                    Print("New", list);
                    Ok();
                    break;

                case 8:     //LastIndexOf
                    Print("", list);
                    Str(list);
                    Console.Write("LastIndex of: ");
                    Console.WriteLine(list.LastIndexOf(Console.ReadLine()));
                    Ok();
                    break;

                case 9:     //Remove
                    Print("Old", list);
                    Str(list);
                    list.Remove(Console.ReadLine());
                    Print("New", list);
                    Ok();
                    break;

                case 10:     //RemoveAt
                    Print("Old", list);
                    Console.Write("Remove at: ");
                    int at = int.Parse(Console.ReadLine());
                    list.RemoveAt(at);
                    Print("New", list);
                    Ok();
                    break;

                case 11:     //RemoveRange
                    Print("Old", list);
                    Console.WriteLine("Remove(range): ");
                    Console.Write(" Start: ");
                    int start = int.Parse(Console.ReadLine());
                    Console.Write(" End: ");
                    int end = int.Parse(Console.ReadLine());

                    list.RemoveRange(start, end);
                    Print("New", list);
                    Ok();
                    break;

                case 12:     //Reverse
                    Print("Old", list);
                    list.Reverse();
                    Print("New", list);
                    Ok();
                    break;

                case 13:     //Sort
                    Print("Old", list);
                    list.Sort();
                    Print("New", list);
                    Ok();
                    break;

                case 14:     //Exit
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
    static void Print(string Age, ArrayList Inp) {
        Console.WriteLine($"{Age} ArrayList: ");
        foreach (var e in Inp) {
            Console.Write($"{e} ");
        }
        Console.WriteLine();
    }
    static void print(string Age, Array Inp) {
        Console.WriteLine($"{Age} Array: ");
        foreach (var e in Inp) {
            Console.Write($"{e} ");
        }
        Console.WriteLine();
    }
    static ArrayList Str(ArrayList Inp) {
        for (int i = 0; i < Inp.Count; i++) {
            Inp[i] = Convert.ToString(Inp[i]);
        }
        return Inp;
    }
}