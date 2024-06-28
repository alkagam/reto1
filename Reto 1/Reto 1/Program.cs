using System;
using System.Collections.Generic;
class Programa
{
    static List<string> FizzBuzz(int n)

    {
        List<string> result = new List<string>();
        for (int i = 1; i <= n; ++i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                result.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                result.Add("Buzz");
            }
            else
            {
                result.Add(i.ToString() + "");
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        int n = 100;
        Console.WriteLine("0");
        List<string> result = FizzBuzz(n);
        
        foreach(string s in result) 
        {
            Console.Write(s + "  \n");
        }
    }


}