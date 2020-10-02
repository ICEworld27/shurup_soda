using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class ColaLabel : Label
    {
        public ColaLabel()
        {
            Console.WriteLine("Создали этикетку Кола");
        }

        public Label copy()
        {
            return new ColaLabel();
        }
    }

}

