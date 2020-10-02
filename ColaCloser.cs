using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class ColaCloser : Closer
    {
        public ColaCloser()
        {
            Console.WriteLine("Создали крышку Кола");
        }

        public Closer copy()
        {
            return new ColaCloser();
        }
    }

}

