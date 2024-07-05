using ConsoleTempWorkBench.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTempWorkBench.Services
{
    public class DeviceDataManager :  IDataService
    {
        private readonly DatabaseMyTempContext context;

        public DeviceDataManager(DatabaseMyTempContext ctx)
        {
            this.context = ctx;
                
        }
        public void Save()
        {
            this.context.SaveChanges();
        }

        public void AddDevice(Device devise)
        {
            context.Add(devise);
        }

        public void AddNonPresentDevices(string deviceName)
        {
            var device = GetDeviceByName(deviceName);
            if (device == null)
            {
                context.Devices.Add( new Device { DeviceName = deviceName});
            }
        }

        private bool IsDevicePresentByName(string deviseName)
        {
            return this.context.Devices.Where(d => d.DeviceName == deviseName).FirstOrDefault() != null;
        }

        public Device? GetDeviceByName(string deviseName)
        {
            return this.context.Devices.Where(d=>d.DeviceName == deviseName).FirstOrDefault();
        }
    }
}
