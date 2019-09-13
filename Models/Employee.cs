using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace AzureProject.Models
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
    }
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> employee { get; set; }
    }
}