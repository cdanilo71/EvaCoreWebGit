using EvaCoreWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EvaCoreWeb.Models
{
    public class UnidadeMedidaEstoque
    {
        [Key]
        public int isn_unidade_medida_estoque { get; set; }
        public string dsc_unidade_medida_estoque { get; set; }
        public string cod_unidade_medida_estoque { get; set; }
        public Status isn_status_unidade_medida_estoque { get; set; }

        public UnidadeMedidaEstoque()
        {
        }

        public UnidadeMedidaEstoque(int isn_unidade_medida_estoque, string dsc_unidade_medida_estoque, string cod_unidade_medida_estoque, Status isn_status_unidade_medida_estoque)
        {
            this.isn_unidade_medida_estoque = isn_unidade_medida_estoque;
            this.dsc_unidade_medida_estoque = dsc_unidade_medida_estoque;
            this.cod_unidade_medida_estoque = cod_unidade_medida_estoque;
            this.isn_status_unidade_medida_estoque = isn_status_unidade_medida_estoque;
        }
    }
}
