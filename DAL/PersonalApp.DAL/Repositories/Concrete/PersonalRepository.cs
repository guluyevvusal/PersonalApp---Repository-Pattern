using Microsoft.EntityFrameworkCore;
using PersonalApp.DAL.Repositories.Abstract;
using PersonalApp.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.Repositories.Concrete
{
    public class PersonalRepository : Repository<Personal>, IPersonalRepository
    {
        public PersonalRepository(PersonalDbContext context) : base(context)
        {
        }

        public IEnumerable<Personal> GetDepartmentsWithDepartments()
        {
          return PersonalDbContext.Personals.Include("Department").ToList();
        }


        public PersonalDbContext PersonalDbContext { get { return _dbcontext as PersonalDbContext; } }
    }
}
