using PersonalApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.DAL.UnitofWork
{
    public interface IUnitofWork:IDisposable
    {
        IDeparmentRepository DeparmentRepository { get; }
        IPersonalRepository PersonalRepository { get; }

        int Complete();
    }
}
