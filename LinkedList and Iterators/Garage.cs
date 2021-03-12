/*
	Author: Leon Grell
*/
using System;

namespace Revotap_LinkedList_Iterator
{
    class Garage
    {
        private LinkedList<Car> list = new LinkedList<Car>();

		/*Delegate a new event handler for new cars beeing added*/
		public delegate void NewCarEventHandler(object sender, EventArgs arg);
		
		/*Create an event object out of the new event handler*/
        public event NewCarEventHandler NewCarEvent;

        public void Add(Car a)
        {
            list.Add(a);
			
			/*Call a new car event with this and the car as parameter*/
			NewCarEvent(this, a);
        }

        public void Inventory()
        {
            Iterator<Car> iter = list.Iterator();

            while (iter.HasNext())
            {
                Car a1 = iter.Next();
                Console.Out.WriteLine("Manufacturer: {0}, Year: {1}", a1.getManufacturer(), a1.getManuYear());
            }
        }

        public double CalculateAge()
        {
            double sum = 0.0;
            int cnt = 0;
            Iterator<Car> iter = list.Iterator();
            while (iter.HasNext())
            {
                sum = sum + iter.Next().getManuYear();
                cnt++;
            }

            return sum/cnt;
        }
    }
}