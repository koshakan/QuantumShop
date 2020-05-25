using QuantumShop.Data.Data;
using QuantumShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumShop.Data.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private ApplicationDbContext _con;

        public DeviceRepository(ApplicationDbContext con)
        {
            _con = con;
        }

        public Device AddDevice(Device dev)
        {
            throw new NotImplementedException();
        }

        public Device DeleteDevice(Device dev)
        {
            throw new NotImplementedException();
        }

        public Device GetDevice(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
