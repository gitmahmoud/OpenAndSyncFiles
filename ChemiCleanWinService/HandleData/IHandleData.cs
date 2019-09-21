using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ChemiCleanWinService
{
    public interface IHandleData
    {
        UnitOfWork unitOfWork { set; }

        void UpdateData(tblProduct product, byte[] onlineFile);
        void Commit();
    }
}
