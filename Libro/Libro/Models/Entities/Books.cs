using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Libro.Models.Entities
{
    public class Books : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public int CategoriesId { get; set; }
        public virtual Categories Categories { get; set; }
        public int AuthorsId { get; set; }
        public virtual Authors Authors { get; set; }
    }
}
