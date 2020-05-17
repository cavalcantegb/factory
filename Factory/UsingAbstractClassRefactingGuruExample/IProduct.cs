using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica.Factory.UsingAbstractClassRefactingGuruExample
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IProduct
    {
        string Operation();
    }
}
