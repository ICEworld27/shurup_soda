using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class PepsiCloser : Closer
    {
        public PepsiCloser()
        {
            Console.WriteLine("Создали крышку Pepsi");
        }

        public Closer copy()
        {
            return new PepsiCloser();
        }
    }

}

