namespace EvaCoreWeb.Models.Enums
{
    public enum Abreviacao : int
    {
        Isn_InternalSerialNumber = 1, //chave primaria da tabela - campo int
        Dsc_Descricao = 2, //define um campo string para descrever ou definir algo
        Cod_Codigo = 3, //campo string que definir um codigo auxiliar de qualquer natureza
        Dat_DateTime = 4, //data padrao do sistema evacoreweb - campo datetime
        Flg_Flag = 5, //define um campo falso ou verdadeiro - campo bool
        Qtd_Quantidade = 6, //define um campo quantidade que pode ser double ou int
        Val_Valor = 7, //define um campo valor que pode ser double ou int
        Isn_Status = 8 //sempre o ultimo registro da tabela - campo int
    }
}
