using PersonalApp.DAL.Repositories.Abstract;
using PersonalApp.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {

        private PersonalDbContext _personalcontext;

        public UnitofWork ( PersonalDbContext context)
        {
            _personalcontext = context;
            DeparmentRepository = new DepartmentRepository (_personalcontext);
            PersonalRepository = new PersonalRepository (_personalcontext);

        }



        public IDeparmentRepository DeparmentRepository { get; private set; }

        public IPersonalRepository PersonalRepository { get; private set; }

        public int Complete()
        {
           return _personalcontext.SaveChanges();
        }

        public void Dispose()
        {
           _personalcontext.Dispose();
        }
    }
}
