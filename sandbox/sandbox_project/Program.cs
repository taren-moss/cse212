using System;
using Microsoft.VisualBasic;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        // I was sure this would work but I really wanted to test

        var set1 = new HashSet<int> {1, 2, 3, 4};
        var set2 = new HashSet<int> {3, 4, 5, 6};
        var union = new HashSet<int>();
        var intersection = new HashSet<int>();
        var test1 = set1.Union(set2);
        var test2 = set1.Intersect(set2);

        foreach (var item in set1) {
            union.Add(item);
        }
        foreach (var item in set2) {
            if (union.Contains(item)) {
                intersection.Add(item);
            }
            else {
                union.Add(item);
            }
        }

        Console.WriteLine("-Manual-");
        Console.Write("{");
        foreach (var item in union) {
            Console.Write($"{item}, ");
        }
        Console.Write("}");
        Console.WriteLine();
        
        Console.Write("{");
        foreach (var item in intersection) {
            Console.Write($"{item}, ");
        }
        Console.Write("}");
        Console.WriteLine();

        
        Console.WriteLine();
        Console.WriteLine("-Built In-");
        Console.Write("{");
        foreach (var item in test1) {
            Console.Write($"{item}, ");
        }
        Console.Write("}");
        Console.WriteLine();
        
        Console.Write("{");
        foreach (var item in test2) {
            Console.Write($"{item}, ");
        }
        Console.Write("}");
        Console.WriteLine();

        Console.WriteLine("Hello Sandbox World!");
    }
}