using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Net;
using System.IO;
using System.Text;

namespace ChemiClean.Controllers
{
    public class ProductController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        
        // GET: Product
        public ActionResult Index(string currentFilter, string searchString, int? page)
        {
            if (searchString != null)            
                page = 1;            
            else            
                searchString = currentFilter ?? "";
            

            ViewBag.CurrentFilter = searchString;

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var products = unitOfWork.Products.Get(x=> x.ProductName.Contains(searchString), null, "tblFile");
            
            return View(products.ToPagedList(pageNumber, pageSize));
        }

        public FileContentResult OpenFile(int id)
        {
            tblFile file = unitOfWork.Files.GetByID(id);
            if (file == null)
                return null;
            
            try
            {
                return File(file.File, "application/pdf");   
            }
            catch
            {
                return null;
            }            
        }
    }
}