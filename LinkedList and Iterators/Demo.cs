using System;

namespace Revotap_LinkedList_Iterator
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo - LinkedList and Iterators");

            Garage park = new Garage();

            Car a1 = new Car("BMW", 2021);
            Car a2 = new Car();
            Car a3 = new Car("Audi", 2007);

            park.Add(a1);
            park.Add(a2);
            park.Add(a3);

            park.Inventory();

            Console.Out.WriteLine("Age of all vehicles: {0}", Math.Round(park.CalculateAge()));
        }
    }
}
