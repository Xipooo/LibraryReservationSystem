using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndSystem.Models
{

    public class ContactUs
    {
        public int Id { get; set; }
        public string ContactEmail { get; set; }
        public string FullName { get; set; }
        public string Message { get; set; }

    }
}