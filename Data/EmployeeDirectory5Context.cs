using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeDirectory5.Models;

namespace EmployeeDirectory5.Data
{
    public class EmployeeDirectory5Context : DbContext
    {
        public EmployeeDirectory5Context (DbContextOptions<EmployeeDirectory5Context> options)
            : base(options)
        {
        }

        public DbSet<EmployeeDirectory5.Models.Employee> Employee { get; set; } = default!;
    }
}
