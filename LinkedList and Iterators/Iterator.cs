using System;

namespace Revotap_LinkedList_Iterator
{
    public interface Iterator<T>
    {
        public abstract Boolean HasNext();
        public abstract T Next();
    }
}