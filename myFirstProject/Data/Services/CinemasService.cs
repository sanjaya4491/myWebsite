using myFirstProject.Models;
using myFirstProject.Data.Base;

namespace myFirstProject.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICenimasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }
}
