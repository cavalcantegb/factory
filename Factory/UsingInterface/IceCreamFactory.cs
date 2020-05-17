using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Factory.UsaingInterface
{
    class IceCreamFactory : ISnackFactory
    {
        public ISnack CreateSnack() => new IceCream();

    }
}
