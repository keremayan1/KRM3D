
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Contexts
{
    public class SQLContext:DbContext
    {
        public IConfiguration Configuration { get; set; }
        public DbSet<GenderReadModel> Genders { get; set; }
        public DbSet<EducationStatusReadModel> EducationStatuses { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<ChildFather> ChildFathers { get; set; }
        public DbSet<ChildMother> ChildMothers { get; set; }
        public DbSet<ChildSiblings> ChildSiblings { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet<QuestionTitle> QuestionTitles { get; set; }

        public SQLContext(DbContextOptions dbContextOptions,IConfiguration configuration):base(dbContextOptions)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SQLConnectionString"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }
    }
}
