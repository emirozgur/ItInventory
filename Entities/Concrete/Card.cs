using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Card:IEntity

    {
        public int CardId { get; set; }
        public int LineId { get; set; }
        public string IccId { get; set; }
    }
}
