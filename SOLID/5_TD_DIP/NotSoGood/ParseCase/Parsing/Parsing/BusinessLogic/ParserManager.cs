using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Parsing.BusinessLogic
{
    public  class ParserManager
    {

        public XmlDocument DataSource { get; set; }

        public ParserManager(XmlDocument document)
        {
            DataSource = document;
                
        }
        public void  ParserReport(string filepath)
        {
            XmlDocument document = DataSource;
            document.Load(filepath);
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
            Console.WriteLine(result[0]);
        }




    }
}
