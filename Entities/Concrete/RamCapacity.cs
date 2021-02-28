using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RamCapacity : IEntity
    {
        public int RamCapacityId { get; set; }
        public string RamCapacityName { get; set; }
    }
}
