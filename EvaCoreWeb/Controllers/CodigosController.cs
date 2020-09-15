using EvaCoreWeb.Services;
using Microsoft.AspNetCore.Mvc;
using EvaCoreWeb.Models;
using EvaCoreWeb.Models.ViewModels;
using System.Diagnostics;

namespace EvaCoreWeb.Controllers
{
    public class CodigosController : Controller
    {
        private readonly CodigoService _codigoService;
        private readonly GrupoService _grupoService;
        private readonly SubGrupoService _subGrupoService;
        private readonly UnidadeMedidaEstoqueService _unidadeMedidaEstoqueService;

        public CodigosController(CodigoService codigoService, GrupoService grupoService, SubGrupoService subGrupoService, UnidadeMedidaEstoqueService unidadeMedidaEstoqueService)
        {
            _codigoService = codigoService;
            _grupoService = grupoService;
            _subGrupoService = subGrupoService;
            _unidadeMedidaEstoqueService = unidadeMedidaEstoqueService;
        }

        public IActionResult Index()
        {
            var list = _codigoService.FindAll("isn_codigo");
            return View(list);
        }

        public IActionResult Editar()
        {
            var list = _codigoService.FindAll("dsc_codigo");
            return View(list);
        }

        public IActionResult Create() //create GET
        {
            var grupos = _grupoService.FindAll();
            var subGrupos = _subGrupoService.FindAll();
            var unidadeMedidaEstoques = _unidadeMedidaEstoqueService.FindAll();
            var viewModel = new CodigoFormViewModel { Grupos = grupos, SubGrupos = subGrupos, UnidadeMedidaEstoques = unidadeMedidaEstoques};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Codigo codigo) //create POST
        {
            bool flg_gravou = _codigoService.Insert(codigo);
            if (flg_gravou) return RedirectToAction(nameof(Index));
            else
            {
                return RedirectToAction(nameof(Create));
            }
        }

        public IActionResult Desativa(int? isn_codigo) //a interrogacao do lado do int indica que o atributo isn_codigo é opcional
        {
            if (isn_codigo == null)
            {
                return NotFound();
            }

            var obj = _codigoService.FindById(isn_codigo.Value); //pesquisa o registro com isn_codigo igual ao parametro passado (coloco value pois o isn_codigo pode ser null)

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