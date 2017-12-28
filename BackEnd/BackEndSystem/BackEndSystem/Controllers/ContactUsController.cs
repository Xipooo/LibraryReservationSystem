using System;
using BackEndSystem.EF;
using Microsoft.AspNetCore.Mvc;

namespace BackEndSystem.Controllers
{
    public class ContactUsController : Controller
    {
        LibraryContext db = new LibraryContext();

        [HttpPost]
        public IActionResult Post(ContactUs contactUs)
        {
            try
            {
                db.ContactUs.Add(contactUs);
                db.SaveChanges();
                return base.Ok();
            }
            catch (Exception e)
            {
                return base.BadRequest();
            }
        }
    }
}