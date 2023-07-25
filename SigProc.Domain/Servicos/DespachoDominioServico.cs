using AutoMapper;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Servicos
{
    public class DespachoDominioServico : BaseDominioServico<Despacho>, IDespachoDominioServico
    {
        private readonly IDespachoRepositorio _repositorio;

        public DespachoDominioServico(IDespachoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }
    }
}
