using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BusinessLogic
{
    internal interface IBurgerFood : IBaseFastFood
    {
        public double BoughtedMeatByYear { get; set; }

    }
}
