using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Screen : IEntity
    {
        public int ScreenId { get; set; }
        public int ScreenSize { get; set; }
    }
}
