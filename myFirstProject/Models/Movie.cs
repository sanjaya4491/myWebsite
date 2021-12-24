using myFirstProject.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myFirstProject.Models
{
    public class Movie
    {
        [Key]

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImgURL { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }


        //Relationshiop

        public List<Actor_Movie>? Actors_Movies { get; set;}


        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema? Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }

    }


}
