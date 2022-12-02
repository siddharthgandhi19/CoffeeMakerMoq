using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class Starbucks : IMakeCoffee
    {
        public bool CheckIngridentAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int CoffeePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarbucks : IMakeCoffee
    {
        public bool CheckIngridentAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int CoffeePack)
        {
            return "Your Order is received";
        }
    }
    public class FakeStarbucks : IMakeCoffee
    {
        public bool CheckIngridentAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int CoffeePack)
        {
            return "Your Order is received";
        }
    }
}
