using EvaCoreWeb.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EvaCoreWeb.Models
{
    public class Codigo
    {
        [Key]
        [Display(Name = "Isn Codigo")]
        public int isn_codigo { get; set; }
        [Display(Name = "Isn Grupo")]
        public int isn_grupo { get; set; }
        [Display(Name = "Isn SubGrupo")]
        public int isn_subgrupo { get; set; }
        [Display(Name = "Isn Uniddade Medida")]
        public int isn_unidade_medida_estoque { get; set; }
        [Display(Name = "Descrição do Codigo")]
        public string dsc_codigo { get; set; }
        [Display(Name = "Codigo de Barra")]
        public string dsc_codigo_de_barra { get; set; }
        [Display(Name = "Qtd em Estoque")]
        [DisplayFormat(DataFormatString = "{0:F2}")] //o zero indica que é numero e o F2 indica que sao duas casas decimais
        public double qtd_codigo { get; set; }
        [Display(Name = "Valor do Ultimo Custo Médio")]
        [DisplayFormat(DataFormatString = "{0:F2}")] //o zero indica que é numero e o F2 indica que sao duas casas decimais
        public double val_ultimo_custo_medio { get; set; }
        [Display(Name = "Valor da Ultima Compra")]
        [DisplayFormat(DataFormatString = "{0:F2}")] //o zero indica que é numero e o F2 indica que sao duas casas decimais
        public double val_ultima_compra { get; set; }
        [Display(Name = "Preço de Venda")]
        [DisplayFormat(DataFormatString = "{0:F2}")] //o zero indica que é numero e o F2 indica que sao duas casas decimais
        public double val_preco_venda { get; set; }
        [Display(Name = "Status do Codigo")]
        public Status isn_status_codigo { get; set; }

        public Codigo()
        {

        }

        public Codigo(int isn_codigo, int isn_grupo, int isn_subgrupo, int isn_unidade_medida_estoque, string dsc_codigo, string dsc_codigo_de_barra, double qtd_codigo, double val_ultimo_custo_medio, double val_ultima_compra, double val_preco_venda, Status isn_status_codigo)
        {
            this.isn_codigo = isn_codigo;
            this.isn_grupo = isn_grupo;
            this.isn_subgrupo = isn_subgrupo;
            this.isn_unidade_medida_estoque = isn_unidade_medida_estoque;
            this.dsc_codigo = dsc_codigo;
            this.dsc_codigo_de_barra = dsc_codigo_de_barra;
            this.qtd_codigo = qtd_codigo;
            this.val_ultimo_custo_medio = val_ultimo_custo_medio;
            this.val_ultima_compra = val_ultima_compra;
            this.val_preco_venda = val_preco_venda;
            this.isn_status_codigo = isn_status_codigo;
        }
    }
}
