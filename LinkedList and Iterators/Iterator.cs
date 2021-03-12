/*
	Author: Leon Grell
	Description: Interface Iterator<T> to be used on an LinkedList
*/
using System;

namespace Revotap_LinkedList_Iterator
{
    public interface Iterator<T>
    {
        public abstract Boolean HasNext();
        public abstract T Next();
    }
}