using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class StorageCapacity : IEntity
    {
        public int StorageCapacityId { get; set; }
        public string StorageCapacityName { get; set; }
    }
}
