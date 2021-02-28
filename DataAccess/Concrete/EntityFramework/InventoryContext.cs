using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class InventoryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Inventory;Trusted_Connection=True");
        }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<ComputerKind> ComputerKinds { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<MobileKind> MobileKinds { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationPlace> OperationPlaces { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<RamCapacity> RamCapacities { get; set; }
        public DbSet<RamTech> RamTechs { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<StorageCapacity> StorageCapacities { get; set; }
        public DbSet<StorageType> StorageTypes { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
        
        //Burada tüm tabloları ilişkilendirmeliyiz

    }
}
