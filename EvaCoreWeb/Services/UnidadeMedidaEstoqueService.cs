using EvaCoreWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace EvaCoreWeb.Services
{
    public class UnidadeMedidaEstoqueService
    {
        private readonly EvaCoreWebContext _context;

        public UnidadeMedidaEstoqueService(EvaCoreWebContext context)
        {
            _context = context;
        }

        public List<UnidadeMedidaEstoque> FindAll()
        {
            return _context.UnidadeMedidaEstoque.OrderBy(x => x.dsc_unidade_medida_estoque).ToList();
        }

        public void Insert(UnidadeMedidaEstoque obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
