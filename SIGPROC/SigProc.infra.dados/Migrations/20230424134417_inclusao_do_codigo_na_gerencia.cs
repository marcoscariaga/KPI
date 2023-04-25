﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class inclusaodocodigonagerencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Gerencia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Gerencia");
        }
    }
}
