using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BusinessLogic
{
    public  class CarWithGasoil : Car
    {
        public double gasMileage { get; set; }
        public CarWithGasoil(double _gasMileage)
        {
            if (_gasMileage <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(_gasMileage), "Gas mileage must be positive.");
            }
            gasMileage = _gasMileage;
        }

        public virtual double GetGasMileagePrice()
        {
            return gasMileage * 8;

        }
    }
}
