using EvaCoreWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EvaCoreWeb.Models
{
    public class Classificacao
    {
        [Key]
        public int isn_classificacao{ get; set; }
        public string dsc_classificacao { get; set; }
        public Status isn_status_classificacao { get; set; }

        public Classificacao()
        {
        }

        public Classificacao(int isn_classificacao, string dsc_classificacao, Status isn_status_classificacao)
        {
            this.isn_classificacao = isn_classificacao;
            this.dsc_classificacao = dsc_classificacao;
            this.isn_status_classificacao = isn_status_classificacao;
        }
    }
}
