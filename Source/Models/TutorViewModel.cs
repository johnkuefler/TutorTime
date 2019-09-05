using System.ComponentModel.DataAnnotations;

namespace TutorTime.Models
{
    public class TutorViewModel 
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
