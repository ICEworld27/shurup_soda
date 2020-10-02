using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class PepsiBottle : Bottle
    {

        private Soda soda = null;
        private Label label = null;
        private Closer closer = null;

        public PepsiBottle()
        {
           Console.WriteLine("Создали бутылку Pepsi");
        }
        public void pourSoda(Soda soda)
        {
            if (closer == null)
            {
                this.soda = soda;
                Console.WriteLine("Налили газировку");
            }
            else
            {
                Console.WriteLine("Бутылка закрыта");
            }
        }

        public void putLabel(Label label)
        {
            this.label = label;
            Console.WriteLine("Наклеили этикетку");
        }

        public void seal(Closer closer)
        {
            this.closer = closer;
            Console.WriteLine("Закрыли крышкой");
        }
        public Bottle copy()
        {
            PepsiBottle result = new PepsiBottle();
            result.soda = soda.copy();
            result.label = label.copy();
            result.closer = closer.copy();
            return result;
        }
    }
}

