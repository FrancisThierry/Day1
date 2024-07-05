using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParserManagement.BusinessLogic
{
    public class XmlData : IDataSource
    {
        private readonly string _filepath;

        public XmlData(string url)
        {
            _filepath = url;
        }

        public List<Dictionary<string, string>> LoadData()
        {
            XmlDocument document = new XmlDocument();
            document.Load(_filepath);
            var result = new List<Dictionary<string, string>>();

            XmlNode root = document.DocumentElement;
            foreach (XmlNode company in root.SelectNodes("Company"))
            {
                var data = new Dictionary<string, string>
                {
                    { "id", company.SelectSingleNode("ID").InnerText },
                    { "company",company.SelectSingleNode("Name").InnerText },
                    { "temperature", company.SelectSingleNode("Temperature").InnerText }
                };
                result.Add(data);
            }
            return result;
        }
    }
}






