using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class ComputerDal : IComputerDal
    {
        public void Add(Computer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Computer entity)
        {
            throw new NotImplementedException();
        }

        public Computer Get(Expression<Func<Computer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Computer> GetAll(Expression<Func<Computer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Computer entity)
        {
            throw new NotImplementedException();
        }
    }
}
