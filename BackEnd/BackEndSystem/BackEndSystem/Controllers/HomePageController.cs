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

            if (_context.HomePage.Count() ==0)
            {
                _context.HomePage.Add(new HomePage { LibraryName = "Waffle - O Library", LibraryDescr = "Welcome to the Waffle-O Library! We are the best library around! We have the most imperative selection of media! Check out online and we deliver the media to your door or you can rent digital media, for drop off box near you * click here *.  We have space to reserve for study groups, conferences, Lectures, or personal workspace.We have laptops, cameras, and projectors that are available for check -out with the Pro - Library - Account" });
                _context.SaveChanges();
            }

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


