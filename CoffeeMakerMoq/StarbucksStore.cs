using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarbucksStore
    {
        private readonly IMakeCoffee service;
        public StarbucksStore(IMakeCoffee service)
        {
            this.service = service;
        }
        public string OrderCoffee(int sugerPerSpon, int coffeCount)
        {
            if (service.CheckIngridentAvailability())
            {
                return service.CoffeeMaking(sugerPerSpon, coffeCount);
            }
            else
            {
                return "Sorry coffe is not prepare";
            }
        }
    }
}

