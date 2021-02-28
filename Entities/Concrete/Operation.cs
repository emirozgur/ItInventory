using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Operation : IEntity
    {
        public int OperationId { get; set; }
        public int DeviceId { get; set; }
        public int OperationPlaceId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BringName { get; set; }
        public string CarryName { get; set; }
        public string OperationDescription { get; set; }
    }
}
