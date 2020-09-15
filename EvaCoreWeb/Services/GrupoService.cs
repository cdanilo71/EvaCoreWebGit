using EvaCoreWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace EvaCoreWeb.Services
{
    public class GrupoService
    {
        private readonly EvaCoreWebContext _context;

        public GrupoService(EvaCoreWebContext context)
        {
            _context = context;
        }

        public List<Grupo> FindAll()
        {
            return _context.Grupo.OrderBy(x => x.dsc_grupo).ToList();
        }

        public void Insert(Grupo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
