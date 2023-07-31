using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class EFContext : DbContext
    {
        // DbSet for the Author table.
        public DbSet<Author> Authors { get; set; }

        // DbSet for the Post table.
        public DbSet<Post> Posts { get; set; }

        // DbSet for the Category table.
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= SHALABY\\SQL2019 ;Database=EFDay;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}
