using System.Collections.Generic;

namespace EvaCoreWeb.Models.ViewModels
{
    public class ReceitaFormViewModel
    {
        public Receita Receita { get; set; }
        public ICollection<Codigo> Codigos { get; set; }
    }
}
