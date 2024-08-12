using PersonalApp.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.Repositories.Abstract
{
    public interface IDeparmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartmnets(int count);
        IEnumerable<Department> GetDepartmentsWithPersonals();
    }
}
