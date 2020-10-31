using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaf = new Leaf(10);
            Console.WriteLine($"Leaf value : {leaf.Operation()}");

            var composite1 = new Composite();
            composite1.Add(new Leaf(10));
            composite1.Add(new Leaf(20));
            composite1.Add(new Leaf(30));
            Console.WriteLine($"Composite 1 value : {composite1.Operation()}");

            var composite2 = new Composite();
            composite2.Add(composite1);
            composite2.Add(new Leaf(10));
            composite2.Add(new Leaf(20));
            composite2.Add(new Leaf(30));
            Console.WriteLine($"Composite 2 value : {composite2.Operation()}");

            Console.ReadLine();
        }
    }
}
