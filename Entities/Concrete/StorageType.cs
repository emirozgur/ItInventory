using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class StorageType : IEntity
    {
        public int StorageTypeId { get; set; }
        public string StorageTypeName { get; set; }
    }
}
