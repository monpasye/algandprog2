﻿using System;
using System.Collections;
using System.Collections.Generic;

class HelloWorld {
    static void Main() {
        bool Menu = true;
        do {
            Console.WriteLine(@"Queue
    1. Clear
    2. Contains
    3. CopyTo
    4. Count
    5. Equals
    6. GetType
    7. Peek
    8. Dequeue
    9. Enqueue
    10. ToArray
    11. TryPeek
    12. TryDequeue
    0. EXIT
                ");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            var list = new List<string>() { "www", "0", "$", "#", "&", "3.14", "*", "@", "1", "^", "abc", "2.7", "%", "Aa", "", "-" };
            Queue<string> queue = new Queue<string>(list);
            string res = "";
            switch (number) {

                case 1:     //Clear
                    Print("Old ", queue);
                    queue.Clear();
                    Print("New ", queue);
                    Ok();
                    break;

                case 2:     //Contains
                    Print("", queue);
                    Console.WriteLine(queue.Contains(Console.ReadLine()));
                    Ok();
                    break;

                case 3:     //CopyTo
                    Print("", queue);
                    string[] copy = new string[queue.Count];
                    queue.CopyTo(copy, 0);
                    print("", copy);
                    Ok();
                    break;

                case 4:     //Count
                    Print("", queue);
                    Console.WriteLine(queue.Count);
                    Ok();
                    break;

                case 5:     //Equals
                    Print("1 ", queue);
                    Queue<string> eqq = new Queue<string>(list);
                    Print("2 ", eqq);
                    Console.WriteLine(queue.Equals(eqq));
                    Ok();
                    break;

                case 6:     //GetType
                    Print("", queue);
                    Console.WriteLine(queue.GetType());
                    Ok();
                    break;

                case 7:     //Peek
                    Print("Old ", queue);
                    Console.WriteLine(queue.Peek());
                    Print("New ", queue);
                    Ok();
                    break;

                case 8:     //Dequeue
                    Print("Old ", queue);
                    Console.WriteLine(queue.Dequeue());
                    Print("New ", queue);
                    Ok();
                    break;

                case 9:     //Enqueue
                    Print("Old ", queue);
                    queue.Enqueue(Console.ReadLine());
                    Print("New ", queue);
                    Ok();
                    break;

                case 10:     //ToArray
                    Print("Old ", queue);
                    print("New ", queue.ToArray());
                    Ok();
                    break;

                case 11:     //TryPeek
                    Print("Old ", queue);
                    queue.TryPeek(out res);
                    Console.WriteLine($"Peek: {res}");
                    Print("New ", queue);
                    Ok();
                    break;

                case 12:     //TryDequeue
                    Print("Old ", queue);
                    queue.TryDequeue(out res);
                    Console.WriteLine($"Dequeue: {res}");
                    Print("New ", queue);
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
    static void Print(string Age, Queue<string> Inp) {
        Console.WriteLine($"{Age}Queue: \n{String.Join(", ", Inp)}");
    }
    static void print(string Age, string[] Inp) {
        Console.WriteLine($"{Age}Array: \n{String.Join(", ", Inp)}");
    }
}