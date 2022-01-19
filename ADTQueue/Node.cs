using System;
using System.Collections.Generic;
using System.Text;

namespace ADTQueue
{
    class Node<E>
    {
        private E element;
        private Node<E> next;
        public Node()
        {
            this.element = default;
            this.next = null;
        }
        public Node(E element)
        {
            this.element = element;
            this.next = null;
        }
        public Node(E element, Node<E> next)
        {
            this.element = element;
            this.next = next;
        }
        public void SetElement(E element)
        {
            this.element = element;
        }
        public void SetNext(Node<E> next)
        {
            this.next = next;
        }
        public E GetElement()
        {
            return this.element;
        }
        public Node<E> GetNext()
        {
            return next;
        }
    }
}

