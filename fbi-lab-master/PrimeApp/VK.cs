using System;

namespace PrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var srv = new Prime.Services.PrimeService();

            var prim = srv.PrimeName("А Саша молодец");

            Console.WriteLine($"PrimeName: {prim}");

            Console.ReadLine();
        }
    }
}
