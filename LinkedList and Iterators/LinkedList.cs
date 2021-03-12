using System;

namespace Revotap_LinkedList_Iterator
{
    class LinkedList<T>
    {
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


        public ListIterator<T> Iterator()
        {
            return new ListIterator<T>(head, tail);
        }
    }
}