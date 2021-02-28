﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfComputerKindDal : EfEntityRepositoryBase<ComputerKind, InventoryContext>, IComputerKindDal
    {
    }
}
