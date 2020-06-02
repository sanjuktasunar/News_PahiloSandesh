using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    public class ParentCategoryController : Controller
    {
        private readonly ParentCategoryRepository _parent = new ParentCategoryRepository();
        public ActionResult ParentCategory()
        {
            
            var obj = _parent.GetAllParentCategory();
            return View(obj);
        }
        [HttpGet]
        public ActionResult CreateParentCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateParentCategory(ParentCategory obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
           _parent.Insert(obj);
          
            Session["Message"] = "Data Added Successfully..................!!!!!!!";
            //Response.Write("<script> alert('') </script>");
            return RedirectToAction("ParentCategory","ParentCategory");
        }
        public ActionResult UpdateParentCategory(int id)
        {
            var obj = _parent.Get(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult UpdateParentCategory(ParentCategory obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            _parent.Update(obj);
           
            Session["Message"] = "Data Updated Successfully..................!!!!!!!";
            return RedirectToAction("ParentCategory","ParentCategory");
        }
        public ActionResult DeleteParentCategory(int id)
        {
            _parent.Delete(id);
            //Response.Write("<script> alert('Data Deleted Successfully') </script>");
            Session["Message"] = "Data Deleted Successfully..................!!!!!!!";
            return RedirectToAction("ParentCategory", "ParentCategory");
        }
    }
}