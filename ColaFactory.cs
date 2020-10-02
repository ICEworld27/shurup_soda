using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    class ColaFactory : SodaFactory
    {

       

         public Bottle createBottle()
        {
            return new ColaBottle();
        }

       
        public Soda createSoda()
        {
            return new ColaSoda();
        }
        public Label createLabel()
        {
            return new ColaLabel();
        }
        public Closer createCloser()
        {
            return new ColaCloser();
        }
    }
}

