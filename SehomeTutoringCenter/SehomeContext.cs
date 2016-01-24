using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SehomeTutoringCenter
{
    class SehomeContext : DbContext
    {
        public SehomeContext()
        {
            // Turn off the Migrations, (NOT a code first DB)
            Database.SetInitializer<SehomeContext>(null);
        }

        public DbSet<Visit> Visits { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
