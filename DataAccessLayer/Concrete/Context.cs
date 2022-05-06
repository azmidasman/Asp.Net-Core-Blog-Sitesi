using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext //Public'e çevir.
    {
        /*
        OnConfiguring metodunun içinde bağlantı stringini tanımlayacağız. Parametre olarak tanımladığımız optionsBuilder'a
        DBContext OptionsBuilder yapısına ihtiyaç duyuyorum. Core'da böyle.
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //options builder parametresini kullanarak UseSqlServer metodunu çağırdım. İçine con string tanımladım.
            optionsBuilder.UseSqlServer("server=DESKTOP-DKBCLNM\\SQLEXPRESS;database=CoreBlogDB;integrated security=true;");
        }
        //Context sınıfına ait DBSet'leri yapıyorum.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
