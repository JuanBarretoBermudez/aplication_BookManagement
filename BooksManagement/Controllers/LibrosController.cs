using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksManagement.Controllers
{
    public class LibrosController : Controller
    {
        private Models.BookManagementContext _db;

        public LibrosController(Models.BookManagementContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Models.Libro> libList = new List<Models.Libro>();

            using (_db)
            {
                libList = (from lib in _db.Libros
                          select new Models.Libro
                          {
                              Id = lib.Id,
                              UserId = lib.UserId,
                              Title = lib.Title,
                              Body = lib.Body
                          }).ToList();
            }
            return View(libList);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(DTO.Libro libro)
        {

            if (!ModelState.IsValid)
            {
                return View(libro);
            }
            else
            {
                using (_db)
                {
                    Models.Libro libro1 = new Models.Libro();
                    libro1.Id = libro.Id;
                    libro1.UserId = libro.UserId;
                    libro1.Title = libro.Title;
                    libro1.Body = libro.Body;
                    _db.Libros.Add(libro1);
                    _db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
