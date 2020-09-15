using EvaCoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EvaCoreWeb.Services
{
    public class SubGrupoService
    {
        private readonly EvaCoreWebContext _context;

        public SubGrupoService(EvaCoreWebContext context)
        {
            _context = context;
        }

        public List<SubGrupo> FindAll()
        {
            return _context.SubGrupo.OrderBy(x => x.dsc_subgrupo).ToList();
        }

        public void Insert(SubGrupo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
