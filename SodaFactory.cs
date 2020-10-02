using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    interface SodaFactory
    {

        public Bottle createBottle();
        public Soda createSoda();
        public Label createLabel();
        public Closer createCloser();
        

    }
}
