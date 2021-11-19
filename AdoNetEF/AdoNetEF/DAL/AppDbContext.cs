using AdoNetEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetEF.DAL
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3347ULG\SQLEXPRESS;" +
                "Initial Catalog=P202CodeFirst;Integrated Security=true;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
