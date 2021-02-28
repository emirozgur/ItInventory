using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class DeviceManager : IDeviceService
    {

        IDeviceDal _deviceDal;

        //CTOR
        public DeviceManager(IDeviceDal deviceDal)
        {
            _deviceDal = deviceDal;
        }

        public IResult Add(Device device)
        {
            if (device.DeviceName.Length < 2)
            {
                return new ErrorResult(Messages.DeviceNameInvalid);
            }
            _deviceDal.Add(device);
            return new SuccessResult(Messages.DeviceAdded);
        }

        public IResult Delete(Device device)
        {
            _deviceDal.Delete(device);
            return new SuccessResult( Messages.DeviceDeleted);

        }

        // İş Kodları
        public IDataResult<List<Device>> GetAll()
        {
            if (DateTime.Now.Hour==2)
            {
                return new ErrorDataResult<List<Device>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Device>>(_deviceDal.GetAll(),Messages.DevicesListed);
        }

        public IDataResult<List<Device>> GetAllByEmployeeId(int id)
        {
            return new SuccessDataResult<List<Device>>( _deviceDal.GetAll(e => e.EmployeeId == id));
        }

        public IDataResult<Device> GetById(int deviceId)
        {
            return new SuccessDataResult<Device>( _deviceDal.Get(d => d.DeviceId == deviceId));
        }

        public IDataResult<List<DeviceDetailDto>> GetDeviceDetails()
        {
             return new SuccessDataResult<List<DeviceDetailDto>>(_deviceDal.GetDeviceDetails());
        }

        public IResult Update(Device device) // IDevice Service içindeki CRUD operasyonlarında void yerine IResult nesnesi kullanınca, buradak implementasyonunda return kullanıldı
        {
            _deviceDal.Update(device);
            return new SuccessResult(Messages.DeviceUpdated);
        }

        
    }
}
