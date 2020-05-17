using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica
{
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
