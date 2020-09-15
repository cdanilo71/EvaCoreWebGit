using System.Collections.Generic;

namespace EvaCoreWeb.Models.ViewModels
{
    public class CodigoFormViewModel
    {
        public string Mensagem { get; set; }
        public Codigo Codigo { get; set; }
        public ICollection<Grupo> Grupos { get; set; }
        public ICollection<SubGrupo> SubGrupos { get; set; }
        public ICollection<UnidadeMedidaEstoque> UnidadeMedidaEstoques { get; set; }
    }
}
