using ConsoleTempWorkBench.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTempWorkBench.Services
{
    public class MeasureDataManagement : DbContext, IDataService
    {
        private readonly DatabaseMyTempContext context;
        private readonly DeviceDataManager deviceDataManager;

        public MeasureDataManagement(DatabaseMyTempContext ctx, DeviceDataManager _deviceDataManager )
        {
            context = ctx;
            deviceDataManager = _deviceDataManager;
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public void AddNonExistingMeasure(string deviceName, string s_measureDateTime, string s_temperature)
        {
            Double temperature = -1;

            try
            {
                temperature = double.Parse(s_temperature, CultureInfo.InvariantCulture);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error during parsing: " + ex.Message);
            }


            DateTime measureDateTime = Convert.ToDateTime(s_measureDateTime);


            var device = deviceDataManager.GetDeviceByName(deviceName);
            if (device != null)
            {
                var measure = context.Measures.Where(m => m.DeviceId == device.Id && m.Temperature == temperature && m.MeasurementDate == measureDateTime).FirstOrDefault();
                if (measure == null)
                {
                    context.Measures.Add(new Measure { DeviceId = device.Id, Temperature = temperature, MeasurementDate = measureDateTime });

                }

            }

        }
    }
}
