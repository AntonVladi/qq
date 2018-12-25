using System;

namespace PrimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var srv = new Prime.Services.PrimeService();

            var prim = srv.PrimeName("ANTON");

            Console.WriteLine($"PrimeName: {prim}");
        }
    }
}
