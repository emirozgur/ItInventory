﻿using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetAll();
        //IDataResult<List<Device>> GetAllByEmployeeId(int id);
        //IDataResult<List<DeviceDetailDto>> GetDeviceDetails();
        IDataResult<Employee> GetById(int employeeId);
        IResult Add(Employee employee);
        IResult Update(Employee employee);
        IResult Delete(Employee employee);
    }
}
