/*
	Author: Leon Grell
	Description: Single chained linked list of generic type T. Features a special ListIterator created from the interface interator.cs
*/
using System;

namespace Revotap_LinkedList_Iterator
{
    class LinkedList<T>
    {
		/*Inner class Link only used inside the LinkedList*/
        public class Link<E>
        {
            private E data;
            private Link<E> next;

            public Link(E n_data)
            {
                data = n_data;
            }
            public E get()
            {
                return data;
            }
            public Link<E> getNext()
            {
                return next;
            }
            public void setNext(Link<E> n_link)
            {
                next = n_link;
            }
        }

		/*Inner class ListIterator*/
        public class ListIterator<G> : Iterator<G>
        {
            private Link<G> pointer;
            private Link<G> tail;

            public ListIterator(Link<G> n_head, Link<G> n_tail){
                pointer = n_head;
                tail = n_tail;
            }
            public Boolean HasNext()
            {
                if (pointer == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public G Next()
            {
                Link<G> tmp = pointer;
                pointer = pointer.getNext();
                return tmp.get();             
            }
        }

        private Link<T> head;
        private Link<T> tail;

		/*Add data to the end of the list*/
        public int Add(T data)
        {
            if(head == null)
            {
                head = new Link<T>(data);
                tail = head;
            }
            else
            {
                tail.setNext(new Link<T>(data));
                tail = tail.getNext();
            }
            return 1;
        }

		/*Remove element on position i*/
        public int Remove(int i)
        {
            if(head == null)
            {
                return 0;
            }

            Link<T> pointer = head;

            if(i == 0)
            {
                head = head.getNext();
                return 1;
            }

            for(int index=0; pointer != null && index < i-1; index++)
            {
                pointer = pointer.getNext();
            }
            
            if(pointer == null || pointer.getNext() == null)
            {
                return 0;
            }

            pointer.setNext(pointer.getNext().getNext());

            return 1;
        }

		/*Returns a new iterator object of type ListIterator<T>*/
        public ListIterator<T> Iterator()
        {
            return new ListIterator<T>(head, tail);
        }
    }
}