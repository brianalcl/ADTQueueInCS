using System;

namespace ADTQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Console.WriteLine("Se asume que los datos ingresados son validos");
            Console.WriteLine("Coloque una opcion:");
            Console.WriteLine("1) Testeo basico");
            
            op = int.Parse(Console.ReadLine());
            
            switch (op)
            {
                case 1:
                    BasicTest();
                    break;
            }

            Console.ReadLine();
        }
        static void BasicTest()
        {
            IQueue<char> cola = new LinkedQueue<char>();

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Veamos el tamaño de la cola inicial: ");
            Console.WriteLine("cola.Size(): " + cola.Size());
            Console.WriteLine("cola.IsEmpty(): " + cola.IsEmpty());
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Colocamos a b c d e con cola.Enqueue(elem) y en cada caso vemos el size");

            for (char c = 'a'; c <= 'e'; c++)
            {
                cola.Enqueue(c);
                Console.WriteLine("cola.Size() con {0}: {1} ", c, cola.Size());
            }

            Console.WriteLine("cola.IsEmpty(): " + cola.IsEmpty());
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Veamos cual es el elemento en el frente de la cola sin sacarlo");
            try
            {
                Console.WriteLine("cola.Front(): " + cola.Front());
                Console.WriteLine("cola.Size(): " + cola.Size());
            }
            catch (EmptyQueueException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Mientras la cola no este vacia sacamos elementos uno a uno");
            Console.WriteLine("cola.IsEmpty(): " + cola.IsEmpty());
            while (!cola.IsEmpty())
            {
                Console.WriteLine("cola.Size(): {0}, cola.Dequeue(): {1}", cola.Size(), cola.Dequeue());
            }
            Console.WriteLine("cola.Size(): " + cola.Size());
            Console.WriteLine("cola.IsEmpty(): " + cola.IsEmpty());
            Console.WriteLine("--------------------------------------------------------------------------------");

        }
    }
}
