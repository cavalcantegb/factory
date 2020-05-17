using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Factory.UsaingInterface
{
    class ChocolateFactory : ISnackFactory
    {
        public ISnack CreateSnack() => new Chocolate();
        
    }
}
