using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Contexts
{
    public class MySQLContext : DbContext
    {
        public IConfiguration Configuration { get; set; }
        public DbSet<AdultModelView> Adults { get; set; }
        public DbSet<AdultEducationStatusModelView> AdultEducationStatuses { get; set; }
        public DbSet<AdultGenderModelView> AdultGenders { get; set; }

        public MySQLContext(DbContextOptions dbContextOptions,IConfiguration configuration):base(dbContextOptions)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Configuration.GetConnectionString("MySQLConnectionString");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
