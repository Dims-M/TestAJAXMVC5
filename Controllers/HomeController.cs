
using RegistrationApplication.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAJAXMVC5.Models;

namespace TestAJAXMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Контроллер для поиска по имени. Возращает паршел вьюху.
        /// </summary>
        /// <param name="name">Имя автора</param>
        /// <returns></returns>
        public ActionResult BookSearch(string name)
        {
            List<Book> allbooks = new List<Book>();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
            using (DBCont db = new DBCont() )
            {
                //ищем в выборке по названию
                // allbooks = db.Books.Where(a => a.Author.Contains(name)).ToList();
                allbooks = db.Books.Where(a => a.Name == name).ToList();
                // allbooks = db.Books.ToArray().OrderBy(x => x.Author).Select(x => new List<Book>()).ToList();
                //allbooks = db.Books.FirstOrDefault(a => a.Author = name);
                //allbooks = db.Books.ToArray().OrderBy(x => x.Author).Select(x => new List<Book>()).ToList();


                if (allbooks.Count == 0)
                {
                    //return HttpNotFound();
                    //return PartialView();
                  return  Content("Поиск не нашел совпадений.");
                   // return RedirectToRoute("Error");
                }
                if (allbooks == null)
                {
                    // return RedirectToRoute("Error");
                    Redirect("/Shared/Error");
                }
            }

           return PartialView(allbooks);
            //return View(allbooks); 
        }

        //Получаем первую строку
        [HttpGet]
        public ActionResult BestBook()
        {
            Book book;
            using (DBCont db = new DBCont())
            {
              book = db.Books.First();

            }
            return PartialView(book);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}