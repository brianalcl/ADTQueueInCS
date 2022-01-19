using System;
using System.Collections.Generic;
using System.Text;

namespace ADTQueue
{
    interface IQueue<E>
    {
        /*
         Devuelve la cantidad de elementos en la cola.
         */
        int Size();
        /*
         Consulta si la cola esta vacia.
         */
        bool IsEmpty();
        /*
         Retorna sin eliminar el primer elemento de la cola, 
        si la cola esta vacia se lanza una EmptyQueueException
         */
        E Front();
        /*
         Retorna y remueve el primer elemento de la cola,
        si la cola esta vacia se lanza una EmptyQueueException.
         */
        E Dequeue();
        /*
         Inserta un elemento a la cola.
         */
        void Enqueue(E element);
    }
}
