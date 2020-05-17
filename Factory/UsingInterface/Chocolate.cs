using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Factory.UsaingInterface
{
    class Chocolate : ISnack
    {
        public bool IsRefrigirationRequired
        {
            get { return false; }
        }
        public void Eat()
        {
            Console.WriteLine(string.Format("Refrigiration Required? {0}", IsRefrigirationRequired));
            Console.WriteLine("Chocolate is sweet and yummy");
        }
    }
}
