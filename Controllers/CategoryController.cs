using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppDemo.Models.Classes;

namespace WebAppDemo.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context context = new Context();
        public ActionResult Index()
        {
            var values =  context.MemberCategories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(MemberCategory Mc) 
        {
            context.MemberCategories.Add(Mc);
            context.SaveChanges();
            return RedirectToAction("Index");
        } 
        public ActionResult DeleteCategory(int id) 
        {
            var Cate = context.MemberCategories.Find(id);
            context.MemberCategories.Remove(Cate);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetCategory(int id)
        {
            var Categ = context.MemberCategories.Find(id);
            return View("GetCategory",Categ);
        }
        public ActionResult UpdateCategory(MemberCategory Mc)
        {
            var ctg = context.MemberCategories.Find(Mc.CategoryId);
            ctg.CategoryName= Mc.CategoryName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}