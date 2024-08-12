using Microsoft.EntityFrameworkCore;
using PersonalApp.Domains.Entities;

namespace PersonalApp.DAL
{
    public class PersonalDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personal> Personals { get; set; }

    }
}
