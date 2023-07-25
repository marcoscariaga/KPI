﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SigProc.infra.dados.Migrations
{
    /// <inheritdoc />
    public partial class processotramitacaoajustes01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoTramitacao_Usuario_IdUsuarioTramitacao",
                table: "ProcessoTramitacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoTramitacao_IdUsuarioTramitacao",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "ProcessoTramitacao");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioTramitacao",
                table: "ProcessoTramitacao",
                newName: "Sequencia");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDigitacao",
                table: "ProcessoTramitacao",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataRecebimento",
                table: "ProcessoTramitacao",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Guia",
                table: "ProcessoTramitacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDespacho",
                table: "ProcessoTramitacao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MatriculaDespacho",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatriculaDigitador",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatriculaRecebedor",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoTramitacao_IdDespacho",
                table: "ProcessoTramitacao",
                column: "IdDespacho");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoTramitacao_Despacho_IdDespacho",
                table: "ProcessoTramitacao",
                column: "IdDespacho",
                principalTable: "Despacho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcessoTramitacao_Despacho_IdDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.DropIndex(
                name: "IX_ProcessoTramitacao_IdDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "DataDigitacao",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "DataRecebimento",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "Guia",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "IdDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "MatriculaDespacho",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "MatriculaDigitador",
                table: "ProcessoTramitacao");

            migrationBuilder.DropColumn(
                name: "MatriculaRecebedor",
                table: "ProcessoTramitacao");

            migrationBuilder.RenameColumn(
                name: "Sequencia",
                table: "ProcessoTramitacao",
                newName: "IdUsuarioTramitacao");

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "ProcessoTramitacao",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessoTramitacao_IdUsuarioTramitacao",
                table: "ProcessoTramitacao",
                column: "IdUsuarioTramitacao");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessoTramitacao_Usuario_IdUsuarioTramitacao",
                table: "ProcessoTramitacao",
                column: "IdUsuarioTramitacao",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}