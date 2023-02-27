using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gerencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gerencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContratacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContratacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProcesso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProcesso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataEdicao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gerencia");

            migrationBuilder.DropTable(
                name: "TipoContratacao");

            migrationBuilder.DropTable(
                name: "TipoProcesso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
