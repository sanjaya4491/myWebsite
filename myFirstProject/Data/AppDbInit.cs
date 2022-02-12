using myFirstProject.Models;
using Microsoft.AspNetCore.Builder;

namespace myFirstProject.Data
{
    public class AppDbInit
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();



                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>() {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Description = "I don't know this is the first description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "",
                            Description = "I don't know this is the first description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "",
                            Description = "I don't know this is the first description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "",
                            Description = "I don't know this is the first description"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "",
                            Description = "I don't know this is the first description"
                        }
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {

                    context.Actors.AddRange(new List<Actor>() {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "Idk bio for actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "Idk bio for actor 2",
                            ProfilePictureURL = "https://d26oc3sg82pgk3.cloudfront.net/files/media/edit/image/34169/article_full%401x.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "Idk bio for actor 3",
                            ProfilePictureURL = "https://d26oc3sg82pgk3.cloudfront.net/files/media/edit/image/34169/article_full%401x.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "Idk bio for actor 4",
                            ProfilePictureURL = "https://d26oc3sg82pgk3.cloudfront.net/files/media/edit/image/34169/article_full%401x.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "Idk bio for actor 5",
                            ProfilePictureURL = "https://d26oc3sg82pgk3.cloudfront.net/files/media/edit/image/34169/article_full%401x.jpg"
                        }
                    });

                    context.SaveChanges();

                }

                // Producers

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer(){
                            FullName = "producer 1",
                            Bio = "This is the Bio for the producer",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg."
                        },
                        new Producer(){
                            FullName = "producer 2",
                            Bio = "This is the Bio for the producer",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg."
                        },
                        new Producer(){
                            FullName = "producer 3",
                            Bio = "This is the Bio for the producer",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg."
                        },
                        new Producer(){
                            FullName = "producer 4",
                            Bio = "This is the Bio for the producer",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg."
                        },
                        new Producer(){
                            FullName = "producer 5",
                            Bio = "This is the Bio for the producer",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg."
                        }

                    });

                    context.SaveChanges();
                }

                // Movies

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() {

                        new Movie(){
                            Name ="movie 1",
                            Description ="IDK descrp for movie",
                            Price = 99,
                            ImgURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(2),
                            CinemaId =  1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.comedy

                        },

                        new Movie(){
                            Name ="movie 2",
                            Description ="IDK descrp for movie",
                            Price = 99,
                            ImgURL = "TODO movie pic",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(2),
                            CinemaId =  2,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.comedy

                        },
                          new Movie(){
                            Name ="movie 3",
                            Description ="IDK descrp for movie",
                            Price = 99,
                            ImgURL = "TODO movie pic",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(2),
                            CinemaId =  3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.comedy

                        },
                            new Movie(){
                                Name ="movie 4",
                                Description ="IDK descrp for movie",
                                Price = 99,
                                ImgURL = "TODO movie pic",
                                StartDate = DateTime.Now.AddDays(2),
                                EndDate = DateTime.Now.AddDays(2),
                                CinemaId =  4,
                                ProducerId = 4,
                                MovieCategory = MovieCategory.comedy

                        },
                            new Movie(){
                                Name ="movie 5",
                                Description ="IDK descrp for movie",
                                Price = 99,
                                ImgURL = "TODO movie pic",
                                StartDate = DateTime.Now.AddDays(2),
                                EndDate = DateTime.Now.AddDays(2),
                                CinemaId =  5,
                                ProducerId = 5,
                                MovieCategory = MovieCategory.comedy

                        },


                    });

                    context.SaveChanges();
                }

                // Actors && Movies

                if (context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>() {
                        new Actor_Movie(){
                            ActorId = 1,
                            MovieId = 1,
                        },
                        new Actor_Movie(){
                            ActorId = 2,
                            MovieId = 2,
                        },
                        new Actor_Movie(){
                            ActorId = 3,
                            MovieId = 3,
                        },
                        new Actor_Movie(){
                            ActorId = 4,
                            MovieId = 4,
                        },
                    });

                    context.SaveChanges();
                }

            }
        }
    }
}
