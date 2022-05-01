using Microsoft.EntityFrameworkCore;
using Payment.Test.Tuya.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Test.Tuya.DAL.Context
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Products> Products { get; set; }
    }
}
