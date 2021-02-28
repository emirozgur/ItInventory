using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfScreenDal : EfEntityRepositoryBase<Screen, InventoryContext>, IScreenDal
    {
        //Buraya joinler yazılacak
    }
}
