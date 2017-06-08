using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HabeshaCrafts.Models
{
    public partial class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}