using FirstData.Models;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstData.DAL
{
    internal class AppDbContex:DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=7W\\SQLEXPRESS;Database=firstdemo;Encrypt=False;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
