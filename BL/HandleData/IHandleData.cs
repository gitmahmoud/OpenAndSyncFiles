using DAL;

namespace BL
{
    public interface IHandleData
    {
        UnitOfWork unitOfWork { set; }

        void UpdateData(tblProduct product, byte[] onlineFile);
        void Commit();
    }
}
