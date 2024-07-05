using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BusinessLogic
{
    public class BurgerKing : IBurgerFood
    {
        public double BoughtedMeatByYear { get; set; }
        public string? Company { get; set; }
        public string? City { get; set; }
    }
}
