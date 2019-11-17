using DataLibrary.DAO;
using DataLibrary.Models;
using DataLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        RepositoryPerson repository = new RepositoryPerson();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
       
        public ActionResult Create(Person model)
        {
            repository.ToSave(model);
            ViewBag.Message = $"'{model.Name}' Was Successfully Saved";
            ModelState.Clear();
            return View();
        }
        public ActionResult List()
        {
            
            List<Person> peopleList = repository.ListAll();

            return View(peopleList);
        }
    }
}