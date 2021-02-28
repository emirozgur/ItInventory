using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPrinterDal : EfEntityRepositoryBase<Printer, InventoryContext>, IPrinterDal
    {
        //Buraya joinler yazılacak
    }
}
