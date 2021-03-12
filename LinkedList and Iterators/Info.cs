/*
	Author: Leon Grell
*/
using System;

/*Info class. Output method gets registered to be called when a new car is added*/

namespace Revotap_LinkedList_Iterator
{
    class Info
    {
        public Info(Garage g)
        {
			/*Adding output method to the list of methods that get called when a NewCarEvent happened*/
            g.NewCarEvent += output;
        }
		
		/*Method output. Prints information about the event and the car that got added to the list. Only possible because car extends EventArg*/
        public void output(object sender, EventArgs args)
        {
            Car tmp = (Car)args;
            Console.Out.WriteLine("Info Event! : {0}", tmp.ToString());
        }
    }
}