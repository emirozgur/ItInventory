using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class OperationPlace : IEntity
    {
        public int OperationPlaceId { get; set; }
        public string OperationPlaceName { get; set; }
        public string PlaceDescription { get; set; }
    }
}
