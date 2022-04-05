using Microsoft.AspNetCore.Mvc;
using myFirstProject.Data.Services;
using myFirstProject.Models;

namespace myFirstProject.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICenimasService _service;

        public CinemasController(ICenimasService service)
        {
            _service = service;
        }


        // gets all the cinemas
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }

        // create/?

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Logo,Description")] Cinema cinemas)
        {
            if (!ModelState.IsValid)
            {
                return View(cinemas);
            }
            await _service.AddAsync(cinemas);
            return RedirectToAction(nameof(Index));
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
        public async Task<IActionResult> Edit(int id, Cinema cinemas)
        {
            if (!ModelState.IsValid)
            {
                return View(cinemas);
            }
            await _service.UpdateAsync(id, cinemas);
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
