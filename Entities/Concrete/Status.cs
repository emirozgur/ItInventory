using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Status : IEntity
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
