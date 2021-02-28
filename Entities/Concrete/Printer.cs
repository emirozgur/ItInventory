using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Printer : IEntity
    {
        public int PrinterId { get; set; }
        public string PrinterType { get; set; }
        public string IpAddress { get; set; }
    }
}
