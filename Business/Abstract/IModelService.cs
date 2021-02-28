using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IModelService
    {
        IDataResult<List<Model>> GetAll();
        //IDataResult<List<Device>> GetAllByEmployeeId(int id);
        //IDataResult<List<DeviceDetailDto>> GetDeviceDetails();
        IDataResult<Model> GetById(int modelId);
        IResult Add(Model model);
        IResult Update(Model model);
        IResult Delete(Model model);
    }
}
