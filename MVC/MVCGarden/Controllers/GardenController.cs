using MVCGarden.Model;
using MVCGarden.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Controllers
{
    public class GardenController
    {
        private Display display;
        private Garden garden;

        public GardenController()
        {
            display = new Display();
            garden = new Garden(display.PriceVegitables, display.PriceFruits, display.KgVegitables, display.KgFruits);
            display.Total = garden.CalculateSum();
            display.ShowResult();
        }
    }
}
