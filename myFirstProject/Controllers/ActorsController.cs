using Microsoft.AspNetCore.Mvc;
using myFirstProject.Data;
using myFirstProject.Data.Services;
using System.Threading.Tasks;

namespace myFirstProject.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service) {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }


        //get: Actors/Create
        public IActionResult Create() { 
            return View();
        }
    }
}
                              