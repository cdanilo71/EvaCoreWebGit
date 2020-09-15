using EvaCoreWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EvaCoreWeb.Models
{
    public class SubGrupo
    {
        [Key]
        public int isn_subgrupo { get; set; }
        public string dsc_subgrupo { get; set; }
        public Status isn_status_subgrupo { get; set; }

        public SubGrupo()
        {
        }

        public SubGrupo(int isn_subgrupo, string dsc_subgrupo, Status isn_status_subgrupo)
        {
            this.isn_subgrupo = isn_subgrupo;
            this.dsc_subgrupo = dsc_subgrupo;
            this.isn_status_subgrupo = isn_status_subgrupo;
        }
    }
}
