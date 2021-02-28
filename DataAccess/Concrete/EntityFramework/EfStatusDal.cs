using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStatusDal : EfEntityRepositoryBase<Status, InventoryContext>, IStatusDal
    {
        //Buraya joinler yazılacak
    }
}
