using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class PepsiSoda : Soda
    {
        public PepsiSoda()
        {
            Console.WriteLine("Создали газировку Pepsi");
        }

        public Soda copy()
        {
            return new PepsiSoda();
        }
    }

}

