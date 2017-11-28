using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace pgsqltest.Models
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=db.copts.ru;Port=1111;Database=copts;Username=root;Password=0nA7yW19");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Companys> Companys { get; set; }
        public DbSet<Rules> Rules { get; set; }
    }
}
