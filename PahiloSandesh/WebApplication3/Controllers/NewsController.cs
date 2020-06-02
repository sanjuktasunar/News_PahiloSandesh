using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Repositories;

namespace WebApplication3.Controllers
{
    public class NewsController : Controller
    {
        private readonly CategoryRepository _category = new CategoryRepository();
        private readonly ParentCategoryRepository _parent = new ParentCategoryRepository();
        private readonly NewsRepository _news = new NewsRepository();
        // GET: News

        public NewsController()
        {
            ViewBag.ParentCategory = _parent.GetAllActiveParentCategory();
            ViewBag.Category = _category.GetAllActiveCategory();
        }
        public ActionResult News()
        {
            var obj = _news.GetAllNews();
            return View(obj);
        }
        public ActionResult CreateNews()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNews(News obj)
        {
            obj.EntryByUserId = Convert.ToInt32(Session["Id"]);
            obj.EntryDate = DateTime.Now;

            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            _news.Insert(obj);
            return RedirectToAction("News", "News");
        }
        public ActionResult UpdateNews(int id)
        {
            var obj = _news.Get(id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult UpdateNews(News obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            obj.ModifyByUserId = Convert.ToInt32(Session["Id"]);
            obj.ModifyDate = DateTime.Now;
            _news.Update(obj);
            return RedirectToAction("News", "News");
        }
        public ActionResult DeleteNews(int id)
        {
            _news.Delete(id);
            return RedirectToAction("News", "News");
        }
    }
}