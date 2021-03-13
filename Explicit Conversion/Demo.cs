/*
    Auhtor: Leon Grell
 */

using System;

namespace Revoap_Explicit_Conversion
{
    class Demo
    {
        static void Main(string[] args)
        {
            ClassA myObjekt = new ClassA();
            myObjekt.MyValue = 13;
            myObjekt.MyText = "Hello guys!";

            /*Explicit conversion to int*/
            int x = (int)myObjekt;

            /*Explicit conversion to string*/
            string str = (string)myObjekt;

            Console.WriteLine("X: {0}, STR: {1}", x, str);
        }
    }
}
