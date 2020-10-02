using System;

namespace fabrica
{
    class Program
    {
        static void Main(string[] args)
        {


            SodaFactory factory = new PepsiFactory();
            SodaBuilder builder = new SodaBuilder(factory);
            builder.pourSoda();
            builder.putLabel();
            builder.seal();
            Bottle bottle1 = builder.build();
            Bottle bottle2 = builder.build();
            Console.WriteLine(bottle1 == bottle2);
            
        }
    }
}

