using Core.DataAccess;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IDeviceDal : IEntityRepository<Device>
    {
        List<DeviceDetailDto> GetDeviceDetails(); 
    }
}
