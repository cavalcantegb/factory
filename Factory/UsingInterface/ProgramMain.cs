using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Factory.UsaingInterface
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            ISnackFactory snackFactory = LoadFactory("chocolate");

            ISnack snack = snackFactory.CreateSnack();
            snack.Eat();
            
        }

        private static ISnackFactory LoadFactory(string snack)
        {
            switch(snack)
            {
                case "icecream":
                    return new IceCreamFactory();
                default:
                    return new ChocolateFactory();
            }
        }

    }
}
