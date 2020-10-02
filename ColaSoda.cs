using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class ColaSoda : Soda
    {
        public ColaSoda()
        {
            Console.WriteLine("Создали газировку Кола");
        }

        public Soda copy()
        {
            return new ColaSoda();
        }
    }

}

