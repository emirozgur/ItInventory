using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Device : IEntity
    {
        public int DeviceId { get; set; }
        public int StatusId  { get; set; }
        public int WorkPlaceId { get; set; }
        public int ModelId { get; set; }
        public int EmployeeId { get; set; }
        public string DeviceName { get; set; }
        public string InventoryId { get; set; }
        public string SerialId { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime DropDate { get; set; }
        public string DeviceDescription { get; set; }
    }
}
