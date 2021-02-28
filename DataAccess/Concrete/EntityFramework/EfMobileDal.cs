using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMobileDal : EfEntityRepositoryBase<Mobile, InventoryContext>, IMobileDal
    {
        //Buraya joinler yazılacak
    }
}
