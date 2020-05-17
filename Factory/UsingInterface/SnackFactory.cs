using Fabrica.Factory.UsaingInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Factory.UsingInterface
{
    class SnackFactory
    {

        public static ISnackFactory LoadSnack(string snack)
        {
            switch (snack)
            {
                case "icecream":
                    return new IceCreamFactory();
                default:
                    return new ChocolateFactory();
            }
        }
    }
}
