using Core.DataAccess.EntityFramework;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDeviceDal : EfEntityRepositoryBase<Device, InventoryContext>, IDeviceDal
    {
        public List<DeviceDetailDto> GetDeviceDetails()
        {
            using (InventoryContext context = new InventoryContext())
            {
                var result = from d in context.Devices
                             join e in context.Employees on d.EmployeeId equals e.EmployeeId
                             join m in context.Models on d.ModelId equals m.ModelId
                             join c in context.Computers on d.DeviceId equals c.ComputerId
                             join cp in context.Cpus on c.CpuId equals cp.CpuId
                             
                             select new DeviceDetailDto 
                             {
                                 ModelName=m.ModelName, CpuName=cp.CpuName, DeviceName=d.DeviceName, FirstName=e.FirstName, LastName=e.LastName
                             };
                return result.ToList();
            }
        }
    }
}
