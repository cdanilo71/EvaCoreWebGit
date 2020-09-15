
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaCoreWeb.Models;

namespace EvaCoreWeb.Models
{
    public class EvaCoreWebContext : DbContext
    {
        public EvaCoreWebContext (DbContextOptions<EvaCoreWebContext> options)
            : base(options)
        {
        }
        public DbSet<EvaCoreWeb.Models.Classificacao> Classificacao { get; set; }
        public DbSet<EvaCoreWeb.Models.Tag> Tag { get; set; }
        public DbSet<EvaCoreWeb.Models.Codigo> Codigo { get; set; }
        public DbSet<EvaCoreWeb.Models.Grupo> Grupo { get; set; }
        public DbSet<EvaCoreWeb.Models.SubGrupo> SubGrupo { get; set; }
        public DbSet<EvaCoreWeb.Models.UnidadeMedidaEstoque> UnidadeMedidaEstoque { get; set; }
        public DbSet<EvaCoreWeb.Models.Receita> Receita { get; set; }
    }
}
