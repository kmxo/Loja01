using System.Security.Cryptography.X509Certificates;
using Loja01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loja01.Controllers
{
    public class ClientController : Controller
    {
        private static List<ClientViewModel> clients = new List<ClientViewModel>();

        public IActionResult Index()
        {
            /*
            ClientViewModel client = new ClientViewModel()
            {
                Name = "Carlos Camacho",
                Email = "carlos.camacho@email.com",
                Phone = "+351 345 678 901"

            };*/

            return View(clients);
        }

        public IActionResult Create()
        {
            var client = new ClientViewModel();
            return View(client);
        }

        public IActionResult CreateClient(ClientViewModel client)
        {
            clients.Add(client);
            return RedirectToAction(nameof(Index));
        }
    }
}
