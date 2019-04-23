using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Librery_Str.Models;

namespace Librery_Str.Models
{
    public class LibreryStrContext : DbContext
    {
        public LibreryStrContext(DbContextOptions<LibreryStrContext> options)
            : base(options)
        {
        }

        public DbSet<Librery_Str.Models.Product> Product { get; set; }

        public DbSet<Librery_Str.Models.Users> Users { get; set; }
    }
}