using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class PepsiFactory : SodaFactory
    {
        
       

         public Bottle createBottle()
        {
            return new PepsiBottle();
        }

       
        public Soda createSoda()
        {
            return new PepsiSoda();
        }
        public Label createLabel()
        {
            return new PepsiLabel();
        }
        public Closer createCloser()
        {
            return new PepsiCloser();
        }
    }
}

