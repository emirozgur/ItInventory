using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RamTech : IEntity
    {
        public int RamTechId { get; set; }
        public string RamTechName { get; set; }
    }
}
