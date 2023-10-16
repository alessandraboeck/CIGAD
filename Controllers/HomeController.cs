using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projetoUC08.Models;

namespace projetoUC08.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Noticias()
        {
            return View();
        }

        public IActionResult Entreterimento()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato(Usuario u)
        {
            MensagemRepository msg = new MensagemRepository();
            msg.Insert(u);

            ViewBag.Mensagem = "Mensagem enviada com sucesso!";

            return View();
        }
        public IActionResult Privacy()
        {
            MensagemRepository msg = new MensagemRepository();
            msg.testeConexao();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
