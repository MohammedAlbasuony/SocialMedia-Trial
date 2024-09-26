using Microsoft.EntityFrameworkCore;
using SocialMedia.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.DAL.DB
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MOHAMMEDALBASUO;Database=SocialMediaITC;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
