using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleTempWorkBench.Business
{
    internal class CsvReader
    {
        public List<string[]> ReadCsvData(string filePath)
        {
            var data = new List<string[]>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8)) // Specify UTF-8 encoding
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        data.Add(line.Split(';')); // Split data using semicolon separator
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading CSV file: {filePath}", ex); // Re-throw with additional context
            }

            return data;
        }
    }
}
