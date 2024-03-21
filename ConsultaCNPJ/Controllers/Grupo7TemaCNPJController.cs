using ConsultaCNPJ.Infraestrutura;
using ConsultaCNPJ.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaCNPJ.Controllers
{
    public class Grupo7TemaCNPJController : Controller
    {
        private readonly ILogger<Grupo7TemaCNPJController> _logger;

        private const string ENDPOINT = "https://localhost:7021/api/Grupo7TemaCNPJ";
        //private const string ENDPOINT = "https://brasilapi.com.br/api/cnpj/v1";

        public Grupo7TemaCNPJController(ILogger<Grupo7TemaCNPJController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult ConsultarCPNJ(string cnpj)
        {
            var route = $"{cnpj}";
            var api = new HelperAPI(ENDPOINT);
            var result = api.MetodoGET<ConsultaCPNJOutPut>(route).Result;

            return PartialView("dadosCNPJ", result);
        }
    }
}
