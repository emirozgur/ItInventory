using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ComputerManager : IComputerService
    {
        IComputerDal _computerDal;

        public ComputerManager(IComputerDal computerDal)
        {
            _computerDal = computerDal;
        }

        public IResult Add(Computer computer)
        {
            _computerDal.Add(computer);
            return new SuccessResult(Messages.ComputerAdded);
        }

        public IResult Delete(Computer computer)
        {
            _computerDal.Delete(computer);
            return new SuccessResult(Messages.ComputerDeleted);
        }

        public IDataResult<List<Computer>> GetAll()
        {
            return new SuccessDataResult<List<Computer>>(_computerDal.GetAll());
        }

        public IDataResult<Computer> GetById(int computerId)
        {
            return new SuccessDataResult<Computer>( _computerDal.Get(c => c.ComputerId == computerId));
        }

        public IResult Update(Computer computer)
        {
            _computerDal.Update(computer);
            return new SuccessResult(Messages.ComputerUpdated);
        }
    }
}
