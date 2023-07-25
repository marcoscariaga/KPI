﻿using SigProc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Dominio.Entidades
{
    public class Gerencia : Base
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string? Sigla { get; set; }
        public int Prazo { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public int IdUsuarioResp { get; set; }
      //  public string? Status { get; set; }

        public virtual Usuario Usuario { get; set; }

    }
}