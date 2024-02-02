using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Model.Entities.Concretes;
namespace DataAccess.Contexts
{
    internal class LibraryContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var conStr = new ConfigurationManager()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetConnectionString("DefaultConnection");

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(conStr);

            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }



        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<S_Cart> S_Carts { get; set; }
        public virtual DbSet<T_Cart> T_Carts { get; set; }
    }
}
