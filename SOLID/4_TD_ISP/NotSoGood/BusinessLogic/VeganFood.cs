using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSoGood.BusinessLogic
{
    public class VeganFood : IFastFood
    {
        public double BoughtedMeatByYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Company { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
