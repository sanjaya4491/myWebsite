using myFirstProject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace myFirstProject.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Cinema Logo Required")]
        public string? Logo { get; set; }

        [Required(ErrorMessage = "Name of the Cinema Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Cinema Name should be between 3 to 50 chars")]
        [Display(Name = "Name of the Cinema")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description Required")]
        public string? Description { get; set; }

    }
}
