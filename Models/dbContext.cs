using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TradeApplication.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
           : base(options)
        {
        }

        public DbSet<User> UserList { get; set; }
    }
}
