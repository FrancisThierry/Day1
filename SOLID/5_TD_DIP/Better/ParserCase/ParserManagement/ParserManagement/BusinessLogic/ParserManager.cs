using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserManagement.BusinessLogic
{
    public  class ParserManager
    {
        private readonly IDataSource _dataSource;

        public ParserManager(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void ParserReport()
        {
            var data = _dataSource.LoadData();
            foreach (var row in data)
            {
                foreach (var kvp in row)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }



    }
}
