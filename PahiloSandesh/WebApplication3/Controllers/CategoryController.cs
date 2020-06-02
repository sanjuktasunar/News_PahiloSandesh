using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _category = new CategoryRepository();
        private readonly ParentCategoryRepository _parent = new ParentCategoryRepository();

        public CategoryController()
        {
            ViewBag.ParentCategory = _parent.GetAllActiveParentCategory();
        }

        public ActionResult Category()
        {
            var obj = _category.GetAllCategory();
            return View(obj);
        }
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Category obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            obj.CreatedOn = DateTime.Now;
            obj.CreatedByUserId = Convert.ToInt32(Session["Id"]);
            _category.Insert(obj);
            Session["Message"] = "Data Added Successfully..................!!!!!!!";
            return RedirectToAction("Category", "Category");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var obj = _category.Get(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category obj)
        {
            if(!ModelState.IsValid)
            {
                return View(obj);
            }
            obj.ModifiedOn = DateTime.Now;
            obj.ModifiedByUserId = Convert.ToInt32(Session["Id"]);
            _category.Update(obj);

            Session["Message"] = "Data Updated Successfully..................!!!!!!!";
            return RedirectToAction("Category", "Category");
        }

        public ActionResult DeleteCategory(int id)
        {          
            _category.Delete(id);
            Session["Message"] = "Data Deleted Successfully..................!!!!!!!";
            return RedirectToAction("Category", "Category");
        }
    }
}