/*
    Author: Leon Grell    
*/

using System;

namespace Vector_with_Operator_Overload
{
    class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector Test");

            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(2, 3, 4);
            Vector v3 = new Vector(3, 3, 3);

            Console.Out.WriteLine("v1: {0}", v1);
            Console.Out.WriteLine("v2: {0}", v2);
            Console.Out.WriteLine("v3: {0}", v3);
            Console.Out.WriteLine("v1 + v2: {0}", v1 + v2);
            Console.Out.WriteLine("v2 + 2: {0}", v2 + 2);
            Console.Out.WriteLine("-v3: {0}", -v3);
        }
    }
}
