using System;
using System.Collections.Generic;
using System.Text;

namespace fabrica
{
    interface Bottle
    {

        public void pourSoda(Soda soda);
        public void putLabel(Label label);
        public void seal(Closer closer);

        public Bottle copy();
    }
}
