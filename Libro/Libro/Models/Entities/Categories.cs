using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libro.Models.Entities
{
    public class Categories:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryLink { get; set; }
        public ICollection<Books> Books { get; set; }
    }
}
