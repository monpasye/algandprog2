﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"Dictionary
    1. Add
    2. Clear
    3. ContainsKey
    4. ContainsValue
    5. CopyTo
    6. Remove
    7. TryAdd
    8. Count
    9. GetType
    10. Equals
    11. Keys
    12. Values
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Dictionary<string, string> Dict = new Dictionary<string, string>() {
                {"www", "0" }, {"$", "#" }, {"&", "3.14" }, {"*", "@" },
                {"1", "^" }, {"abc", "2.7" }, {"%", "Aa" }, {"", "-" }
            };

            switch (number) {

                case 1:     //Add
                    Print("Old ", Dict);
                    Console.Write("key=");
                    string add = Console.ReadLine();
                    Console.Write("value=");
                    Dict.Add(add, Console.ReadLine());
                    Print("New ", Dict);
                    Ok();
                    break;

                case 2:     //Clear
                    Print("Old ", Dict);
                    Dict.Clear();
                    Print("New ", Dict);
                    Ok();
                    break;

                case 3:     //ContainsKey
                    Print("", Dict);
                    Console.WriteLine(Dict.ContainsKey(Console.ReadLine()));
                    Ok();
                    break;

                case 4:     //ContainsValue
                    Print("", Dict);
                    Console.WriteLine(Dict.ContainsValue(Console.ReadLine()));
                    Ok();
                    break;

                case 5:     //CopyTo
                    Print("Old ", Dict);
                    Array copy = new string[Dict.Count];
                    Console.Write("Keys or Values (k/v): ");
                    string kov = Console.ReadLine();
                    if (kov == "k") Dict.Keys.CopyTo((string[])copy, 0);
                    else Dict.Values.CopyTo((string[])copy, 0);
                    print("New ", copy);
                    Ok();
                    break;

                case 6:     //Remove
                    Print("Old ", Dict);
                    Dict.Remove(Console.ReadLine());
                    Print("New ", Dict);
                    Ok();
                    break;

                case 7:     //TryAdd
                    Print("Old ", Dict);
                    Console.Write("key=");
                    string tr = Console.ReadLine();
                    Console.Write("value=");
                    Console.WriteLine(Dict.TryAdd(tr, Console.ReadLine()));
                    Print("New ", Dict);
                    Ok();
                    break;

                case 8:     //Count
                    Print("", Dict);
                    Console.WriteLine(Dict.Count);
                    Ok();
                    break;

                case 9:     //GetType
                    Print("", Dict);
                    Console.WriteLine(Dict.GetType); 
                    Ok();
                    break;

                case 10:     //Equals
                    Print("1 ", Dict);
                    Dictionary<string, string> equ = new Dictionary<string, string>() {
                        {"www", "0" }, {"$", "#" }, {"&", "3.14" }, {"*", "@" },
                        {"1", "^" }, {"abc", "2.7" }, {"%", "Aa" }, {"", "-" }
                    };
                    Print("2 ", equ);
                    Console.WriteLine(Dict.Equals(equ));
                    Ok();
                    break;

                case 11:     //Keys
                    Print("", Dict);
                    kprint("Keys", Dict.Keys);
                    Ok();
                    break;

                case 12:     //Values
                    Print("", Dict);
                    vprint("Values", Dict.Values);
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
    static void Print(string Age, Dictionary<string, string> Inp) {
        Console.WriteLine($"{Age}SortedList: ");
        foreach (KeyValuePair<string,string> e in Inp) {
            Console.WriteLine($"{e.Key}={e.Value} ");
        }
        Console.WriteLine();
    }
    static void print(string Age, Array Inp) {
        Console.WriteLine($"{Age}Array: \n{String.Join(", ", Inp)}");
    }
    static void vprint(string W, Dictionary<string,string>.ValueCollection Inp) {
        Console.WriteLine($"{W}: \n{String.Join(", ", Inp)}");
    }
    static void kprint(string W, Dictionary<string,string>.KeyCollection Inp) {
        Console.WriteLine($"{W}: \n{String.Join(", ", Inp)}");
    }
}