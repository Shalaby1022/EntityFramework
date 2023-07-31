using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Post
    {

        // Primary key
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        // Foreign key for Author table.
        public int AuthorId { get; set; }

        // Navigation property for the Author of this Post.
        public virtual Author Author { get; set; }

        // Foreign key for Category table.
        public int CategoryId { get; set; }

        // Navigation property for the Category of this Post.
        public virtual Category Category { get; set; }


    }
}
