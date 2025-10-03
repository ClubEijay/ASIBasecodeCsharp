using System;
using System.ComponentModel.DataAnnotations;

namespace ASI.Basecode.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Author is required!")]
        public string Author { get; set; }
        
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
