using System.ComponentModel.DataAnnotations;

namespace myFirstProject.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "PROFILE PICTURE")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "FULL NAME")]
        public string? FullName { get; set; }

        [Display(Name = "BIOGRAPHY")]
        public string? Bio { get; set; }

        //Realationship

        public List<Actor_Movie>? Actors_Movies { get; set;}
    }
}
