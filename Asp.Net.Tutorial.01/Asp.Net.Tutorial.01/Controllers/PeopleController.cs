namespace Asp.Net.Tutorial._01.Controllers
{
    using Asp.Net.Tutorial._01.Data;
    using Asp.Net.Tutorial._01.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class PeopleController : Controller
    {

        private ApplicationDbContext dbContext;

        public PeopleController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {

            return View("ListPeople", dbContext.People);
        }


        public IActionResult CreatePerson( PersonModel model)
        {
            if(ModelState.IsValid == false)
            {
                return View("CreatePerson", model);
            }

            PersonModel newPerson = new PersonModel();
            newPerson.FirstName = model.FirstName;
            newPerson.LastName = model.LastName;
            newPerson.Age = model.Age;

            dbContext.People.Add(newPerson);

            return RedirectToAction("Index");
        }
    }
}
