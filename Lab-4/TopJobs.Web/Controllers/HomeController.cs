using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using TopJobs.Web.Models;

namespace TopJobs.Web.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }

    public class ContactController : Controller
    {
        //GET: Home
        public ActionResult Contact()
        {
            return View();
        }
    }

    public class CreateController : Controller
    {
        // GET: Offers
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Offer newOffer)
        {
            OfferEntities1 db = new OfferEntities1();

            if (ModelState.IsValid)
            {
                db.Offers.Add(newOffer);
                db.SaveChanges();

                return RedirectToAction("List", "List");
            }
            else
            {
                return View(newOffer);
            }
        }
    }

    public class ListController : Controller
    {
        // GET: List
        public ViewResult List(string id, string sortOrder, string searchString, string currentFilter, int? page)
        {
            OfferEntities1 db = new OfferEntities1();
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var offers = from o in db.Offers
                         select o;
            if (!String.IsNullOrEmpty(searchString))
            {
                offers = offers.Where(o => o.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    offers = offers.OrderByDescending(o => o.Name);
                    break;
                default:
                    offers = offers.OrderBy(o => o.Name);
                    break;
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(offers.ToPagedList(pageNumber, pageSize));
        }
    }

    public class DetailsController : Controller
    {
        [HttpGet]
        public ActionResult Details(int id)
        {
            var db = new OfferEntities1();
            var model = new Offer();
            model = db.Offers.Find(id);
            return View(model);
        }
    }

    public class DeleteController : Controller
    {
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var db = new OfferEntities1();
            var model = db.Offers.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            db.Offers.Remove(model);
            db.SaveChanges();
            return RedirectToAction("List", "List");
        }
    }

    public class EditController : Controller
    {
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new OfferEntities1();
            var model = new Offer();
            model = db.Offers.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Offer list)
        {
            var db = new OfferEntities1();
      


            if (ModelState.IsValid)
            {
                db.Offers.Add(list);

                db.Entry(list).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List", "List");
            }
            return View(list);
        }
    }

    public class LoginController : Controller
        {
            // GET: List
            public ActionResult Login()
            {
                return View();
            }
        }

        public class RegisterController : Controller
        {
            // GET: List
            public ActionResult Register()
            {
                return View();
            }

    }
}