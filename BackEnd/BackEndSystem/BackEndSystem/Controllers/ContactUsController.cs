using System;
using BackEndSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace BackEndSystem.Controllers
{
    [Route("api/ContactUs")]
    public class ContactUsController : Controller
    {

        private readonly LibraryContext _context;
        public ContactUsController(LibraryContext context)
        {
            _context = context;

            if (_context.ContactUs.Count() == 0)
            {
                _context.ContactUs.Add(new ContactUs { Id = 1, ContactEmail = "jondoe@yahoo.com", FullName = "Jon Doe", Message = "I got this controller thing all figured out, BABY!" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<ContactUs> GetAll()
        {
            return _context.ContactUs.ToList();
        }

    }
}
