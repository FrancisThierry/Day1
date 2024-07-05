using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserManagement.BusinessLogic
{
    public class CsvData : IDataSource
    {
        private readonly string _filePath;

        public CsvData(string filePath)
        {
            _filePath = filePath;
        }

        public List<Dictionary<string, string>> LoadData()
        {
            var result = new List<Dictionary<string, string>>();
            var lines = File.ReadAllLines(_filePath);
            var headers = lines[0].Split(',');

            foreach (var line in lines.Skip(1))
            {
                var values = line.Split(',');
                var data = new Dictionary<string, string>();

                for (int i = 0; i < headers.Length; i++)
                {
                    data[headers[i]] = values[i];
                }
                result.Add(data);
            }
            return result;
        }
    }
}
