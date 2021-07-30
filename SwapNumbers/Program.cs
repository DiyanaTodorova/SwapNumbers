using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            (a, b) = (b, a);
            Console.WriteLine("a: "+ a);
            Console.WriteLine("b: "+ b);
        }
    }
}
