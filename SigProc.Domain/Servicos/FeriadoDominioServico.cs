using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using SigProc.Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Domimio.Servicos
{
    public class FeriadoDominioServico : BaseDominioServico<Feriado>, IFeriadoDominioServico
    {
        private readonly IFeriadoRepositorio _repositorio;
        public FeriadoDominioServico(IFeriadoRepositorio repository) : base(repository)
        {
            _repositorio = repository;
        }
    }
}
