using EvaCoreWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace EvaCoreWeb.Services
{
    public class CodigoService
    {
        private readonly EvaCoreWebContext _context;

        public CodigoService(EvaCoreWebContext context)
        {
            _context = context;
        }

        public List<Codigo> FindAll(string ordem)
        {
            if (ordem == "dsc_codigo") { return _context.Codigo.OrderBy(x => x.dsc_codigo).ToList(); }
            if (ordem == "isn_codigo") { return _context.Codigo.OrderBy(x => x.isn_codigo).ToList(); }
            return _context.Codigo.ToList();
        }

        public bool Insert(Codigo obj)
        {
            if (obj.dsc_codigo != "" && obj.dsc_codigo != null)
            {
                if (obj.dsc_codigo != null) obj.dsc_codigo = obj.dsc_codigo.ToUpper();
                if (obj.dsc_codigo_de_barra != null) obj.dsc_codigo_de_barra = obj.dsc_codigo_de_barra.ToUpper();
                if (obj.isn_status_codigo == 0)
                {
                    obj.isn_status_codigo = Models.Enums.Status.Ativo;
                }
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public Codigo FindById(int isn_codigo)
        {
            return _context.Codigo.FirstOrDefault(obj => obj.isn_codigo == isn_codigo);
        }

        public Codigo FindByBarCode(string dsc_codigo_de_barra)
        {
            return _context.Codigo.FirstOrDefault(obj => obj.dsc_codigo_de_barra == dsc_codigo_de_barra);
        }

        public void DesativaCodigo(int isn_codigo)
        {
            var obj = _context.Codigo.Find(isn_codigo);
        }
    }
}
