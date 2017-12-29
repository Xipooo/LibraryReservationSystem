using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackEndSystem.Models;


namespace BackEndSystem.Controllers
{
    [Route("api/HomePage")]
    public class HomePageController : Controller
    {
        private readonly LibraryContext _context;
        public HomePageController(LibraryContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<HomePage> GetAll()
        {
            return _context.HomePage.ToList();
        }

        [HttpGet("{id}", Name = "GetHomePage")]
        public IActionResult GetByID(long id)
        {
            var home = _context.HomePage.FirstOrDefault(t => t.Id == id);
            if (home == null)
            {
                return NotFound();
            }
            return new ObjectResult(home);
        }

    }
}


