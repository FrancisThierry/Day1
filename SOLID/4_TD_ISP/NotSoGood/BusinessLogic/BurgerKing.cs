using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoGood.BusinessLogic
{
    public class BurgerKing : IFastFood
    {
        public double BoughtedMeatByYear { get ; set ; }
        public string? Company { get ; set ; }
        public string? City { get ; set ; }
    }
}
