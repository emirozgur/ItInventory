using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Computer : IEntity
    {
        public int ComputerId { get; set; }
        public int CpuId { get; set; }
        public int RamCapacityId { get; set; }
        public int StorageCapacityId { get; set; }
        public int ComputerKindId { get; set; }
        public int RamTechId { get; set; }
        public int StorageTypeId { get; set; }
    }
}
