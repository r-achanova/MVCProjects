using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Model
{
   public class Garden
    {
        public Garden(decimal priceVegitables, decimal priceFruits, int kgVegitables, int kgFruits)
        {
            this.PriceVegitables = priceVegitables;
            this.PriceFruits = priceFruits;
            this.KgVegitables = kgVegitables;
            this.KgFruits = kgFruits;
        }

        public decimal PriceVegitables { get; set; }
        public decimal PriceFruits { get; set; }
        public int KgVegitables { get; set; }
        public int KgFruits { get; set; }

        public decimal CalculateSum()
        {
            return 1.94m * (this.KgFruits * this.PriceFruits + this.KgVegitables * PriceVegitables);
        }
    }
}
