using Microsoft.AspNetCore.Mvc;
using myFirstProject.Data.Services;
using myFirstProject.Models;

namespace myFirstProject.Controllers
{
    public class ProducersController : Controller
    {

        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }

        //shows the index view
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producers)
        {
            if (!ModelState.IsValid)
            {
                return View(producers);
            }
            await _service.AddAsync(producers);
            return RedirectToAction("Index");
        }

        //get: Actors/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not found");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not found");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        // Edit: Producers/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Not found");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producer producers)
        {
            if (!ModelState.IsValid)
            {
                return View(producers);
            }
            await _service.UpdateAsync(id, producers);
            return RedirectToAction(nameof(Index));
        }


        // Get Details/1

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("ErrorViewModel");
            return View(producerDetails);
        }
    }
}
