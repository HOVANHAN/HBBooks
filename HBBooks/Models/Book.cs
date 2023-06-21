using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HBBooks.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public string Description { get; set; }


        public int? Price { get; set; }
    }
}
