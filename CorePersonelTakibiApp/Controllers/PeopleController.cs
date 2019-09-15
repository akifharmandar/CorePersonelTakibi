using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CorePersonelTakibiApp.Models;
using Microsoft.AspNetCore.Http;

namespace CorePersonelTakibiApp.Controllers
{
    public class PeopleController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var person = PersonRepository.People;
            return View(person);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            PersonRepository.Create(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return View("Error");
            }
            var person = PersonRepository.GetById(id.Value);
            PersonRepository.Delete(person);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return View("Error");
            }
            var person = PersonRepository.GetById(id.Value);
            if (person==null)
            {
                return NotFound();
            }
            return View(person);

        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            if (person.PersonID==0)
            {
                return View("Error");
            }
            var updated = PersonRepository.GetById(person.PersonID);
            
            updated.Name = person.Name;
            updated.LastName = person.LastName;
            updated.Phone = person.Phone;
            updated.Mail = person.Mail;
            updated.Gender = person.Gender;
            updated.Address = person.Address;
            updated.Departman = person.Departman;

            //return View(person);
            return RedirectToAction("Index");
        }
    }
}