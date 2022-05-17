using Microsoft.EntityFrameworkCore;
using Payment_Sytem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_Sytem.DataAcess
{
    public class DataContext : DbContext
    {
        
            public DataContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<Payments> Payments { get; set; }
        public DbSet<CompanyManagers> Managers { get; set; }



    }
}
