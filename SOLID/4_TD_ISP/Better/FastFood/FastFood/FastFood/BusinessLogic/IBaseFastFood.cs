using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.BusinessLogic
{
    public  interface IBaseFastFood
    {
        public string? Company { get; set; }
        public string? City { get; set; }
    }
}
