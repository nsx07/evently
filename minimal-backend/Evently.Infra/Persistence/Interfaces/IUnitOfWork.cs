using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evently.Infra.Persistence.Interfaces
{
    public interface IUnitOfWork<T>
    {
        T BeginTransaction();
        Task Commit();
    }
}
