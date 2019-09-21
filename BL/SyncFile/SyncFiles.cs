using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class SyncFiles : ISyncFiles
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        IReadFile readFile;
        IHandleData handleData;

        public SyncFiles(IReadFile readFile, IHandleData handleData)
        {
            this.readFile = readFile;
            this.handleData = handleData;
            this.handleData.unitOfWork = unitOfWork;
        }

        public void SyncTheFiles()
        {
            IEnumerable<tblProduct> products = unitOfWork.Products.Get(null, null, "tblFile");
            foreach (var product in products)
            {
                //download file
                byte[] onlineFile = readFile.DownloadFile(product.Url);
                if (onlineFile == null)
                    continue;
                
                //update datasource
                handleData.UpdateData(product, onlineFile);
            }

            //save data
            handleData.Commit();
        }
    }
}