using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class DeviceDetailDto : IDto
    {
        //Buraya joinler için propertyler yazılır Propertyler entities concrete içindeki ürün sınıflarından alınır. tablolar burada birleştirilir.
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CpuId { get; set; }
        public string CpuName { get; set; }
        public string ModelName { get; set; }



        //Bu propertyler EfDeviceDal Tarafından kullanılacak
    }
}
