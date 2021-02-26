using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> match = new MyDictionary<int>();
            Console.WriteLine(match.Count);
            match.Add(30);
            


            Console.WriteLine(match.Count);
         
        }
    }
}



