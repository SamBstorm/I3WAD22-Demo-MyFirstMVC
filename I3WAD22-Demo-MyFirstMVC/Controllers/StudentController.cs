using I3WAD22_Demo_MyFirstMVC.Models;
using I3WAD22_Demo_MyFirstMVC.Models.StudentViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace I3WAD22_Demo_MyFirstMVC.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _students = new List<Student>
                {
                    new Student {Prenom = "Sara", Nom = "Pehlivan", DateNaissance = new DateTime(1987,9,27), Email="sara.pehlivan@interface3.be"},
                    new Student {Prenom = "Allessandra", Nom = "Rafaele", DateNaissance = new DateTime(1987,9,27), Email="alessandra.rafaele@interface3.be"},
                    new Student {Prenom = "Eleonore", Nom = "Stultjens", DateNaissance = new DateTime(1987,9,27), Email="eleonore.stultjens@interface3.be"},
                    new Student {Prenom = "Coline", Nom = "Ducourtieux", DateNaissance = new DateTime(1987,9,27), Email="coline.ducourtieux@interface3.be"},
                    new Student {Prenom = "Bao", Nom = "Hoang", DateNaissance = new DateTime(1987,9,27), Email="bao.hoang@interface3.be"},
                    new Student {Prenom = "Mariam", Nom = "Boudrah", DateNaissance = new DateTime(1987,9,27), Email="mariam.boudrah@interface3.be"},
                    new Student {Prenom = "Kasia", Nom = "Drzazgowska", DateNaissance = new DateTime(1987,9,27), Email="kasia.drzazgowska@interface3.be"},
                    new Student {Prenom = "Anissa", Nom = "Bojabah", DateNaissance = new DateTime(1987,9,27), Email="anissa.bojabah@interface3.be"}
                };

        // GET: StudentController
        public ActionResult Index()
        {
            IEnumerable<StudentListItem> model = _students.Select(s => new StudentListItem() { Nom = s.Nom, Prenom = s.Prenom, Email = s.Email });
            return View(model);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(string id)
        {
            Student stu = _students.SingleOrDefault(s => s.Email == id);
            StudentDetails model = new StudentDetails() { Nom = stu.Nom, Prenom = stu.Prenom, DateNaissance = stu.DateNaissance, Email = stu.Email};
            return View(model);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentCreateForm collection)
        {
            if (!ModelState.IsValid) return View();
            else
            {
                collection.Email = $"{collection.Prenom}.{collection.Nom}@interface3.be";
                _students.Add(new Student()
                {
                    Nom = collection.Nom,
                    Prenom = collection.Prenom,
                    DateNaissance = collection.DateNaissance,
                    Email = collection.Email
                });
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(string id)
        {
            Student stu = _students.SingleOrDefault(s => s.Email == id);
            StudentEditForm model = new StudentEditForm()
            {
                Nom = stu.Nom,
                Prenom = stu.Prenom,
                DateNaissance = stu.DateNaissance,
                Email = stu.Email
            };
            return View(model);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, StudentEditForm collection)
        {
            if (!ModelState.IsValid) return View();
            else {
                Student stu = _students.SingleOrDefault(s => s.Email == id);
                stu.Nom = collection.Nom;
                stu.Prenom = collection.Prenom;
                stu.DateNaissance = collection.DateNaissance;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(string id)
        {
            Student stu = _students.SingleOrDefault(s => s.Email == id);
            StudentDelete model = new StudentDelete()
            {
                Nom = stu.Nom,
                Prenom = stu.Prenom,
                Email = stu.Email
            };
            return View(model);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, StudentDelete collection)
        {
            _students.Remove(_students.SingleOrDefault(s => s.Email == id));
            return RedirectToAction(nameof(Index));
        }
    }
}
