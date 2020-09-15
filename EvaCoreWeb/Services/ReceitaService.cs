using System;
using System.Collections.Generic;
using System.Linq;
using EvaCoreWeb.Models;

namespace EvaCoreWeb.Services
{
    public class ReceitaService
    {
        private readonly EvaCoreWebContext _context;

        public ReceitaService(EvaCoreWebContext context)
        {
            _context = context;
        }

        public List<Receita> FindAll()
        {
            return _context.Receita.ToList();
        }

        public bool Insert(Receita obj)
        {
            if (obj.dsc_receita != "" && obj.dsc_receita != null)
            {
                if (obj.dsc_receita != null) obj.dsc_receita = obj.dsc_receita.ToUpper();
                if (obj.isn_status_receita == 0)
                {
                    obj.isn_status_receita = Models.Enums.Status.Ativo;
                }
                _context.Add(obj);
                _context.SaveChanges();
                return true;
            }
            else return false;
        }

        public Receita FindById(int isn_receita)
        {
            return _context.Receita.FirstOrDefault(obj => obj.isn_receita == isn_receita);
        }

        public void DesativaReceita(int isn_receita)
        {
            var obj = _context.Receita.Find(isn_receita);
        }
    }
}

