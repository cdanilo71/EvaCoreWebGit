using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EvaCoreWeb.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classificacao",
                columns: table => new
                {
                    isn_classificacao = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dsc_classificacao = table.Column<string>(nullable: true),
                    isn_status_classificacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classificacao", x => x.isn_classificacao);
                });

            migrationBuilder.CreateTable(
                name: "Codigo",
                columns: table => new
                {
                    isn_codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    isn_grupo = table.Column<int>(nullable: false),
                    isn_subgrupo = table.Column<int>(nullable: false),
                    isn_unidade_medida_estoque = table.Column<int>(nullable: false),
                    dsc_codigo = table.Column<string>(nullable: true),
                    dsc_codigo_de_barra = table.Column<string>(nullable: true),
                    qtd_codigo = table.Column<double>(nullable: false),
                    val_ultimo_custo_medio = table.Column<double>(nullable: false),
                    val_ultima_compra = table.Column<double>(nullable: false),
                    val_preco_venda = table.Column<double>(nullable: false),
                    isn_status_codigo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codigo", x => x.isn_codigo);
                });

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    isn_grupo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dsc_grupo = table.Column<string>(nullable: true),
                    isn_status_grupo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.isn_grupo);
                });

            migrationBuilder.CreateTable(
                name: "SubGrupo",
                columns: table => new
                {
                    isn_subgrupo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dsc_subgrupo = table.Column<string>(nullable: true),
                    isn_status_subgrupo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGrupo", x => x.isn_subgrupo);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    isn_tag = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dsc_tag = table.Column<string>(nullable: true),
                    isn_status_tag = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.isn_tag);
                });

            migrationBuilder.CreateTable(
                name: "UnidadeMedidaEstoque",
                columns: table => new
                {
                    isn_unidade_medida_estoque = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dsc_unidade_medida_estoque = table.Column<string>(nullable: true),
                    cod_unidade_medida_estoque = table.Column<string>(nullable: true),
                    isn_status_unidade_medida_estoque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeMedidaEstoque", x => x.isn_unidade_medida_estoque);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classificacao");

            migrationBuilder.DropTable(
                name: "Codigo");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "SubGrupo");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "UnidadeMedidaEstoque");
        }
    }
}
