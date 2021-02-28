using Core.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IDeviceService
    {
        //Burada metodlar servis edilir.
        IDataResult<List<Device>> GetAll();
        IDataResult<List<Device>> GetAllByEmployeeId(int id);
        IDataResult<List<DeviceDetailDto>> GetDeviceDetails();
        IDataResult<Device> GetById(int deviceId);
        IResult Add(Device device);
        IResult Update(Device device);
        IResult Delete(Device device);
    }
}
