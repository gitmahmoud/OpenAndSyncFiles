using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ChemiCleanWinService
{
    public class HandleData : IHandleData
    {
        private UnitOfWork _unitOfWork;
        public UnitOfWork unitOfWork {
            set
            {
                _unitOfWork = value;
            }
        }

        public void UpdateData(tblProduct product, byte[] onlineFile)
        {
            if (product.tblFile == null)
                InsertFile(product.Id, onlineFile);
            else if (product.tblFile.File == onlineFile)
                return;
            else if (product.tblFile.File != onlineFile)
            {
                product.tblFile.File = onlineFile;
                UpdateFile(product.tblFile);
            }

            UpdateProduct(product);
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }

        private void UpdateProduct(tblProduct product)
        {
            product.LastSyncDate = DateTime.Now;
            _unitOfWork.Products.Update(product);
        }

        private void UpdateFile(tblFile file)
        {
            _unitOfWork.Files.Update(file);
        }

        private void InsertFile(int productId, byte[] onlineFile)
        {
            tblFile file = new tblFile();
            file.Id = productId;
            file.File = onlineFile;

            _unitOfWork.Files.Insert(file);
        }
    }
}
