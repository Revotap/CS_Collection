/*
    Author: Leon Grell
 */

using System;

namespace Revoap_Explicit_Conversion
{
   class ClassA
    {
        public int MyValue = 0;
        public string MyText = "Hello World!";

        /*Explicit Conversion to int*/
        public static explicit operator int(ClassA x)
        {
            return x.MyValue;
        }

        /*Explicit Conversion to string*/
        public static explicit operator string(ClassA x)
        {
            return x.MyText;
        }
    }
}
