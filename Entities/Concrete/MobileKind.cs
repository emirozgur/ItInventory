﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class MobileKind : IEntity
    {
        public int MobileKindId { get; set; }
        public string MobileKindName { get; set; }
    }
}
