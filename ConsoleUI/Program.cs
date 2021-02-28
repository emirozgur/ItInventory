using Business;
using Business.Concrete;
using DataAccess;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();
            //EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
            //foreach (var employee in employeeManager.GetAll())
            //{
            //    Console.WriteLine(employee.FirstName);
            //}

        }

        private static void ProductTest()
        {
            DeviceManager deviceManager = new DeviceManager(new EfDeviceDal());

            var result = deviceManager.GetDeviceDetails();
            if (result.Success==true)
            {
                foreach (var device in result.Data)
                {
                    Console.WriteLine(device.DeviceName + "/" + device.FirstName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            Console.ReadLine();
        }
    }
}
