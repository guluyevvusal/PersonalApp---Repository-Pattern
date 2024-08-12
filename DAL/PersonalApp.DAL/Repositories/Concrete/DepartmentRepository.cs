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
    public class DepartmentRepository : Repository<Department>, IDeparmentRepository
    {
        public DepartmentRepository(PersonalDbContext context) : base(context)
        {

        }

        public IEnumerable<Department> GetDepartmentsWithPersonals()
        {
            return PersonalDbContext.Departments.Include("Personals").ToList();
        }

        public IEnumerable<Department> GetTopDepartmnets(int count)
        {
            return PersonalDbContext.Departments.Take(count);
        }


        public PersonalDbContext PersonalDbContext { get { return _dbcontext as PersonalDbContext; } }
    }
}
