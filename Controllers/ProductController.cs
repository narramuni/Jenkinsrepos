using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JenkinsDemo.Models;
namespace JenkinsDemo.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductModel model = new ProductModel();    
            model.ProductID = 1;
            model.ProductName = "Shirt";
            return View();
        }
    }
}