using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleTempWorkBench.Business
{
    public class JsonWriter
    {
        List<string[]> inputs;
        public JsonWriter(List<string[]> listData)
        {
            inputs = listData;
        }
        private List<InputData>  getListData()
        {
            List <InputData> listData = new List <InputData>();

            for (int i = 0; i < inputs.Count; i++)
            {
                Double temperature = -1;

                try
                {
                    temperature = double.Parse(inputs[i][2], CultureInfo.InvariantCulture);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error during parsing: " + ex.Message);
                }
                var dataObject = new InputData
                {
                    DeviceName = inputs[i][0],
                    DateMeasure = Convert.ToDateTime(inputs[i][1]),
                    Temperature = temperature
                };
                listData.Add(dataObject);
            }
            return  listData;
        }

        private string GetSerializeInputData()
        {
            var listData = getListData();
            // Serialize the list of InputData objects to JSON
            string jsonString = JsonSerializer.Serialize(listData);
            return jsonString;

        }

        public void Write(string path)
        {
            // Write the JSON string to the specified file
            File.WriteAllText(path, GetSerializeInputData());
        }
    }
}
