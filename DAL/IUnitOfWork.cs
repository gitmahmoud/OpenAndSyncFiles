using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork
    {
        IRepository<tblProduct> Products { get; }
        IRepository<tblFile> Files { get; }
        void Commit();
    }
}
