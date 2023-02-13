using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Views
{
   public class Display
    {
        public decimal PriceVegitables { get; set; }
        public decimal PriceFruits { get; set; }
        public int KgVegitables { get; set; }
        public int KgFruits { get; set; }
        public decimal Total { get; set; }

        public Display()
        {
            this.PriceVegitables = 0;
            this.PriceFruits = 0;
            this.KgVegitables = 0;
            this.KgFruits = 0;
            this.GetValues();
        }

        public void GetValues()
        {
            this.PriceVegitables = decimal.Parse(Console.ReadLine());
            this.PriceFruits = decimal.Parse(Console.ReadLine());
            this.KgVegitables = int.Parse(Console.ReadLine());
            this.KgFruits = int.Parse(Console.ReadLine());
        }

        public void ShowResult()
        {
            Console.WriteLine(this.Total);
        }
    }
}
