using myFirstProject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace myFirstProject.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "PROFILE PICTURE")]
        [Required(ErrorMessage = "Profile Picture Required")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "FULL NAME")]
        [Required(ErrorMessage = "FULL NAME Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name should be between 3 to 50 chars")]
        public string? FullName { get; set; }

        [Display(Name = "BIOGRAPHY")]
        [Required(ErrorMessage = "BIOGRAPHY Required")]
        public string? Bio { get; set; }

        //Realationship
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
