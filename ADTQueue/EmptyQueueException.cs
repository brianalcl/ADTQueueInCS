using System;
using System.Collections.Generic;
using System.Text;

namespace ADTQueue
{
    class EmptyQueueException : Exception
    {
        public EmptyQueueException(string msg) : base(msg)
        {

        }
    }
}
