using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{    
    public interface IMakeCoffee
    {
        bool CheckIngridentAvailability();
        string CoffeeMaking(int sugarPerSpoon, int CoffeePack);
    }
}

