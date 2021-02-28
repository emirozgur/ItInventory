using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess
{
    public class DeviceDal : IDeviceDal
    {
        public void Add(Device entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Device entity)
        {
            throw new NotImplementedException();
        }

        public Device Get(Expression<Func<Device, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetAll(Expression<Func<Device, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<DeviceDetailDto> GetDeviceDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Device entity)
        {
            throw new NotImplementedException();
        }
    }
}
