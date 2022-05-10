using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libro.Models.Entities
{
    public class Authors:BaseEntity
    {
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public ICollection<Books> Books { get; set; }
    }
}
    