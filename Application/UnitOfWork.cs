using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private ChemiCleanContext _dbContext;
        private BaseRepository<tblProduct> _products;
        private BaseRepository<tblFile> _files;

        public UnitOfWork()
        {
            _dbContext = new ChemiCleanContext();
        }

        public IRepository<tblProduct> Products
        {
            get
            {
                return _products ??
                    (_products = new BaseRepository<tblProduct>(_dbContext));
            }
        }

        public IRepository<tblFile> Files
        {
            get
            {
                return _files ??
                    (_files = new BaseRepository<tblFile>(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
