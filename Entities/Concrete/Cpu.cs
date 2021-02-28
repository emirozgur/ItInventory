using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cpu : IEntity
    {
        public int CpuId { get; set; }
        public string CpuName { get; set; }
    }
}
