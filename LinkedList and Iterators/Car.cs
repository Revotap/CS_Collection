/*
	Author: Leon Grell
*/
using System;

namespace Revotap_LinkedList_Iterator
{
	/*Added class car to EventArgs to use it as a parameter in the call of a NewCarEvent*/
    class Car : EventArgs
    {
        private String _manufacturer;
        private double _manu_year;

        public Car(String n_manufacturer = "Unknown" , double n_manu_year = 0)
        {
            _manufacturer = n_manufacturer;
            _manu_year = n_manu_year;
        }

        public String getManufacturer()
        {
            return _manufacturer;
        }

        public void setManufacturer(String n_manufacturer)
        {
            _manufacturer = n_manufacturer;
        }

        public double getManuYear()
        {
            return _manu_year;
        }

        public void setManuYear(double n_manu_year)
        {
            _manu_year = n_manu_year;
        }
        public override String ToString()
        {
            return "Manufacturer: " + _manufacturer + ", Manufactoring Year: " + _manu_year;
        }

    }
}