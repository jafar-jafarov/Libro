using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libro.Models.Entities
{
    public class Abouts : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}
