using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Factory.UsaingInterface
{
    class IceCream : ISnack
    {
        public bool IsRefrigirationRequired
        {
            get { return true; }
        }
        
        public void Eat()
        {
            Console.WriteLine(string.Format("Refrigiration Required? {0}", IsRefrigirationRequired));
            Console.WriteLine("Ice cream is cool and soft");
        }
    }
}
