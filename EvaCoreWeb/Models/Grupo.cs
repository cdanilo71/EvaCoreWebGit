using EvaCoreWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EvaCoreWeb.Models
{
    public class Grupo
    {
        [Key]
        public int isn_grupo { get; set; }
        public string dsc_grupo { get; set; }
        public Status isn_status_grupo { get; set; }

        public Grupo()
        {
        }

        public Grupo(int isn_grupo, string dsc_grupo, Status isn_status_grupo)
        {
            this.isn_grupo = isn_grupo;
            this.dsc_grupo = dsc_grupo;
            this.isn_status_grupo = isn_status_grupo;
        }
    }
}
