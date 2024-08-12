using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork unitofwork = new UnitOfWork(new PersonalDbContext());
           
            unitofwork.DepartmentRepository.Add(new Department()
            {
                Name = "Engineer",
                isActive = true,
                CreatedDate = DateTime.Now
            });
           
            unitofwork.Department.Repository.Add(new Department() { Name = "Developer", IsActive = true, CreatedDate = DateTime.Now });
           
            unitofwork.Complete();
        }
    }
}

