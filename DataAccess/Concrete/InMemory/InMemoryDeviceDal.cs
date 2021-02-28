using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDevicetDal : IDeviceDal
    {
        List<Device> _devices;
        public InMemoryDevicetDal()
        {
            _devices = new List<Device>
            {
                new Device{DeviceId=1,DeviceName="DB3ARCBKM013", DeviceDescription="Laptop"},
                new Device{DeviceId=2,DeviceName="BL3TEKMUD001",DeviceDescription="Masaüstü"}
            };
        }
        public void Add(Device device)
        {
            _devices.Add(device);
        }

        public void Delete(Device device)
        {
            Device deviceToDelete =  _devices.SingleOrDefault(p=>p.DeviceId==device.DeviceId);

            _devices.Remove(deviceToDelete);
        }

        public Device Get(Expression<Func<Device, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Device> GetAll(Expression<Func<Device, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Device> GetAllByComputer(int computerId)
        {
            throw new NotImplementedException();
        }

        public List<DeviceDetailDto> GetDeviceDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Device device)
        {
            Device deviceToUpdate = _devices.SingleOrDefault(d => d.DeviceId == device.DeviceId);
            deviceToUpdate.DeviceName = device.DeviceName;
            deviceToUpdate.DeviceDescription = device.DeviceDescription;
        }
    }
}
