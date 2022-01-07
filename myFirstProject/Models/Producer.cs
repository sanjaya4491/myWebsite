using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myFirstProject.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "PROFILE PICTURE")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "FULL NAME")]
        public string? FullName { get; set; }

        [Display(Name = "BIO")]
        public string? Bio { get; set; }

        //Relationships

        public List<Movie>? Movies { get; set;}

      
    }
}
