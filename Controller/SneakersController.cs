using SneakerSpot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerSpot.Controller
{
    public class SneakersController : Controller
    {
        private readonly SneakerService _sneakerService;

        public SneakersController(SneakerService sneakerService)
        {
            _sneakerService = sneakerService;
        }

        public IActionResult Index()
        {
            var sneakers = _sneakerService.GetAllSneakers();
            return View(sneakers);
        }
    }

}
