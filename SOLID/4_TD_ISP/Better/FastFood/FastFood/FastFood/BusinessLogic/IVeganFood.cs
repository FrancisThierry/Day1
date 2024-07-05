using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BusinessLogic
{
    public interface IVeganFood : IBaseFastFood
    {
        public double BoughtedSoyaByYear { get; set; }

    }
}
