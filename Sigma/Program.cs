using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Ice-cream", (float)23.40, (float)0.08);
            Buy b = new Buy(p, 10);
            Check.Output(p);
            Check.Output(b);

            Product p2 = new Product("Ice-cream", (float)-5, (float)-1);
            Buy b2 = new Buy(p2, 10);
            Check.Output(p2);
            Check.Output(b2);
            Console.ReadKey();
        }
    }
}