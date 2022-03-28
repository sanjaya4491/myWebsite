using myFirstProject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace myFirstProject.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "PROFILE PICTURE")]
        public string? ProfilePictureURL { get; set; }

        [Display(Name = "FULL NAME")]
        public string? FullName { get; set; }

        [Display(Name = "BIOGRAPHY")]
        public string? Bio { get; set; }

        //Relationships

        public List<Movie>? Movies { get; set; }


    }
}
