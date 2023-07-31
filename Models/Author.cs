using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Author
    {
        // Primary key
        public int Id { get; set; }

        // Required attribute ensures the Name property cannot be null or empty.
        [Required]
        public string Name { get; set; }

        // Age must be greater than or equal to 18.
        [Range(18, int.MaxValue, ErrorMessage = "Age must be greater than or equal to 18.")]
        public int Age { get; set; }

        public string Address { get; set; }

        // EmailAddress ensures the Email property has a valid email format.
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; }

        // Navigation property for Posts authored by this Author.
        public virtual ICollection<Post> Posts { get; set; }



    }
}
