using System;
using System.Threading;

public static class TextHelper {

    public static void TypeText(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
    }

 }





