using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserManagement.BusinessLogic
{
    public  interface IDataSource
    {
        List<Dictionary<string, string>> LoadData();
    }

    
}
