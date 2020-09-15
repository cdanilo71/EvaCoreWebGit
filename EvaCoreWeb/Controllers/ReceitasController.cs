using EvaCoreWeb.Services;
using Microsoft.AspNetCore.Mvc;
using EvaCoreWeb.Models;
using EvaCoreWeb.Models.ViewModels;
using System.Diagnostics;

namespace EvaCoreWeb.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly ReceitaService _receitaService;
        private readonly CodigoService _codigoService;

        public ReceitasController(ReceitaService receitaService, CodigoService codigoService)
        {
            _receitaService = receitaService;
            _codigoService = codigoService;
        }

        public IActionResult Index()
        {
            var list = _receitaService.FindAll();
            return View(list);
        }

        public IActionResult Editar()
        {
            var list = _receitaService.FindAll();
            return View(list);
        }

        public IActionResult Create() //create GET
        {
            var codigos = _codigoService.FindAll("dsc_codigo");
            var viewModel = new ReceitaFormViewModel { Codigos = codigos};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Receita receita) //create POST
        {
            bool flg_gravou = _receitaService.Insert(receita);
            if (flg_gravou) return RedirectToAction(nameof(Index));
            else
            {
                return RedirectToAction(nameof(Create));
            }
        }

        public IActionResult Desativa(int? isn_receita) //a interrogacao do lado do int indica que o atributo isn_receita é opcional
        {
            if (isn_receita == null)
            {
                return NotFound();
            }

            var obj = _receitaService.FindById(isn_receita.Value); //pesquisa o registro com isn_receita igual ao parametro passado (coloco value pois o isn_receita pode ser null)

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        public IActionResult Error(string mensagem)
        {
            var viewModel = new ErrorViewModel
            {
                Mensagem = mensagem,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}