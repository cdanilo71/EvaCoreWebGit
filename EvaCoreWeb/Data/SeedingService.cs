using EvaCoreWeb.Models;
using EvaCoreWeb.Models.Enums;
using System.Linq;

namespace EvaCoreWeb.Data
{
    public class SeedingService
    {
        private EvaCoreWebContext _context;

        public SeedingService(EvaCoreWebContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            bool fez_algo = false;

            if (!_context.Grupo.Any())
            {
                Grupo g1 = new Grupo(1, "", Status.Ativo);
                Grupo g2 = new Grupo(2, "CAMA E BANHO", Status.Ativo);
                Grupo g3 = new Grupo(3, "LATICINIOS", Status.Ativo);
                Grupo g4 = new Grupo(4, "BEBIDAS", Status.Ativo);
                Grupo g5 = new Grupo(5, "FRUTAS E VERDURAS", Status.Ativo);
                Grupo g6 = new Grupo(6, "UTENSILIOS DE COZINHA", Status.Ativo);
                Grupo g7 = new Grupo(7, "MANUTENCAO E AFINS", Status.Ativo);
                Grupo g8 = new Grupo(8, "PEIXES E MARISCOS", Status.Ativo);

                _context.Grupo.AddRange(g1, g2, g3, g4, g5, g6, g7, g8);
                fez_algo = true;
            }

            if (!_context.SubGrupo.Any())
            {
                SubGrupo sg1 = new SubGrupo(1, "", Status.Ativo);
                SubGrupo sg2 = new SubGrupo(2, "CAMA E BANHO", Status.Ativo);
                SubGrupo sg3 = new SubGrupo(3, "LATICINIOS", Status.Ativo);
                SubGrupo sg4 = new SubGrupo(4, "BEBIDAS", Status.Ativo);
                SubGrupo sg5 = new SubGrupo(5, "FRUTAS E VERDURAS", Status.Ativo);
                SubGrupo sg6 = new SubGrupo(6, "UTENSILIOS DE COZINHA", Status.Ativo);
                SubGrupo sg7 = new SubGrupo(7, "MANUTENCAO E AFINS", Status.Ativo);
                SubGrupo sg8 = new SubGrupo(8, "PEIXES E MARISCOS", Status.Ativo);

                _context.SubGrupo.AddRange(sg1, sg2, sg3, sg4, sg5, sg6, sg7, sg8);
                fez_algo = true;
            }

            if (!_context.UnidadeMedidaEstoque.Any())
            {
                UnidadeMedidaEstoque ume1 = new UnidadeMedidaEstoque(1, "", "", Status.Ativo);
                UnidadeMedidaEstoque ume2 = new UnidadeMedidaEstoque(2, "QUILOGRAMA", "KG", Status.Ativo);
                UnidadeMedidaEstoque ume3 = new UnidadeMedidaEstoque(3, "UNIDADE", "UND", Status.Ativo);
                UnidadeMedidaEstoque ume4 = new UnidadeMedidaEstoque(4, "LITRO", "L", Status.Ativo);
                UnidadeMedidaEstoque ume5 = new UnidadeMedidaEstoque(5, "VARIOS", "VRS", Status.Ativo);

                _context.UnidadeMedidaEstoque.AddRange(ume1, ume2, ume3, ume4, ume5);
                fez_algo = true;
            }

            if (!_context.Codigo.Any())
            {
                Codigo c1 = new Codigo(1, 1, 1, 1, "","", 0, 0, 0, 0, Status.Ativo);
                Codigo c2 = new Codigo(2, 3, 3, 3, "LEITE DE VACA", "", 0, 0, 0, 0, Status.Ativo);
                Codigo c3 = new Codigo(3, 1, 1, 1, "ROBALO", "", 0, 0, 0, 0, Status.Ativo);
                Codigo c4 = new Codigo(4, 1, 1, 1, "POLVO", "", 0, 0, 0, 0, Status.Ativo);
                Codigo c5 = new Codigo(5, 1, 1, 1, "SURURU", "", 0, 0, 0, 0, Status.Ativo);
                Codigo c6 = new Codigo(6, 1, 1, 1, "ARRAIA", "", 0, 0, 0, 0, Status.Ativo);
                Codigo c7 = new Codigo(7, 1, 1, 1, "BEIJUPIRA", "", 0, 0, 0, 0, Status.Ativo);
                Codigo c8 = new Codigo(8, 1, 1, 1, "PEIXE VERMELHO", "", 0, 0, 0, 0, Status.Ativo);
                Codigo c9 = new Codigo(9, 7, 7, 4, "PREGO", "", 0, 0, 0, 0, Status.Ativo);

                _context.Codigo.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9);
                fez_algo = true;
            }

            if (!_context.Receita.Any())
            {
                Receita r1 = new Receita(1, 1, "", Status.Ativo);

                _context.Receita.AddRange(r1);
                fez_algo = true;
            }

            if (!fez_algo)
            {
                return; //se nao populou nenhuma tabela ja sai daqui
            }

            _context.SaveChanges();
        }
    }
}
