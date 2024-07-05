using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BusinessLogic
{
    public class Zoe : Car
    {
        public Zoe(double _gasMileage) : base(_gasMileage)
        {
        }

        public override double GetGasMileagePrice()
        {
            throw new Exception("La zoe est un vehicule electrique");
        }
    }
}
