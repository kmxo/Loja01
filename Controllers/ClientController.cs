using Loja01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja01.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            ClientViewModel client = new ClientViewModel()
            {
                Name = "Carlos Camacho",
                Email = "carlos.camacho@email.com",
                Phone = "+351 345 678 901"

            };

            return View(client);
        }

        public IActionResult Create()
        {
            var client = new ClientViewModel();

            return View(client);
        }

        public IActionResult CreateClient(ClientViewModel client)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
