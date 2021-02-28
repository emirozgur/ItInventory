using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IComputerService
    {
        IDataResult<List<Computer>> GetAll();
        //IDataResult<List<Device>> GetAllByEmployeeId(int id);
        //IDataResult<List<DeviceDetailDto>> GetDeviceDetails();
        IDataResult<Computer> GetById(int computerId);
        IResult Add(Computer computer);
        IResult Update(Computer computer);
        IResult Delete(Computer computer);
    }
}
