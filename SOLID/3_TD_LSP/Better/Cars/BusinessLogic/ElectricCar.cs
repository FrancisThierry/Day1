using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.BusinessLogic
{
    public class ElectricCar : Car
    {
        public double TimeCharging { get; set; }

        public double getConsumtionPrice()
        {
            return TimeCharging * 12;
        }
    }
}
