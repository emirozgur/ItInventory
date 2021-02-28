using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class WorkPlace : IEntity

    {
        public int WorkPlaceId { get; set; }
        public int DepartmentId { get; set; }
        public string WorkPlaceName { get; set; }
    }
}
