using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var s = new Strawberry();
            var m = new Mango();

            Console.WriteLine(b.Blend());
            Console.WriteLine(s.Blend());
            Console.WriteLine(m.Blend());

            List<Fruit> fruits = new List<Fruit>() { b, s, m };
            
            foreach(Fruit f in fruits)
            {
                Console.WriteLine(f.Blend());
            }

        }
    }
}
