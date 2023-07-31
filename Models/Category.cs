using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Category
    {
        // Primary key
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property for Posts in this Category.
        public virtual ICollection<Post> Posts { get; set; }
    }
}
