using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ComputerKind : IEntity
    {
        public int ComputerKindId { get; set; }
        public string ComputerKinName { get; set; }
    }
}
