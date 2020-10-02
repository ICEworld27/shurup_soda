using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class PepsiLabel : Label
    {
        public PepsiLabel()
        {
            Console.WriteLine("Создали этикетку Pepsi");
        }

        public Label copy()
        {
            return new PepsiLabel();
        }
    }

}

