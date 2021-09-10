using Model.Entity;
using Model.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=ECommerceDB;pwd=123;uid=sa;";
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserRole> Roles { get; set; }
        public DbSet<AppUserAndRole> AppUserAndRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        //çoka çok tablo için onModelCreating metodu ezilecek.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserRoleMap());
            modelBuilder.Configurations.Add(new AppUserAndRoleMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new SubCategoryMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
