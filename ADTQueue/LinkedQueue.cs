using System;
using System.Collections.Generic;
using System.Text;

namespace ADTQueue
{
    class LinkedQueue<E> : IQueue<E>
    {
        protected Node<E> head;
        protected Node<E> tail;
        protected int size;

        public LinkedQueue()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public int Size()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public void Enqueue(E element)
        {
            Node<E> nodo = new Node<E>(element, null);
            if (head == null)
                head = nodo;
            else
                tail.SetNext(nodo);
            tail = nodo;
            size++; 
        }
        public E Front()
        {
            if (head == null)
                throw new EmptyQueueException("Error: no se puede mostrar el primer elemento de una cola vacia");
            return head.GetElement();
        }
        public E Dequeue()
        {
            if (head == null)
                throw new EmptyQueueException("Error: no se puede sacar el primer elemento de una cola vacia");
            E rta = head.GetElement();
            head = head.GetNext();
            size--;
            if (size == 0)
                tail = null;
            return rta;
        }
    }
}
