using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Mobile : IEntity
    {
        public int MobileId { get; set; }
        public int CardId { get; set; }
        public int MobileKindId { get; set; }
        public int ImeiId { get; set; }
    }
}
