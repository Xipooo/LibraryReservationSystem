using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndSystem.Models
{
    public class BookList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int authorId { get; set; }
        public int GenreId { get; set; }
        public string DatePublished { get; set; }
        public int MediaTypeId { get; set; }
    }
}
