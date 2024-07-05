using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
namespace ConsoleBenchMarkFirstMethod
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class PrintCounter
    {
        [Params(5, 10)]
        public int CounterSize { get; set; }

        //[GlobalSetup]
        //public void Setup()
        //{
        //    CounterSize = 10; // Assigner une valeur par défaut
        //}

        //[Params]

      


        [Benchmark]
        public string showCounterWithInterpolation()
        {

            string result = string.Empty;

            for (int i = 0; i < CounterSize; i++)
            {
                result = $" Counter : {result}";
            }
            return result;

        }
        [Benchmark]
        public string showCounterWithConcat()
        {

            string result = string.Empty;

            for (int i = 0; i < CounterSize; i++)
            {
                result = " Counter : "+result+"";
            }
            return result;

        }

        [Benchmark]
        public string showCounterWithStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < CounterSize; i++)
            {
                stringBuilder.Append("Counter : ");
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();

        }
    }
}
