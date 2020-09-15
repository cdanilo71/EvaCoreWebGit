using EvaCoreWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;
namespace EvaCoreWeb.Models
{
    public class Receita
    {
        [Key]
        [Display(Name = "Isn Receita")]
        public int isn_receita { get; set; }
        [Display(Name = "Isn Codigo")]
        public int isn_codigo { get; set; }
        [Display(Name = "Descrição da Receita")]
        public string dsc_receita { get; set; }
        [Display(Name = "Status da Receita")]
        public Status isn_status_receita { get; set; }

        public Receita()
        {

        }

        public Receita(int isn_receita, int isn_codigo, string dsc_receita, Status isn_status_receita)
        {
            this.isn_receita = isn_receita;
            this.isn_codigo = isn_codigo;
            this.dsc_receita = dsc_receita;
            this.isn_status_receita = isn_status_receita;
        }
    }
}
